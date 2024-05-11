#include <stdio.h>
#include <omp.h>

#define N 10  // Número de términos
#define M 4   // Número de vectores (procesadores)

int main() {
    int i, j;
    int series[M][N/M];  // Arreglo para almacenar la serie dividida entre M vectores

    // Sección paralela para generar la serie en paralelo
    #pragma omp parallel for private(j)
    for (i = 0; i < M; i++) {
        for (j = 0; j < N/M; j++) {
            series[i][j] = (i * (N/M) + j + 1) * 2;  // Generar el término correspondiente de la serie
        }
    }

    // Imprimir la serie completa
    printf("Serie generada:\n");
    for (i = 0; i < M; i++) {
        printf("Vector %d: ", i + 1);
        for (j = 0; j < N/M; j++) {
            printf("%d ", series[i][j]);
        }
        printf("\n");
    }

    return 0;
}
