using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Memorama.Model {
    public class Correo {

        public String GenerarCodigo() {
            int longitud = 7;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++) {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }
            return token.ToString();
        }

       public (string, String) EnviarCorreo(String destino) {
            String code = GenerarCodigo();
            String body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Gracias por registrarse, su código de confirmación es: </h1>" + code +
                            "</br> <h2>No contestar este correo.</h2>";

            String mensaje =  "Error al enviar mensaje";
            String from = "memoramaregister@hotmail.com";
            String displayName = "Memorama";

            try {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(destino);

                mail.Subject = "Código de confirmación";
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(from, "verdeblancorojo99");
                client.EnableSsl = true;

                client.Send(mail);
                mensaje = "¡Se ha enviado el código de activación a su correo!";


            } catch (SmtpException ex) {
                mensaje = ex.Message;
            } catch (FormatException ex ) {
                mensaje = ex.Message;
            }
            return (mensaje, code);
        }
    }
}
