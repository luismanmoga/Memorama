using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.Model {
    
    class Jugador {
        
        private static Jugador instancia;

        private String username;
        private String correo;

        private Jugador(String username, String correo) {
            this.username = username;
            this.correo = correo;
        }

        public string Username { get => username; set => username = value; }
        public string Correo { get => correo; set => correo = value; }

        public static Jugador GetJugador() {
            if (instancia == null) {
               // instancia = new Jugador();
            } 
            return instancia;
        }


    }
}
