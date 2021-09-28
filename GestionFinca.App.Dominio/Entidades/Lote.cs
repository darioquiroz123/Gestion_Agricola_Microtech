using System;
namespace GestionFinca.App.Dominio 
{
public class Lote 
    {
        public int Id {get; set;}
        public int Numero {get; set;}
        public int CantidadPlantas {get; set;}
        public string TipoCultivo {get; set;}
        public string Estado {get; set;}
        public Transaccion transaccion {get; set;}

    }

}