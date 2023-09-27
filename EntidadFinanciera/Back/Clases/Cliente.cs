using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string InformacionCliente
        {
            get { return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, DNI: {Dni}"; }
        }

        public virtual ICollection<CuentaBancaria> CuentasBancarias { get; set; }  //crea una relación entre Cliente y CuentaBancaria 

    }
}
