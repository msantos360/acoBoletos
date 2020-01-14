using System;
using Caelum.Stella.CSharp.Validation;

class SacadoValidation {
    private string nome;

    private string identy;

    public SacadoValidation(Sacado sacado){
        this.nome = sacado.nome;
        this.identy = sacado.identy;

        validaNome();
        validaIdenty();
    }

    private void validaNome(){
        if(this.nome.Trim() == "" || this.nome == null){
            throw new ArgumentNullException("O campo nome requer um valor.");
        }
    }

    private void validaIdenty()
    {
        if(this.identy.Trim() == "" || this.identy == null){
            throw new ArgumentNullException("O campo identy (CPF/CNPJ) requer um número válido.");
        
        } else if(this.identy.Length < 12){
            new CPFValidator().AssertValid(this.identy);
        
        } else{
            new CNPJValidator().AssertValid(this.identy);
        }
    }

    
}