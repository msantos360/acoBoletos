using System;

public class Servico {
    public int operacao; //Tipo de Operação [default 1]

    public int servico; //Tipo de Serviço [defaul 3]

    public string cnab; //Uso Exclusivo da FEBRABAN/CNAB 

    public  int layoutLote; //Nº da Versão do Layout do Lote [default 030]

    public Servico(int operacao,
                   int servico,
                   string cnab,
                   int layoutLote)
    {
        this.operacao = operacao;
        this.servico = servico;
        this.cnab = cnab;
        this.layoutLote = layoutLote;
    }





}