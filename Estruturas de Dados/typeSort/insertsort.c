#include <math.h>
#include <stdio.h>
#define tam 5 

void insertionSort1(int array[], int tamanho){ // 11,12,13,5
    int anterior, valorAtual;
    for (int i = 1; i < tamanho; i++) {
        valorAtual = array[i];
        anterior = i - 1;
        while (anterior >= 0 && array[anterior] > valorAtual) {
            array[anterior + 1] = array[anterior];
            anterior = anterior - 1;
        }
        array[anterior + 1] = valorAtual; 
    }
}
void insertionSort2(int array[], int tamanho){
    int anterior, valorAtual;
    for(int i = 1; i < tamanho; i++)
    {
        valorAtual =  array[i];
        anterior = i-1;
        for(int j = anterior; j >=0 ; j--)
        {
            if(anterior >= 0 && array[anterior] > valorAtual)
            {
            array[anterior + 1] = array[anterior];
            anterior = anterior - 1;
            }
        }
        array[anterior + 1] = valorAtual;
    }
}

void main(){
    int array[] = { 12, 11, 13, 5, 6 };
    insertionSort2(array, tam);
    for(int i; i<tam; i++){
        printf("[%d] %d \n", i, array[i]);
    }

}

//melhor caso: array ja ta na ordem
//pior caso: array esta todo invertido/fora de ordem
//estavel: o algoritmo "te coloca na posição final e não mexe mais na sua posição"