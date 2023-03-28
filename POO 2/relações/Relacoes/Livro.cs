using System;
using System.Collections.Generic;

public class Livro{

  private string titulo;
  private int anoPublicacao;
  private float preco;
  private int nota;
  private int quantidade;
  private List<Autor> autores;
  private Editora editora;

  public Livro (string titulo, int anoPublicacao,float preco,int nota, int quantidade, Editora editora){
    this.titulo = titulo;
    this.anoPublicacao = anoPublicacao;
    this.preco = preco;
    this.nota = nota;
    this.quantidade = quantidade;
    this.autores = new List<Autor>();
    this.editora = editora;
  }

  public void adicionaAutor(Autor a){
    autores.Add(a);
  }

  public void exibeAutor(){
    Console.WriteLine ("\n---------------------------"); 
    Console.WriteLine ("\n Autores de "+ this.titulo); 
    foreach(Autor a in autores){
      Console.WriteLine ("\n Autor: "+a.nome +" (" +a.nome+") ");
    }
    Console.WriteLine ("\n---------------------------"); 
  }
  
}