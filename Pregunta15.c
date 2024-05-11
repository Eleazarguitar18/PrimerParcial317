//  enlace de colab: https://colab.research.google.com/drive/1C_9VQtvUz4QMHj0bx4GjRaLNaszD5-w9?usp=sharing

#include <stdio.h>
#include <omp.h>

int main() {
    #pragma omp parallel
    {
        int rango = omp_get_thread_num();
        int tamaño = omp_get_num_threads();
        printf("Hola mundo desde el proceso %d de %d\n", rango, tamaño);
    }
    return 0;
}

// Comando para compilar y ejecutar:
// gcc -fopenmp Pregunta15.c -o objetos/Pregunta15
// ./objetos/Pregunta15
