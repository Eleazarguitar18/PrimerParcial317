#include <stdio.h>
#include <omp.h>

void main()
{
    int a = 10; // Primer número
    int b = 5;  // Segundo número

    // Multiplicación utilizando sumas
    int product = 0;
#pragma omp parallel for reduction(+ : product)
    for (int i = 0; i < b; ++i)
    {
#pragma omp atomic
        product += a;
    }

    printf("Multiplicación de %d y %d es: %d\n", a, b, product);

    // División utilizando restas
    int cociente = 0;
    int temp = a;
#pragma omp parallel
    {
#pragma omp single
        while (temp >= b)
        {
#pragma omp atomic
            temp -= b;
#pragma omp atomic
            cociente++;
        }
    }

    printf("División de %d entre %d es: %d\n", a, b, cociente);
}
