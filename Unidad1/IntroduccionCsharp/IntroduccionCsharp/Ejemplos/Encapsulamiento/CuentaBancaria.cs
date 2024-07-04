namespace IntroduccionCsharp.Ejemplos.Encapsulamiento
{
    public class CuentaBancaria
    {
        private decimal Saldo { get; set; }

        public CuentaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad) 
        {
            if (cantidad > 0) 
            {   
                Saldo += cantidad; // Saldo = Saldo + cantidad
            }
            else 
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
        }

        public void Retirar(decimal cantidad) 
        {
            if (cantidad > 0 && cantidad <= Saldo) 
            {
                Saldo -= cantidad; // Saldo = Saldo - cantidad
            }
            else 
            {
                Console.WriteLine("Cantiad inválida para retirar.");
            }
        }

        public decimal ObtenerSaldo() 
        {

            return Saldo;
        }

    }
}
