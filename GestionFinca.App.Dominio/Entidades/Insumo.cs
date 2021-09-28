using System;
namespace GestionFinca.App.Dominio
{
    public class Insumo
    {
        public int Id {get; set;}
        public DateTime FechaCompra {get; set;}
        public string NombreProducto {get; set;}
        public float CantidadInreso {get; set;}
        private float CantidadSalida {get; set;}
        public string UnidadMedida {get; set;}
        public float Precio {get; set;}
        public string Responsable {get; set;}
        
    }
}