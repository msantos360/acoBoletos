
using System;

class Banco {

    public Controle controle { get; }

    public Servico servico { get; }

    public Banco(Controle controle, Servico servico){
        this.controle = controle;
        this.servico = servico;
    }
}