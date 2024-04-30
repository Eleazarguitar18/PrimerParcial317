#include <stdio.h>
#include <omp.h>

#define N 3

void matrix_vector_multiplication(int matrix[N][N], int vector[N], int result[N])
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
    int matrix[N][N] = {{1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}};

    int vector[N] = {1, 2, 3};
    int result[N];

    matrix_vector_multiplication(matrix, vector, result);

    printf("Resultado de la multiplicación de la matriz por el vector:\n");
    for (int i = 0; i < N; ++i)
    {
        printf("%d ", result[i]);
    }
    printf("\n");
}
/* preguntar al lic si los datos de la matris deben ser introducidas por teclado */