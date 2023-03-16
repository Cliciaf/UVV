using System;
using System.Collections;

class GerenciadorDeSenhas
{   
    static Queue filaDeSenhas = new Queue();
    
    public GerenciadorDeSenhas(){
        

    while (true)
    {
     // exibe as opções do menu
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Pegar senha");
    Console.WriteLine("2. Chamar senha");
    Console.WriteLine("3. Sair");

    // lê a opção escolhida pelo usuário
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
        {
        // gera uma nova senha
        int novaSenha = filaDeSenhas.Count + 1;
        // insere a nova senha na fila
        filaDeSenhas.Enqueue(novaSenha);

        Console.WriteLine($"Senha {novaSenha} foi gerada com sucesso!");
        }
        else if (opcao == 2)
        {
            if (filaDeSenhas.Count == 0)
            {
                Console.WriteLine("Não há senhas na fila!");
            }
            else
            {
                // chamando a próxima senha da fila
                int senhaChamada = (int)filaDeSenhas.Dequeue();

                Console.WriteLine($"Senha {senhaChamada} foi chamada!");
            }
        }
        else if (opcao == 3)
        {
            // encerrando o programa
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }
    }
    }
}
