using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Memorama.Model {
    [DataContract]
    class Jugador {

        String username;
        String correo;
        String contrasenia;
    }
}
