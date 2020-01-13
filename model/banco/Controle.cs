using System;
public class Controle {

    public int banco { get; } //Código do Banco na Compensação

    public int lote { get; } //Lote de Serviço

    public int registro { get; } //Tipo de Registro [defaut 1]

    public Controle(int banco,
                    int lote,
                    int registro)
    {
        this.banco = banco;
        this.lote = lote;
        this.registro = registro;
    }

}