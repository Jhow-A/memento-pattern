namespace MementoPattern
{
    public interface ICalculadora
    {
        // Create Memento
        ICaretaker BackupUltimoCalculo();

        // Set Memento
        void RestauraUltimoCalculo(ICaretaker memento);

        // Originator
        int GetCalculoResultado();
        void SetPrimeiroNumero(int num1);
        void SetSegundoNumero(int num2);
    }
}
