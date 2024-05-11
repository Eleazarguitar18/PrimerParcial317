#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

#define N 10  // Número total de términos
#define M 2   // Número de vectores (procesadores)

int main(int argc, char **argv) {
    int rank, size;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    if (size != M) {
        if (rank == 0) {
            printf("Error: El número de procesos debe ser igual a M.\n");
        }
        MPI_Finalize();
        return EXIT_FAILURE;
    }

    int series[N/M];  // Arreglo para almacenar la serie dividida entre M procesos
    int i;

    // Cada proceso genera su parte de la serie
    for (i = 0; i < N/M; i++) {
        series[i] = (rank * (N/M) + i + 1) * 2;  // Generar el término correspondiente de la serie
    }

    // Reunir resultados de todos los procesos en el proceso 0
    int all_series[M][N/M];
    MPI_Gather(series, N/M, MPI_INT, all_series, N/M, MPI_INT, 0, MPI_COMM_WORLD);

    // Imprimir la serie completa desde el proceso 0
    if (rank == 0) {
        printf("Serie generada:\n");
        for (int j = 0; j < M; j++) {
            printf("Vector %d: ", j + 1);
            for (i = 0; i < N/M; i++) {
                printf("%d ", all_series[j][i]);
            }
            printf("\n");
        }
    }

    MPI_Finalize();
    return EXIT_SUCCESS;
}
