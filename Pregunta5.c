#include <stdio.h>
#include <omp.h>

void matrix_vector_multiplication(int matrix_size, int matrix[matrix_size][matrix_size], int vector_size, int vector[vector_size], int result[vector_size])
{
#pragma omp parallel for
    for (int i = 0; i < matrix_size; ++i)
    {
        result[i] = 0;
        for (int j = 0; j < matrix_size; ++j)
        {
            result[i] += matrix[i][j] * vector[j];
        }
    }
}

void main()
{
    int matrix_size, vector_size;
    printf("Ingrese el tamaño de la matriz y el vector: ");
    scanf("%d", &matrix_size);
    vector_size = matrix_size; // El tamaño del vector es igual al tamaño de la matriz

    int matrix[matrix_size][matrix_size];
    int vector[vector_size];
    int result[vector_size];

    printf("Ingrese los elementos de la matriz:\n");
    for (int i = 0; i < matrix_size; ++i)
    {
        for (int j = 0; j < matrix_size; ++j)
        {
            scanf("%d", &matrix[i][j]);
        }
    }

    printf("Ingrese los elementos del vector:\n");
    for (int i = 0; i < vector_size; ++i)
    {
        scanf("%d", &vector[i]);
    }

    matrix_vector_multiplication(matrix_size, matrix, vector_size, vector, result);

    printf("Resultado de la multiplicación de la matriz por el vector:\n");
    for (int i = 0; i < vector_size; ++i)
    {
        printf("%d ", result[i]);
    }
    printf("\n");
}
