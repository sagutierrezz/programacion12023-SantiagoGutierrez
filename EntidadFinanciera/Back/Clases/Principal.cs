using Back.ConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public void AgregarCliente(Cliente cliente)
        {
            
            context.Clientes.Add(cliente);
            context.SaveChanges();
            
        }
        public void EliminarCliente(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            
            context.CuentasBancarias.Add(cuenta);
            context.SaveChanges();
            
        }

        public void EmitirTarjetaCredito(TarjetaCredito tarjeta)
        {
            context.TarjetasCredito.Add(tarjeta);
            context.SaveChanges();

        }


        public void PausarTarjetaCredito(int tarjetaId)
        {
            using (var context = new ApplicationDbContext())
            {
                // Busca la TC por el ID
                var tarjeta = context.TarjetasCredito.Find(tarjetaId);

                // If para ver si la tarjeta existe
                if (tarjeta != null)
                {
                    // Realizar la pausa o "Baja lógica" de la tarjeta
                    tarjeta.Estado = EstadoTarjeta.Pausada;

                    context.SaveChanges();
                }
            }
        }
        public void RealizarDeposito(int cuentaBancariaId, decimal montoDeposito)
        {
            using (var context = new ApplicationDbContext())
            {
                // Consulta LINQ (ver si la condicion pasada es correcta y si ta bien, o adaptar una condicion segun la db)
                var cuentaBancaria = context.CuentasBancarias.FirstOrDefault(cb => cb.Id == cuentaBancariaId);

                if (cuentaBancaria != null)
                {
                    // Al monto actual(saldo) se le suma el monto del deposito
                    cuentaBancaria.Saldo += montoDeposito;
                    context.SaveChanges();
                }
            }
        }
        public void RealizarExtraccion(int cuentaBancariaId, decimal montoExtraccion)
        {
            using (var context = new ApplicationDbContext())
            {
                var cuentaBancaria = context.CuentasBancarias.FirstOrDefault(cb => cb.Id == cuentaBancariaId);

                if (cuentaBancaria != null)
                {
                    // Si el saldo es mayor a la extraccion
                    if (cuentaBancaria.Saldo >= montoExtraccion)
                    {
                        //Realiza la extraccion restando el monto de la extraccion al saldo
                        cuentaBancaria.Saldo -= montoExtraccion;
                        context.SaveChanges();
                    }
                    else
                    {
                        // En caso de que no haya saldo para la extraccion
                        Console.WriteLine("No tenes saldo, seco");
                    }
                }
            }
        }

        public void RealizarTransferencia(int cuenaOrigenId, int cuentaDestinoId, decimal montoTransferencia)
        {
            using (var context = new ApplicationDbContext())
            {
                cuentaOrigenid.Saldo -= montoTransferencia;
                
                cuentaDestinoId.Saldo += montoTransferencia;
                context.SaveChanges();
            }
        }

        public void PagarTarjetaCredito(int tarjetaId, decimal montoPago)
        {
            using (var context = new ApplicationDbContext())
            {
                // Buscar la tarjeta de crédito por su ID
                var tarjetaCredito = context.TarjetasCredito.FirstOrDefault(tc => tc.Id == tarjetaId);

                if (tarjetaCredito != null)
                {
                    // Realizar el pago restando el monto del saldo disponible de la tarjeta de crédito
                    tarjetaCredito.SaldoDisponible -= montoPago;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La tarjeta de crédito no existe.");
                }
            }
        }

        public void GenerarResumenTarjeta(int tarjetaId)
        {

        }

    }
}