#include <stdio.h>
    
int buscaElemento (int *v, int elem, int tam);

int buscaElemento (int *v, int elem, int tam)//"tam" serve para ser usado como indice do vetor 
{
    
    if (v[tam-1] == elem)//caso encontre o elemento, retornar ele
    {
        return v[tam-1];
        
    }else if (tam == 0 && v[0] != elem)//caso chegue a tam=0 e não encontre o elemento, retornar -1
    {
        return -1;
        
    }else{
        tam--;//decrementando o indice do vetor que sera passado como tamanho na prox chamada da função
        return buscaElemento (v, elem, tam);
    }
}

int main()
{
    
    int vetor[10]={1,2,3,4,5,6,7,8,9,11};
    
    printf("elemento encontrado: %d",buscaElemento(vetor, 5, 10));
    
    return 0;
}
