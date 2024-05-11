# enlace de colab: https://colab.research.google.com/drive/1C_9VQtvUz4QMHj0bx4GjRaLNaszD5-w9?usp=sharing

import multiprocessing

# Función para calcular el término de Fibonacci
def fibonacci(n, memo={}):
    if n <= 1:
        return n
    if n not in memo:
        memo[n] = fibonacci(n - 1, memo) + fibonacci(n - 2, memo)
    return memo[n]

# Función para calcular los términos de Fibonacci dentro de un rango dado
def calculate_fibonacci(start, end):
    result = [fibonacci(i) for i in range(start, end)]
    return result

# Función principal
def main():
    num_terms = 1000
    num_processors = 2  # Dos núcleos

    # Dividir el trabajo entre los procesadores
    workload = [(i * num_terms // num_processors, (i + 1) * num_terms // num_processors) for i in range(num_processors)]

    # Crear procesos y ejecutar cálculos de Fibonacci en paralelo
    with multiprocessing.Pool(processes=num_processors) as pool:
        results = pool.starmap(calculate_fibonacci, workload)

    # Combinar los resultados de los procesos
    result = [item for sublist in results for item in sublist]

    # Imprimir la secuencia de Fibonacci calculada
    print("Secuencia de Fibonacci calculada para {} términos:".format(num_terms))
    print(result)

if __name__ == "__main__":
    main()
