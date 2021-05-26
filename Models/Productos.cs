using System;
using System.ComponentModel.DataAnnotations;
namespace Practica03.Models
{
    public class Productos
    {
      public int id { get; set; }


        public string nombre{ get; set; }
      

        public string url_producto { get; set; }
        

        public string descripcion { get; set; }

        public double precio { get; set; }
        
      
        public int celular { get; set; }
 

        public string lugarcompraproducto { get; set; }
        
        public string usuario { get; set; }
        public DateTime addDate { get; set; }
    }
    

}
