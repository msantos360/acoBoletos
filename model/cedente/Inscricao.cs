using System;
public class Inscricao {

    public int tipo { get; } //Tipo de Inscrição da Empresa

    public int numero { get; } //Número de Inscrição da Empresa

    public string convenio { get; } //Código do Convênio no Banco

    public Inscricao(int tipo, int numero, string convenio){
        this.tipo = tipo;
        this.numero = numero;
        this.convenio = convenio;
    }


}