using System;
class Cedente {
    
    public string nome { get; } //Nome da Empresa

    public string cnpj { get; }

    public Inscricao incricao { get; }

    public ContaCorrente contaCorrente { get; }

    public string cnab { get; } //Uso Exclusivo da FEBRABAN/CNAB

    public Cedente(string nome,
                   string cnpj,
                   Inscricao inscricao,
                   ContaCorrente contaCorrente,
                   string cnab
                   )
    {
        this.nome = nome;
        this.cnpj = cnpj;
        this.incricao = inscricao;
        this.contaCorrente = contaCorrente;
        this.cnab = cnab;

        new CedenteValidation(this);
    }



}