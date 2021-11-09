namespace MementoPattern
{
    public class Calculadora : ICalculadora
    {
        private int primeiroNumero;
        private int segundoNumero;

        public ICaretaker BackupUltimoCalculo() => new Memento(primeiroNumero, segundoNumero);

        public int GetCalculoResultado() => primeiroNumero + segundoNumero;

        public void SetPrimeiroNumero(int n1) => primeiroNumero = n1;

        public void SetSegundoNumero(int n2) => segundoNumero = n2;

        public void RestauraUltimoCalculo(ICaretaker memento)
        {
            primeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
            segundoNumero = ((IOriginator)memento).GetSegundoNumero();
        }
    }
}
