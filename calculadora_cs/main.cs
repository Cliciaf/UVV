/******************************************************************************

Classe que vai receber dois parametros e retorna um resultado.
Calculadora
Cada operação vai ser um metodo na calculadora.
A classe calculadora só Main.
Fazer um menu onde o usuario escolhe qual metodo vai ser chamado.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    double resultado = 0.0;
    
    string select = "";
    
    while(select!="5") {
        
        Console.WriteLine("Bem vindo!\n Escolha o tipo de calculo desejado ou mete o pé:\n");
        Console.WriteLine(" 1 - Somar\n 2 - Subtrair\n 3 - Multiplicar\n 4 - Dividir.\n 5 - Sair");
        select = Console.ReadLine();
        
        Console.WriteLine("Agora insira o primeiro valor");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Agora insira o segundo valor");
        double y = Convert.ToDouble(Console.ReadLine());
        
        Calculadora calculadora = new Calculadora();
        
        switch(select)
        {
            case "1":
                resultado = calculadora.somar(x,y);
                break;
            case "2":
                resultado = calculadora.subtrair(x,y);
                 break;
            case "3":
                resultado = calculadora.multi(x,y);
                 break;
            case "4":
                resultado = calculadora.dividir(x,y);
                 break;
            case "5":
                Console.WriteLine("Saindo...");
                continue;
            default:
                Console.WriteLine("Numero errado, digite novamente!");
                break;
        }
            Console.WriteLine("Resultado:" + resultado);

    }
    
  }
}