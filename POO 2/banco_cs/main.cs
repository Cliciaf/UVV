using System;
class Banco {
    
    static void Main() {
        Conta Conta1 = new Conta();
        Conta1.Saldo = 10;
        Console.WriteLine(Conta1.Saldo);
        Conta1.Sacar(3);
        Console.WriteLine(Conta1.Saldo);
    }
}