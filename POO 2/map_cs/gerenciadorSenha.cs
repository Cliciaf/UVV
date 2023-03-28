using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
      Stack<Pessoa> filapessoas = new Stack<Pessoa>();

    Console.WriteLine("----------------------------------");
    filapessoas.Enqueue(new Pessoa(false));
    filapessoas.Enqueue(new Pessoa(false));
    filapessoas.Enqueue(new Pessoa(true));
    filapessoas.Enqueue(new Pessoa(true));
    filapessoas.Enqueue(new Pessoa(false));
    Console.WriteLine("Pessoa inserida na lista\n");
    Console.WriteLine("----------------------------------");
    
    foreach (Pessoa s in filapessoas)
    {
      Console.WriteLine("Pessoa: "+ s.nome);
      Console.WriteLine("Data: "+ s.cpf);
    }
    
    Console.WriteLine("----------------------------------");
    Pessoa x;
    x = filapessoas.Pop();

    Console.WriteLine("Removeu: "+ x.nome);
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Pessoas inseridas: \n");
    
    foreach (Pessoa s in filapessoas)
    {
      Console.WriteLine("Pessoa: "+ s.nome);
      Console.WriteLine("Cpf: "+ s.cpf);
    }
  }
}