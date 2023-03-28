#include <math.h>
#include <stdio.h>
#define tam 5 

void SelectionSort(int *vetor, int tamanho){
    int i, j ,aux, menor;
    
    for (i = 0; i < tam; i++)
    {  
        menor = i;
       for(j = i; j < (tamanho); j++)
       {
            if(vetor[j] < vetor[menor])
           {
            menor = j;  
            }
           
        }
        aux = vetor[menor];
        vetor[menor] = vetor[i]; 
        vetor[i] = aux;
        
    }
}

int main(){
    int vet[tam] = {7,6,5,4,3};
    SelectionSort(vet, tam);
    printf("Elementos: ");
    for(int i = 0; i < tam; i++)
    {
        printf("%d ", vet[i]);
    }
    printf("\n");
  return 0;
}