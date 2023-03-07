using System;
using System.Collections.Generic;

class Conta{
    private string nome;
    private string cpf;
    private double saldo;
    List<(string, double)> transacoes = new List<(string, double)>();
     
    public Conta(){
        Nome = "";
        Cpf = "";
        Saldo = 0;
    }    
    public string Nome 
    { 
        get {return nome;}
        set {nome = value;}
    }

    public string Cpf 
    { 
        get {return cpf;}
        set {cpf = value;}
    }

    public double Saldo 
    { 
        get {return saldo;}
        set {saldo = value;}
        
    }

    public void Sacar(double valor) {
        if(Saldo < valor){
            Console.WriteLine("Você não tem saldo para realizar o saque!");    
        }else{
            saldo -= valor;
            transacoes.Add(("Saque", valor));
            Console.WriteLine($"Saque de R${valor} feito com sucesso!\n");
        }
    }

    public void Depositar(double valor) {
        saldo += valor;
        transacoes.Add(("Depósito", valor));
    }
    
     public void Extrato() {
        Console.WriteLine("Transações realizadas:");
        foreach (var transacao in transacoes) {
            Console.WriteLine($"{transacao.Item1}: R${transacao.Item2}");
        }
        Console.WriteLine($"Saldo atual: R${saldo}");
    }
}
