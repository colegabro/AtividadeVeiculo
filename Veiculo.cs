public class Veiculo
{
    private string _niv;
    public string modelo;
    public string placa;

    public void SetNiv(string niv)
    {
        
            if (niv.Length == 17)
            {
                _niv = niv;
            }else
            {
                throw new Exception("O NIV deve conter 17 caracteres");
            }
        
    }

    public string getNiv()
    {
        return _niv;
    }
}

public class Cliente
{
    public string _nome;
    private string _cpf;
    public string _sexo;
    public DateOnly _datanascimento;

    public void setCpf(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");        

        if (cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
             throw new Exception("O CPF deve conter 11 caracteres!");
        }
    }

    public string getCpf()
    {
        return _cpf;
    }
}

