using Back.ConexionBD;
using Back.Migrations;
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

        public List<Cliente> DevolverListaClientes()
        {
            return context.Clientes.ToList();
        }
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

        public List<CuentaBancaria> DevolverListaCuentaBancaria()
        {
            return context.CuentasBancarias.ToList();
        }
        public void CrearCuentaBancaria(CuentaBancaria cuenta)
        {
            
            context.CuentasBancarias.Add(cuenta);
            context.SaveChanges();
            
        }

        public void EliminarCuentaBancaria(CuentaBancaria cuenta)
        {
            context.CuentasBancarias.Remove(cuenta);
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
                var cuentaBancaria = context.CuentasBancarias.FirstOrDefault(cb => cb.IdCuenta == cuentaBancariaId);

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
                var cuentaBancaria = context.CuentasBancarias.FirstOrDefault(cb => cb.IdCuenta == cuentaBancariaId);

                if (cuentaBancaria != null)
                {
                    // Si el saldo es mayor a la extraccion pasa a realizar la extracción
                    if (cuentaBancaria.Saldo >= montoExtraccion)
                    {
                        //Realiza la extraccion restando el monto de la extraccion al saldo
                        cuentaBancaria.Saldo -= montoExtraccion;
                        context.SaveChanges();
                    }
                    else
                    {
                        // En caso de que no haya saldo para la extraccion
                        throw new InvalidOperationException("Saldo insuficiente en la cuenta de origen para la extracción.");
                    }
                }
            }
        }

        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, decimal montoTransferencia)
        {
            using (var context = new ApplicationDbContext())
            {
                var cuentaOrigen = context.CuentasBancarias.FirstOrDefault(cb => cb.IdCuenta == cuentaOrigenId);
                var cuentaDestino = context.CuentasBancarias.FirstOrDefault(cb => cb.IdCuenta == cuentaDestinoId);

                if (cuentaOrigen != null && cuentaDestino != null) //Verifica si las cuentas existen y si no son null
                {
                    // Verifica si el saldo de la cuenta de origen es suficiente para la transferencia
                    if (cuentaOrigen.Saldo >= montoTransferencia)
                    {
                        // Realizar la transferencia restando el monto de la cuenta de origen
                        cuentaOrigen.Saldo -= montoTransferencia;
                        // Sumar el monto a la cuenta de destino
                        cuentaDestino.Saldo += montoTransferencia;

                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException("Saldo insuficiente en la cuenta de origen para la transferencia.");
                    }
                }
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
                    //Si es null, tira el mensaje de la excepcion
                    throw new InvalidOperationException("La tarjeta de crédito no existe.");
                }
            }
        }

        public void GenerarResumenTarjeta(int tarjetaId)
        {

        }

    }
}