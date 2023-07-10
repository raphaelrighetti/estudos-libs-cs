using ByteBankModelos.Exceptions;

namespace ByteBankModelos.Modelos;

/// <summary>
/// Classe que representa uma conta corrente no sistema.
/// </summary>
public class ContaCorrente
{
    /// <summary>
    /// Construtor padrão da classe ContaCorrente.
    /// </summary>
    /// <param name="numero">Número da conta (int)</param>
    /// <param name="agencia">Número da agência da conta (int)</param>
    /// <param name="titular">Cliente titular da conta (cliente)</param>
    public ContaCorrente(int numero, int agencia, Cliente titular)
    {
        Numero = numero;
        Agencia = agencia;
        Titular = titular;
    }

    /// <summary>
    /// Propriedade do número da conta.
    /// </summary>
    public int Numero { get; set; }
    /// <summary>
    /// Propriedade do número da agência da conta.
    /// </summary>
    public int Agencia { get; set; }
    /// <summary>
    /// Propriedade do saldo da conta.
    /// </summary>
    public double Saldo { get; private set; }
    /// <summary>
    /// Propriedade do cliente titular da conta.
    /// </summary>
    public Cliente Titular { get; set; }

    /// <summary>
    /// Método responsável por fazer o depósito de um valor no saldo da conta.
    /// </summary>
    /// <param name="valor">Valor a ser depositado (double)</param>
    /// <exception cref="OperacaoInvalidaException"></exception>
    public void Depositar(double valor)
    {
        if (valor < 0)
        {
            throw new OperacaoInvalidaException("O valor de depósito deve ser maior do que zero!");
        }

        Saldo += valor;
    }

    /// <summary>
    /// Método responsável por fazer o saque de um valor no saldo da conta.
    /// </summary>
    /// <param name="valor">Valor a ser sacado (double)</param>
    /// <exception cref="OperacaoInvalidaException"></exception>
    public void Sacar(double valor)
    {
        if (valor < 0)
        {
            throw new OperacaoInvalidaException("O valor de saque deve ser maior do que zero!");
        }
        else if (Saldo - valor < 0)
        {
            throw new OperacaoInvalidaException("Saldo insuficiente!");
        }

        Saldo -= valor;
    }
}