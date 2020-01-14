using System;
class SacadoEnderecoValidation : IValidation{
    private string logradouro;

    private int numero;
    
    private string bairro;
    
    private string localidade;
    
    //private UnidadeFederativa uf;
    
    private string cep;

    public SacadoEnderecoValidation(SacadoEndereco sacadoEndereco)
    {
        this.logradouro = sacadoEndereco.logradouro;
        this.numero = sacadoEndereco.numero;
        this.bairro = sacadoEndereco.bairro;
        this.localidade = sacadoEndereco.localidade;
        //this.uf = sacadoEndereco.uf;
        this.cep = sacadoEndereco.cep;

    }

    public void execute(){
        validaLogradouro();
        validaNumero();
        validaBairro();
        validaLocalidade();
        validaCep();
    }

    private void validaLogradouro(){
        if(this.logradouro.Trim() == "" || this.logradouro == null){
            throw new ArgumentNullException("O campo logradouro requer um valor.");
        }
    }

    private void validaNumero(){
        if(this.numero < 1){
            throw new ArgumentException("O campo numero requer um valor válido.");
        }
    }

    private void validaBairro(){
        if(this.bairro.Trim() == "" || this.bairro == null){
            throw new ArgumentNullException("O campo bairro requer um valor.");
        }
    }

    private void validaLocalidade(){
        if(this.localidade.Trim() == "" || this.localidade == null){
            throw new ArgumentNullException("O campo localidade (Cidade) requer um valor.");
        }
    }

    private void validaCep(){
        if(this.cep.Trim() == "" || this.cep == null){
            throw new ArgumentNullException("O campo cep requer um número de CEP válido.");
        }
    }












}