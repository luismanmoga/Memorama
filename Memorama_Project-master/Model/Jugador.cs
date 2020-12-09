using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.Model {
    
    class Jugador {
        
        private static Jugador instancia;

        private Jugador() {

        }

        public static Jugador GetJugador() {
            if (instancia == null) {
                instancia = new Jugador();
            } 
            return instancia;
        }


    }
}
