#include<stdio.h>
#include<math.h> // chama a biblioteca "math.h" para efetuar cÃ¡lculos com raizes e potencia

int main(){
	int numeroimprecao, i; 
// incia um for que percorre todas a sequencia de fibonacci, comeÃ§ando de i atÃ© i=0
	for (i = 10; i >= 0; i--) {
	// para calcular a sequencia de Fibonacci uso a formula: F(i) = (pow((1 + sqrt(5)), i) - pow((1 - sqrt(5)), i)) / (pow(2, i) * sqrt(5))
		numeroimprecao = (pow((1 + sqrt(5)), i) - (pow((1 - sqrt(5)), i))) /(pow(2, i) * sqrt(5));
        printf("%d\n", numeroimprecao);
    }
	return 0;
}