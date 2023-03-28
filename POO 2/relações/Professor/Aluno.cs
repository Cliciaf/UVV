using System.Collections;
using System.Collections.Generic;

public class Aluno{

  public string nome;

  public List<Professor> professores;

  public Aluno(List<Professor> p){
    professores = p;
  }
  
}