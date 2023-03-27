using System;

public class Editora
{
    private String nome;
    private String email;
    
    public Editora(String nome, String email)
    {
        this.nome = nome;
        this.email = email;
    }    
    public string getNome   
  {
        get { return nome; }
  }
    public string getEmail   
  {
        get { return email; }
  }
}