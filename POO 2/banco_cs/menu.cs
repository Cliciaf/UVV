using System;

class Menu{

    public Menu(){
        
    }
    public void Display(){
        int select;
        int iniciar=0;
        Conta conta = new Conta();
        Console.WriteLine("Bem vindo ao menu do banco!\n");
        
        Console.WriteLine("Dê um nome para sua conta:\n");
        conta.Nome = Console.ReadLine();
        Console.Clear();
        while(iniciar == 0){
            do{
            Console.WriteLine("Escolha um dos números abaixo, caso escolha um diferente o menu reiniciará.\n");
            Console.WriteLine(" 1 - Depositar\n 2 - Sacar \n 3 - Extrato \n 0 - Sair");
            select = Convert.ToInt16(Console.ReadLine());    
            Console.Clear();
            }while(select < 0 &&  select > 3);
            
            if(select == 0)
            {
                iniciar =1;
            }
            
            double value;
            
            switch(select){
                case 0:
                    Console.WriteLine("Saindo...\n");
                    break;
                case 1: 
                    Console.WriteLine("Entre com o valor do Deposito\n");
                    value = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    conta.Depositar(value);
                    Console.WriteLine($"Deposito de R${value} feito com sucesso!\n");
                    break;
                case 2: 
                    Console.WriteLine("Entre com o valor do Saque\n");
                    value = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    conta.Sacar(value);
                    break;
                case 3: 
                    conta.Extrato();
                    break;
            }
            
        }
    }
    
    
}