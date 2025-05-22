using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.Backend.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!; // el copilador no marque error con el string 

        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]  // el atributo columna con la cantidad de caracteres y decimales
        [DisplayFormat(DataFormatString = "{0:c2}")] // atributo para ver el precio

        public decimal Precio { get; set; }

        public int Stock {get; set; }

    }

}
