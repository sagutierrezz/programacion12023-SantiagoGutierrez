using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        [Key]
        public int IdCuenta { get; set; }

        public int NumeroCuenta { get; set; }

        public decimal Saldo { get; set; }

        public TipoCuenta TipoCuentaBancaria { get; set; }

        public enum TipoCuenta
        {
            CajaAhorro,
            CuentaCorriente
        }


        public int ClienteId { get; set; } //foreign key, esta propiedad almacena el ID del cliente que es propietario de la cuenta bancaria.
        [ForeignKey("ClienteId")]



        public string InformacionCuentaBancaria
        {
            get { return $"ID: {IdCuenta}, Numero de cuenta: {NumeroCuenta}, Saldo: {Saldo}, Tipo: {TipoCuentaBancaria}"; }
        }
    }
}
