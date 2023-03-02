#include <stdio.h>
//Creditos: Yuri Soares
/*  TEORIA DE PONTEIROS
 *  int x; (Em algum lugar na memória de tamanho inteiro (seu tipo))
 *  x = 5; (Dentro desse espaço existe um valor binário codificado para o número
 * 5)
 *
 *  Ponteiro armazena o endereço na memória de uma variável
 *
 *  ATENÇÃO!: Ponteiros não inicializados apontam para um endereço indefinido
 * (arbitrário)
 *
 *  Para saber o endereço, usamos &. Exemplo: int c = 10;
 *                                            int *p;
 *                                            p = &c; (aqui o endereço de c é
 * atribuído a p)
 *
 * O conteúdo para onde um pontiero aponta deve ser do MESMO TIPO.
 *
 */

int main(void) {
  int c = 10;
  int *p;
  p = &c;

  printf("\t O conteúdo de c é: %i \n", c);
  printf("\t O endereço de c é: %p \n", &c);
  printf("\t O endereço de p é: %p \n", &p);
  printf("\t O endereço apontado por p: %p \n", p);
  printf("\t O conteúdo apontado por p é: %i \n", *p);

  printf("\nAlterando o valor de c:\n\n");
  *p = 12;

  printf("\t O Conteúdo apontado por p é: %i \n", *p);
  printf("\t Agora, o conteúdo de c é: %i \n", c);
  printf("\nNote acima que o conteúdo da variável c foi alterado pelo "
         "ponteiro. Isso nos permite algumas técnicas em programação, como "
         "alterar o valor de uma variável fora de escopo (como fora de uma "
         "função.");

  printf("\n\n------------------------------------\n\n");

  int *p0, *p1, x = 10;
  float y = 20.0;
  p0 = &x; // (o ponteiro p0 aponta para x)

  printf("\t O conteúdo apontado por p0 é: %i \n", *p0);

  p1 = p0; // p1 aponta para p0 que, por sua vez, aponta para x (já é possível
           // imaginar o seu valor ...)
  printf("\t O conteúdo apontado por p1 é: %i \n", *p1);

  p0 = &y; // Agora aponta para o conteúdo de y;
  printf("\t O conteúdo apontado por p0 é: %i \n",
         *p0); // Tente alterar o tipo de y para int
  printf("\t O conteúdo apontado por p0 é: %f \n",
         *p0); // O próprio editor já indica a incongruência
  printf("\t O conteúdo apontado por p0 é: %f \n", *((float *)p0));

  return 0;
}
