using System;
class ContaCorrenteValidation : IValidation {
    private int agencia;
    
    private string dgAgencia;
    
    private int conta;
    
    private string dgConta;
    
    private string dgAgConta;

    public ContaCorrenteValidation(ContaCorrente contaCorrente){
        this.agencia = contaCorrente.agencia;
        this.dgAgencia = contaCorrente.dgAgencia;
        this.conta = contaCorrente.conta;
        this.dgConta = contaCorrente.dgConta;
        this.dgAgConta = contaCorrente.dgAgConta;
    }

    public void execute()
    {
        validaAgencia();
        validaDgAgencia();
        validaConta();
        validaDgConta();
        validaDgAgConta();
    }

    private void validaDgAgConta()
    {
        if(this.dgAgConta.Trim() == "" || this.dgAgConta == null){
            throw new ArgumentNullException("O campo dígito agencia/conta requer um valor válido.");
        
        } else if(this.dgAgConta.Length != 1){
            throw new ArgumentException("O campo dígito deve conter apenas 1 dígito");
        }
    }

    private void validaDgConta()
    {
        if(this.dgConta.Trim() == "" || this.dgConta == null){
            throw new ArgumentNullException("O campo dígito conta requer um valor válido.");
        
        } else if(this.dgConta.Length != 1){
            throw new ArgumentException("O campo dígito da conta deve conter apenas 1 dígito");
        }
    }

    private void validaConta()
    {
        if(this.conta < 1){
            throw new ArgumentException("O campo conta requer um número de conta válida.");
        
        } else if(this.conta.ToString().Length > 12){
            throw new ArgumentException("O campo conta excedeu o limite de 12 caracteres.");
        }

    }

    private void validaDgAgencia()
    {
        if(this.dgAgencia.Trim() == "" || this.dgAgencia == null){
            throw new ArgumentNullException("O campo dígito conta requer um valor válido.");
        
        } else if(this.dgAgencia.Length != 1){
            throw new ArgumentException("O campo dígito da agência deve conter apenas 1 dígito");
        }
    }

    private void validaAgencia()
    {
        if(this.agencia < 1){
            throw new ArgumentException("O campo agência requer um número válido.");
        
        } else if(this.agencia.ToString().Length > 5){
            throw new ArgumentException("O campo agência excedeu o limite de 5 caracteres.");
        }
    }
}