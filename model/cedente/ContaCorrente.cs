using System;
public class ContaCorrente {

    public int agencia { get; } //Agência Mantenedora da Conta

    public string dgAgencia { get; } //Dígito Verificador da Agência

    public int conta { get; } //Número da Conta Corrente

    public string dgConta { get; }  //Dígito Verificador da Conta

    public string dgAgConta { get; } //Dígito Verificador da Ag/Conta

    public ContaCorrente(int agencia,
                         string dgAgencia,
                         int conta,
                         string dgConta,
                         string dgAgConta
                        )
    {
        this.agencia = agencia;
        this.dgAgencia = dgAgencia;
        this.conta = conta;
        this.dgConta = dgConta;
        this.dgAgConta = dgAgConta;

        new ContaCorrenteValidation(this).execute();
    }



}