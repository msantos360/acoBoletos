using System;
using Caelum.Stella.CSharp.Validation;
class CedenteValidation : IValidation {
    private string nome;

    private string cnpj;

    private string cnab;

    public CedenteValidation(Cedente cedente){
        this.nome = cedente.nome;
        this.cnpj = cedente.cnpj;
        this.cnab = cedente.cnab;
    }

    public void execute()
    {
        validaNome();
        validaCnpj();
        validaCnab();
    }

    public void validaNome(){
        if(this.nome.Trim() == "" || this.nome == null){
            throw new ArgumentNullException("O campo nome é requerido.");
        
        } else if(this.nome.Length > 30){
            throw new ArgumentException("O campo nome excedeu o limite de 30 caracteres.");
        }
    }

    public void validaCnpj(){
        if(this.cnpj.Trim() == "" || this.cnpj == null){
            throw new ArgumentNullException("O campo identy (CPF/CNPJ) requer um número válido.");
        } 

        new CNPJValidator().AssertValid(this.cnpj);
    }

    public void validaCnab(){
        if(this.cnab.Length > 137){
            throw new ArgumentException("O campo CNAB excedeu o limite de 137 caracteres.");
        }
    }

    
}