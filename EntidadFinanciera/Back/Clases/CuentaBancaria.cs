using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        [Key]
        public int Id { get; set; }

        public string NumeroCuenta { get; set; }

        public decimal Saldo { get; set; }

        public TipoCuenta Tipo { get; set; }

        public int ClienteId { get; set; } //foreign key, esta propiedad almacena el ID del cliente que es propietario de la cuenta bancaria.
        [ForeignKey("ClienteId")]

        public virtual Cliente Propietario { get; set; } //propiedad de navegación que permite acceder al objeto Cliente que es el propietario de la cuenta bancaria. Cuando se recupera una instancia de CuentaBancaria de la base de datos, esta propiedad puede utilizarse para acceder al cliente propietario de esa cuenta bancaria
    }
}
