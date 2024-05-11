#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>
#include <time.h>

#define TOTAL_POINTS 100000000 // Número total de puntos

int main(int argc, char *argv[]) {
    int rank, size, i, count;
    double x, y, z, pi, pi_local;
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    // Semilla aleatoria diferente para cada proceso
    srand(time(NULL) + rank);

    count = 0;
    for (i = 0; i < TOTAL_POINTS / size; i++) {
        // Generar coordenadas aleatorias dentro del cuadrado
        x = (double)rand() / RAND_MAX;
        y = (double)rand() / RAND_MAX;
        z = x * x + y * y;

        // Verificar si el punto está dentro del círculo
        if (z <= 1) {
            count++;
        }
    }

    // Sumar todos los conteos locales
    MPI_Reduce(&count, &pi_local, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);

    // Proceso 0 calcula el valor final de pi
    if (rank == 0) {
        pi = 4.0 * pi_local / TOTAL_POINTS;
        printf("Estimación de PI: %f\n", pi);
    }

    MPI_Finalize();
    return 0;
}
