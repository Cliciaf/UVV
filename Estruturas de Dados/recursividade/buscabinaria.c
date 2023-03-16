#include <stdio.h>

 int buscaBinariaFor(int*v, int min, int max, int elem)
 {

 }
 
int buscaBinariaRecur (int *v, int min, int max, int elem);

int buscaBinariaRecur (int *v, int min, int max, int elem) 
 {
    int meio = (min+max)/2;
    printf("%d", meio);
    if(elem > v[meio]){
        return buscaBinariaRecur(v, meio, max, elem);

    }else if(elem < v[meio]){
        return buscaBinariaRecur(v, min, meio, elem);

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