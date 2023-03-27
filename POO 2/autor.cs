using System;

public class Autor
{

    private String nome;
    private String abreviatura;
    private List<Contato> contatos; 
    
    public Autor(String nome, String abreviatura){ //construtor
        this.nome = nome;
        this.abreviatura = abreviatura;
        contatos = new List<Contato>();
        
    }
    
    public void adicionarContato(String tipo, String contato){
        contatos.Add(new contatos(tipo, contato));
    }
    
    public void removerContato(String tipo, String contato){
        contatos.Remove(contatos.Find(contato1 => contato1.tipo == tipo && contato1.contato == contato));
    }
    
    public class Contato // composição entre autor e contato
    {
        private String tipo;
        private String contato;
       
        
        
        public Contato(String tipo, String contato){
            this.contato = contato;
            this.tipo = tipo;
            
        }
    }
}