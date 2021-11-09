using System;

namespace MementoPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
			var calculadora = new Calculadora();
			calculadora.SetPrimeiroNumero(10);
			calculadora.SetSegundoNumero(100);

			Console.WriteLine($"1º Operação: {calculadora.GetCalculoResultado()}");

			ICaretaker memento = calculadora.BackupUltimoCalculo();

			calculadora.SetPrimeiroNumero(17);
			calculadora.SetSegundoNumero(-290);

			Console.WriteLine($"2º Operação:{calculadora.GetCalculoResultado()}");

			calculadora.RestauraUltimoCalculo(memento);

			Console.WriteLine($"Restaura a primeira operação: {calculadora.GetCalculoResultado()}");
		}
    }
}
