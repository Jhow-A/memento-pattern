namespace MementoPattern
{
    // Representa o estado armazenado do objeto Originator
    public class Memento : ICaretaker, IOriginator
    {
        private readonly int primeiroNumero;
        private readonly int segundoNumero;

        public Memento(int numero1, int numero2)
        {
            primeiroNumero = numero1;
            segundoNumero = numero2;
        }

        public int GetPrimeiroNumero() => primeiroNumero;
        
        public int GetSegundoNumero() => segundoNumero;
    }
}
