using System;

class SacadoEndereco {
    
    public string logradouro { get; }

    public int numero { get; }

    public string bairro { get; }

    public string localidade { get; }

    public UnidadeFederativa uf { get; }

    public string cep { get; }

    public SacadoEndereco(string logradouro,
                          int numero,
                          string bairro,
                          string localidade,
                          UnidadeFederativa uf,
                          string cep)
    {
        this.logradouro = logradouro;
        this.numero = numero;
        this.bairro = bairro;
        this.localidade = localidade;
        this.uf = uf;
        this.cep = cep;

        new SacadoEnderecoValidation(this).execute();
    }



}