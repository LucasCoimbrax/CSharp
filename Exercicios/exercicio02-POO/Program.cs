
Cliente cliente = new Cliente("Lucas Coimbra", "Rua aleatoria", "123.456.789-00");
Console.WriteLine(cliente.Cpf);


public class Cliente
{
    public string Name { get; private set; } = "";
    public string Endereco { get; private set; } = "";
    private long cpf;
    public string Cpf 
    {
        get => cpf.ToString().Insert(3,".").Insert(7,".").Insert(11,"-");
        set
        {
            cpf = long.Parse(value.Replace(".", "").Replace("-", ""));
        }
    }

    public Cliente() { }

    public Cliente(string name, string endereco, string cpf)
    {
        Name = name;
        Endereco = endereco;
        Cpf = cpf;
    }
}
