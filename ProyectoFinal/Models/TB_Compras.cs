//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Compras
    {
        public int Compra_ID { get; set; }
        public string Compra_Nombre { get; set; }
        public int Compra_Precio { get; set; }
        public int Compra_IDEmpleado { get; set; }
        public int ProvID_Compra { get; set; }
    
        public virtual TB_Empleados TB_Empleados { get; set; }
        public virtual TB_Proveedores TB_Proveedores { get; set; }
    }
}
