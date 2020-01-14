using System;
using Caelum.Stella.CSharp.Validation;
class CedenteValidation : IValidation{
    private string nome;

    private string cnpj;

    public CedenteValidation(Cedente cedente){
        this.nome = cedente.nome;
        this.cnpj = cedente.cnpj;
    }

    public void execute()
    {
        validaNome();
        validaCnpj();
    }

    public void validaNome(){
        if(this.nome.Trim() == "" || this.nome == null){
            throw new ArgumentNullException("O campo nome é requerido.");
        }
    }

    public void validaCnpj(){
        if(this.cnpj.Trim() == "" || this.cnpj == null){
            throw new ArgumentNullException("O campo identy (CPF/CNPJ) requer um número válido.");
        } 

        new CNPJValidator().AssertValid(this.cnpj);
    }

    
}