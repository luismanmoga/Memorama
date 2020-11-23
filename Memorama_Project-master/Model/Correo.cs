using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Memorama.Model {
    class Correo {

        public void Enviar(String correo) {
            MailMessage email = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            email.To.Add(new MailAddress(correo));
            email.From = new MailAddress(correo);
            email.Subject = "CODE ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            email.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            smtp.Host = "gmail.com";
            smtp.Port = 2525;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("memoramaapp@gmail.com", "tecnologiasparalaconstruccion");

            string output = null;

           // try {
                smtp.Send(email);
                email.Dispose();
               // output = "Corre electrónico fue enviado satisfactoriamente.";
           // } catch (Exception ex) {
                //output = "Error enviando correo electrónico: " + ex.Message;
            //}
                //Console.WriteLine(output);
        }
    }

}

