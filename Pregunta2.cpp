#include <iostream>

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
        std::cout << "Error: división por cero\n";
        return 0.0;
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

    std::cout << "Introduce el primer número: ";
    std::cin >> num1;
    std::cout << "Introduce el segundo número: ";
    std::cin >> num2;

    std::cout << "Suma: " << suma(&num1, &num2) << std::endl;
    std::cout << "Resta: " << resta(&num1, &num2) << std::endl;
    std::cout << "Multiplicación: " << multiplicacion(&num1, &num2) << std::endl;
    if (num1 >= num2)
    {
        double resto;
        double resultado = division(num1, num2, &resto);
        std::cout << "El resultado de la división es: " << resultado << std::endl;
        std::cout << "El resto de la división es: " << resto << std::endl;
    }
    else
    {
        std::cout << "El divisor es más grande que el dividendo" << std::endl;
    }

    return 0;
}
