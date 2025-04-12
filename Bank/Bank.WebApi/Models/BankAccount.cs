namespace Bank.WebApi.Models
{
    /// <summary>
    /// Representa una cuenta bancaria con operaciones básicas de débito y crédito.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        /// <summary>
        /// Constructor privado para prevenir creación sin datos.
        /// </summary>
        private BankAccount() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BankAccount"/>.
        /// </summary>
        /// <param name="customerName">Nombre del cliente.</param>
        /// <param name="balance">Balance inicial.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Obtiene el nombre del cliente.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }

        /// <summary>
        /// Obtiene el balance actual de la cuenta.
        /// </summary>
        public double Balance { get { return m_balance; } }

        /// <summary>
        /// Debita una cantidad del balance de la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a debitar.</param>
        /// <exception cref="ArgumentOutOfRangeException">Si la cantidad es mayor al balance o menor que 0.</exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException(nameof(amount));
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            m_balance -= amount;
        }

        /// <summary>
        /// Acredita una cantidad al balance de la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a acreditar.</param>
        /// <exception cref="ArgumentOutOfRangeException">Si la cantidad es menor que 0.</exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            m_balance += amount;
        }
    }
}
