#include <stdio.h>

double suma(double *a, double *b)
{
    return (*a) + (*b);
}

double resta(double *a, double *b)
{
    return (*a) - (*b);
}

double multiplicacion(double *a, double *b)
{
    double resultado = 0;
    double multiplicador = *b;
    while (multiplicador > 0)
    {
        resultado = suma(&resultado, a);
        multiplicador = resta(&multiplicador, b);
    }
    return resultado;
}

double division(double dividendo, double divisor, double *resto)
{
    if (divisor == 0)
    {
        printf("Error: división por cero\n");
    }

    double cociente = 0.0;
    while (dividendo >= divisor)
    {
        dividendo = resta(&dividendo, &divisor);
        cociente += 1.0;
    }
    *resto = dividendo;
    if (*resto >= divisor)
        *resto = division(*resto, divisor, resto);
    return cociente;
}

int main()
{
    double num1, num2;

    printf("Introduce el primer número: ");
    scanf("%lf", &num1);
    printf("Introduce el segundo número: ");
    scanf("%lf", &num2);

    printf("Suma: %.2f\n", suma(&num1, &num2));
    printf("Resta: %.2f\n", resta(&num1, &num2));
    printf("Multiplicación: %.2f\n", multiplicacion(&num1, &num2));
    if (num1 >= num2)
    {
        double resto;
        double resultado = division(num1, num2, &resto);
        printf("El resultado de la división es: %.2f\n", resultado);
        printf("El resto de la división es: %.2f\n", resto);
    }
    else
    {
        printf("el divisor es mas grande que el dividendo\n");
    }

    return 0;
}
