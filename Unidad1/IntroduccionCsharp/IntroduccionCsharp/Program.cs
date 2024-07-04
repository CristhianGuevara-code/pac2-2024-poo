
using IntroduccionCsharp.Ejemplos;
using IntroduccionCsharp.Ejemplos.Encapsulamiento;
using IntroduccionCsharp.Ejemplos.Herencia;

//Empleado empleadoTemporal = new();

//empleadoTemporal.Id = 1;
//empleadoTemporal.Nombre = "Juan Perez";
//empleadoTemporal.SalarioBase = 14000;

//Console.WriteLine("Empleado Temporal");
//Console.WriteLine($@"El salario del empleado tempral 
//    es {empleadoTemporal.CalcularSalario()}");

//Console.WriteLine("Empleado a Tiempo Completo");
//EmpleadoTiempoCompleto empleadoTiempoCompleto = 
//    new("Maria Mejia", 2, 14000, 1500);

//Console.WriteLine($@"El salario del empleado tiempo completo 
//    es {empleadoTiempoCompleto.CalcularSalario()}");

//Console.WriteLine("Empleado por hora");
//EmpleadoPorHora empleadoPorHora = new("Mario Cruz", 3, 0, 56, 300);
//Console.WriteLine($"El salario del empleado por hora es: {empleadoPorHora.CalcularSalario()}");

CuentaBancaria cuentaBancariaJuanPerez = new(1000);

Console.WriteLine("Saldo Inicial" + cuentaBancariaJuanPerez.ObtenerSaldo());
cuentaBancariaJuanPerez.Depositar(100);
Console.WriteLine("Deposito de 100: " + cuentaBancariaJuanPerez.ObtenerSaldo());
cuentaBancariaJuanPerez.Retirar(500);
Console.WriteLine("Retiro de 500: " + cuentaBancariaJuanPerez.ObtenerSaldo());
cuentaBancariaJuanPerez.ObtenerSaldo();
Console.WriteLine("Saldo Final" + cuentaBancariaJuanPerez.ObtenerSaldo());
