public class Contato{

  public string tipo { get; private set; }
  public string contato { get; private set; }

  public Contato (string tipo, string contato){
    this.tipo = tipo;
    this.contato = contato;
  }

  
}