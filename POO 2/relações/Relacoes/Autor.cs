using System;
using System.Collections.Generic;

public class Autor{

  public string nome { get; private set; }
  public string abreviatura { get; private set; }
  private List<Contato> listContatos;


  public Autor (string nome, string abreviatura){
    this.nome = nome;
    this.abreviatura = abreviatura;
    this.listContatos = new List<Contato>();
  }

  public void adicionarContato(string tipo, string contato){
    Contato c = new Contato (tipo, nome);
    listContatos.Add(c);
    
  }

  public void removerContato(string tipo, string contato){
    Contato c = new Contato (tipo, nome);
    listContatos.Remove(c);
    
  }
  
  public void exibeContatos(){
    Console.WriteLine ("\n---------------------------"); 
    Console.WriteLine ("\n Contatos de "+ this.nome); 
    foreach(Contato c in listContatos){
      Console.WriteLine ("\n Registro: "+c.contato +" (" +c.tipo+") ");
    }
    Console.WriteLine ("\n---------------------------"); 
  }
  
}