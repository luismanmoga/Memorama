//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PuntuacionSet
    {
        public int Id { get; set; }
        public string Puntos { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Jugador_Id { get; set; }
    
        public virtual JugadorSet JugadorSet { get; set; }
    }
}