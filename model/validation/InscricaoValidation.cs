using System;

class InscricaoValidation : IValidation {
    private int tipo;

    private int numero;
    
    private string convenio;

    public InscricaoValidation(Inscricao inscricao){
        this.tipo = inscricao.tipo;
        this.numero = inscricao.numero;
        this.convenio = inscricao.convenio;
    }

    public void execute()
    {
        validaTipo();
        validaNumero();
        validaConvenio();
    }

    public void validaTipo(){
        if(this.tipo < 1){
            throw new ArgumentException("O campo tipo requer um valor válido.");
        
        } else if(this.tipo.ToString().Length != 1){
            throw new ArgumentException("O campo tipo excedeu o limite de 1 caracter.");
        }
    }

    public void validaNumero(){
        if(this.numero < 1){
            throw new ArgumentException("O campo número de inscrição requer um valor válido.");
        
        } else if(this.numero.ToString().Length > 15){
            throw new ArgumentException("O campo número de inscrição excedeu o limite de 15 caracteres.");
        }
    }

    public void validaConvenio(){
        if(this.convenio.Trim() == "" || this.convenio == null){
            throw new ArgumentNullException("O campo convenio é obrigatório e requer um valor.");
        
        } else if(this.convenio.Length > 20){
            throw new ArgumentException("O campo convenio excedeu o limite de 20 caracteres.");
        }
    }







}