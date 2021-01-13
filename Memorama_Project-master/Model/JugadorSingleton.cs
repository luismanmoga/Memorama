using Memorama.DataAccessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.Model {
    
    class JugadorSingleton {

        private static JugadorSingleton instancia = null;

        private String username;
        private String correo;
        private String contrasenia;

        private JugadorSingleton(Jugador jugador) {
            this.username = jugador.Username;
            this.correo = jugador.Correo;
            this.contrasenia = jugador.Contrasenia;
        }

        public string Username { get => username; set => username = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }

        public static JugadorSingleton GetJugador(Jugador jugador) {
            if (instancia == null) {
                instancia = new JugadorSingleton(jugador);
            } 
            return instancia;
        }

        
        public static JugadorSingleton GetJugador() {
            return instancia;
        }

    }
}
