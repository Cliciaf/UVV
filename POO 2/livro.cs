using System;


public class Livro{
    
    private String titulo;
    private int anoPublicacao;
    private float preco;
    private int nota;
    private int quantidade;
    
    private List<Autor> autores;
    
    public Livro(String titulo,int anoPublicacao, float preco,int nota, int quantidade, Editora editora)
    {
        this.titulo = titulo;
        this.anoPublicacao = anoPublicacao;
        this.preco = preco;
        this.nota = nota; 
        this.quantidade = quantidade;
        autores = new List<Autor>();
    }
    
    public int atualizarNota(int novaNota)
    {
        nota = novaNota;
        return nota;
        
    }
    public void adicionarAutor(Autor autor)
    {
        autores.Add(new autores(nome, abreviatura));
        
        
    }
     public String getNome(){
        get { return titulo; }   // testar
        set { titulo = value; }
     }
     
     public String getAno(){
         return anoPublicacao;
     }
     
     public String getPreco(){
         return preco;
     }
     
     public String getNota(){
         return nota;
     }
     
     public String getQtd(){
         return quantidade;
     }
     
     public void setNome(String nome){
         titulo=nome;
     }

}