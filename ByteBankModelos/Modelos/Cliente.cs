namespace ByteBankModelos.Modelos;

public class Cliente
{
    public Cliente(string nome, string cpf, double salario)
    {
        Nome = nome;
        CPF = cpf;
        Salario = salario;
    }

    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
}
