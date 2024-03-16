// See https://aka.ms/new-console-template for more information
using Lab01;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Bienvenido al Cajero Automatico Sanchez, introdusca sus datos: ");
Console.WriteLine("----------------------------------------");

Console.WriteLine("Número de cuenta: ");

CuentaBancaria cuenta = new CuentaBancaria();
CuentaBancaria.CajeroAutomatico cajero = new CuentaBancaria.CajeroAutomatico();

cuenta.NumeroCuenta = Console.ReadLine();

Console.WriteLine("Nombre del titular: ");

cuenta.TitularCuenta = Console.ReadLine();

Console.WriteLine("PIN");

cuenta.PIN = Console.ReadLine();

Console.WriteLine("----------------------------------------");
Console.WriteLine("Los datos son correctos");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Su número de cuenta es: " + cuenta.NumeroCuenta);
Console.WriteLine("Su nombre es: " + cuenta.TitularCuenta);
Console.WriteLine("Su PIN es: " + cuenta.PIN);
Console.WriteLine("----------------------------------------");
int opcion = 0;

while (opcion != 5)
{
    Console.WriteLine("Desee la acción que requiere realizar: ");
    Console.WriteLine("(1) -> Consultar saldo");
    Console.WriteLine("(2) -> Depositar");
    Console.WriteLine("(3) -> Retirar");
    Console.WriteLine("(4) -> Cambiar PIN");
    Console.WriteLine("(5) -> Salir");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        cajero.ConsultarSaldo();

    }else if (opcion == 2)
    {
        cajero.DepositarFondo();
    }
    else if (opcion == 3)
    {
        cajero.RetirarEfectivo();
    }
    else if (opcion == 4)
    {
        cajero.CambiarPIN();
    }

}
    





