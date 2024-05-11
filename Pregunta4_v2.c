#include <stdio.h>
#include <omp.h>

void matrix_vector_multiplication(int N, int matrix[N][N], int vector_N, int vector[vector_N], int result[vector_N])
{
#pragma omp parallel for
    for (int i = 0; i < N; ++i)
    {
        result[i] = 0;
        for (int j = 0; j < N; ++j)
        {
            result[i] += matrix[i][j] * vector[j];
        }
    }
}

void main()
{
    int N, vector_N;
    printf("El tamaño del vector es igual al tamaño de la matriz \n");
    printf("Ingrese el tamaño de la matriz y el vector: ");
    scanf("%d", &N);
    vector_N = N; // El tamaño del vector es igual al tamaño de la matriz

    int matrix[N][N];
    int vector[vector_N];
    int result[vector_N];

    printf("Ingrese los elementos de la matriz:\n");
    for (int i = 0; i < N; ++i)
    {
        for (int j = 0; j < N; ++j)
        {
            scanf("%d", &matrix[i][j]);
        }
    }

    printf("Ingrese los elementos del vector:\n");
    for (int i = 0; i < vector_N; ++i)
    {
        scanf("%d", &vector[i]);
    }

    matrix_vector_multiplication(N, matrix, vector_N, vector, result);

    printf("Resultado de la multiplicación de la matriz por el vector:\n");
    for (int i = 0; i < vector_N; ++i)
    {
        printf("%d ", result[i]);
    }
    printf("\n");
}
