#include <stdio.h>
int buscaBinariaFor(int*v, int elem);
int buscaBinariaFor(int*v, int elem)
{
    int min = 0;
    int max = sizeof(v);
    int meio = (min+max)/2;
    if(max < min){
        return -1
    }else if(v[meio] < elem){
        for(int i = meio; i < max; i++){
            if(v[i] < elem){
                return i;
            }
        }

    }
    }
}
 
int buscaBinariaRecur (int *v, int min, int max, int elem);

int buscaBinariaRecur (int *v, int min, int max, int elem) 
 {
    int meio = (min+max)/2;
    //printf("%d", meio);
    if(elem > v[meio]){
        min = meio + 1;
        return buscaBinariaRecur(v, min, max, elem);

    }else if(elem < v[meio]){
        max = meio - 1;
        return buscaBinariaRecur(v, min, max, elem);

    }else if(elem == v[meio]){ 
        return v[meio];

    }else{
        return -1;
    }
 }

int main()
{
   int vetor[10] = {1,2,3,4,5,6,7,8,9,10};
    
    printf("%d", buscaBinariaRecur(vetor, 0, 9, 10));
    return 0;
}