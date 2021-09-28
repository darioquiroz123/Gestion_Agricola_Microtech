using System;
namespace GestionFinca.App.Dominio
{
    public class Finca 
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Ubicacion {get; set;}
        public int Lotes {get; set;}
        private int CantProdSembrados {get; set;}
        public Lote lote {get; set;}
        public Inventario inventario {get; set;}

    }
}