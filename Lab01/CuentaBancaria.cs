using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class CuentaBancaria
    {
        public string NumeroCuenta { get; set; }
        public string TitularCuenta { get; set; }
        public int Saldo { get; set; } = 1000;
        public string PIN { get; set; }
        public int Fondo { get; set; } 
        public int Retiro { get; set; }

        public string nuevopin {  get; set; }

        public class CajeroAutomatico : CuentaBancaria
        {
            public int ConsultarSaldo()
            {
                Console.WriteLine("Cuentas con un saldo de: " + Saldo);

                return Saldo;
            }

            public int DepositarFondo() {

                Console.WriteLine("¿Cuanto desea depositar?: ");

                Fondo = int.Parse(Console.ReadLine());

                Saldo = Saldo + Fondo;

                Console.WriteLine("Ahora cuentas con: " + Saldo);
                return Saldo;
            }

            public int RetirarEfectivo()
            {
                Console.WriteLine("¿Cuanto desea retirar?: ");
                Retiro = int.Parse(Console.ReadLine());

                if (Retiro > Saldo)
                {
                    Console.WriteLine("No cuentas con el saldo para hacer ese retiro. Tu saldo: ");
                    return Saldo;
                }else
                {
                    Saldo = Saldo - Retiro;
                    Console.WriteLine("Ahora cuentas con: " + Saldo);
                    return Saldo;
                }
                
            }

            public string CambiarPIN()
            {
                Console.WriteLine("Introdusca el nuevo PIN: ");
                nuevopin = Console.ReadLine();
                if (nuevopin == PIN)
                {
                    Console.WriteLine("Debe introducir un PIN diferente al anterior.");
                }else if (nuevopin != PIN) {
                    PIN = nuevopin;
                    Console.WriteLine("Cambio exitoso, su nuevo PIN es: " + PIN);
                }
                return PIN;
            }
        }

    }
}
