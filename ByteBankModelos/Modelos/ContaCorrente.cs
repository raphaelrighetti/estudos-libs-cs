using ByteBankModelos.Exceptions;

namespace ByteBankModelos.Modelos;

public class ContaCorrente
{
    public ContaCorrente(int numero, int agencia, Cliente titular)
    {
        Numero = numero;
        Agencia = agencia;
        Titular = titular;
    }

    public int Numero { get; set; }
    public int Agencia { get; set; }
    public double Saldo { get; private set; }
    public Cliente Titular { get; set; }

    public void Depositar(double valor)
    {
        if (valor < 0)
        {
            throw new OperacaoInvalidaException("O valor de depósito deve ser maior do que zero!");
        }

        Saldo += valor;
    }

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