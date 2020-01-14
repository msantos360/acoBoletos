using System;

class Sacado {
    
    public string nome { get; }

    public string identy { get; } //CPF ou CNPJ

    public SacadoEndereco endereco { get; }

    public Sacado(string nome,
                  string identy,
                  SacadoEndereco endereco)
    {
        this.nome = nome;
        this.identy = identy;
        this.endereco = endereco;

        new SacadoValidation(this);
    }

}