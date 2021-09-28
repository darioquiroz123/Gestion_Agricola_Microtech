using System;
namespace GestionFinca.App.Dominio 
{
public class Inventario
    {
        public int Id {get; set;}
        public FertilizanteEnmienda fertilizanteEnmienda {get; set;}
        public Material material {get; set;}
        public AgroQuimico agroquimico {get; set;}
        public float Existencias {get; set;}
    
    }

}