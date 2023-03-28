using System;

class Program {
  public static void Main (string[] args) {

    Editora editoraA = new Editora("Alpha", "a@a.com");
    Editora editoraB = new Editora("Betha", "b@b.com");

    Livro livroA = new Livro("Livro A", 2023,5,5,200,editoraA );
    Livro livroB = new Livro("Livro B", 2021,2,4,150,editoraB );

    Autor autorA = new Autor ("Autor A", "AA");
    Autor autorB = new Autor ("Autor B", "BB");

    livroA.adicionaAutor(autorA);
    livroA.adicionaAutor(autorB);
    livroB.adicionaAutor(autorA);

    livroA.exibeAutor();

    autorA.adicionarContato("123123123", "whatsapp");
    autorA.adicionarContato("123123123", "residencial");

    autorA.exibeContatos();




    
  }
}