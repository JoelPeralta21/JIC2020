//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciodeDatos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicamentos
    {
        public int IdMedicamento { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> Unidad { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdHospital { get; set; }
    
        public virtual Hospital Hospital { internal get; set; }
    }
}