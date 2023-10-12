using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class TarjetaCredito
    {
        [Key]
        public int Id { get; set; }

        public string NumeroTarjeta { get; set; }

        public decimal LimiteCredito { get; set; }

        public decimal SaldoDisponible { get; set; }

        public EstadoTarjeta Estado { get; set; }

        //public int ClienteId { get; set; } //foreign key, esta propiedad almacena el ID del cliente que es propietario de la cuenta bancaria.
        //[ForeignKey("ClienteId")]

    }

    public enum TipoCuenta
    {
        Corriente,
        Ahorro
    }

    public enum EstadoTarjeta
    {
        Activa,
        Pausada,
        Bloqueada
    }


}
