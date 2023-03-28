using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    List<Professor> listProf = new List<Professor>();

    Professor p1 = new Professor();
    Professor p2 = new Professor();

    p1.nome = "Jão";
    p2.nome = "José";

    listProf.Add(p1);
    listProf.Add(p2);
    
    Aluno aluno = new Aluno(listProf);
    aluno.nome = "Cassio";

    
    Console.WriteLine ("Hello World");
  }
}