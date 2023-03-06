using System;

class Conta{
    
 private string nome;
 private string cpf;
 private double saldo;
// private double extrado;

public Conta(){
    cpf = "";
    nome = "";
    saldo = 0;
    
}

public string Nome   
 {  get { return nome;}
    set {nome = value;}
     
 }

 public string Cpf   
 {  get{return cpf;}
    set{cpf = value;}
     
 }

 public double Sacar(double valor){
    Saldo = Saldo - valor;
    return Saldo;
 }
 public double Saldo   
 {  get{return saldo;}
    set{saldo = value;}
     
 }
 
 //public double Extrado   
 //{get;set;}

 }