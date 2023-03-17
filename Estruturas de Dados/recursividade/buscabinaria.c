#include <stdio.h>

int buscaBinFor(int *vet, int buscado,  int min, int max){
    
    for (; min <= max; ) { //loop para buscar o valor

        int meio = (min + max) / 2; 

        if (vet[meio] == buscado) {
            return meio; //retornando indice do vetor em que o valor se encontra
        
        } else if (vet[meio] > buscado) {
            max = meio - 1; //calculo para buscar o elemento solicitado entre numeros que são maiores que o meio até o max
        
        } else if(vet[meio] < buscado){
            min = meio + 1; //calculo para buscar o elemento solicitado entre o minimo e os numeros que são menores que o meio 
        }else{
            return -1; //caso não encontre o elemento
        }
    }
}
 
int buscaBinariaRecur (int *v, int min, int max, int elem);

int buscaBinariaRecur (int *v, int min, int max, int elem) 
 {
    int meio = (min+max)/2;

    if(elem > v[meio]){
        min = meio + 1; //calculo para buscar o elemento solicitado entre numeros que são maiores que o meio até o max
        return buscaBinariaRecur(v, min, max, elem);

    }else if(elem < v[meio]){
        max = meio - 1;//calculo para buscar o elemento solicitado entre o minimo e os numeros que são menores que o meio 
        return buscaBinariaRecur(v, min, max, elem);

    }else if(elem == v[meio]){ 
        return meio; //retornando indice do vetor em que o valor se encontra

    }else{
        return -1; //caso não encontre o elemento
    }
 }

int main()
{
   int vetor[10] = {1,2,3,4,5,6,7,8,9,10};
    
    printf("Busca Binaria com Recursividade: o numero buscado está no indice: %d\n", buscaBinariaRecur(vetor, 0, 9, 8));
    
    printf("Busca binaria com For: o numero buscado está no indice: %d", buscaBinFor(vetor, 5, 0, 9));
    return 0;
}