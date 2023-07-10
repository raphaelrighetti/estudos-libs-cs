namespace ByteBankModelos.Modelos;

/// <summary>
/// Classe que representa um cliente titular de uma conta no sistema.
/// </summary>
public class Cliente
{
    /// <summary>
    /// Construtor padrão da classe Cliente.
    /// </summary>
    /// <param name="nome">Nome do cliente (string)</param>
    /// <param name="cpf">CPF do cliente (string)</param>
    /// <param name="salario">Salário do cliente (double)</param>
    public Cliente(string nome, string cpf, double salario)
    {
        Nome = nome;
        CPF = cpf;
        Salario = salario;
    }

    /// <summary>
    /// Propriedade do nome do cliente.
    /// </summary>
    public string Nome { get; set; }
    /// <summary>
    /// Propriedade do CPF do cliente.
    /// </summary>
    public string CPF { get; set; }
    /// <summary>
    /// Propriedade do salário do cliente.
    /// </summary>
    public double Salario { get; set; }
}
