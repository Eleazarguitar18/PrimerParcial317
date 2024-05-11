#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>
#include <time.h>

#define NUM_SAMPLES 1000000

int main(int argc, char **argv) {
    int rank, num_procs;
    int points_inside_circle = 0;
    double x, y;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &num_procs);

    srand(time(NULL) + rank); // Seed the random number generator

    // Distribute the workload among processes
    int num_samples_per_process = NUM_SAMPLES / num_procs;
    for (int i = 0; i < num_samples_per_process; i++) {
        x = (double)rand() / RAND_MAX * 2 - 1;
        y = (double)rand() / RAND_MAX * 2 - 1;

        if (x * x + y * y <= 1)
            points_inside_circle++;
    }

    // Gather results from all processes
    int total_points_inside_circle;
    MPI_Reduce(&points_inside_circle, &total_points_inside_circle, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);

    if (rank == 0) {
        double pi_estimate = 4.0 * total_points_inside_circle / NUM_SAMPLES;
        printf("Estimated value of π (pi): %f\n", pi_estimate);
    }

    MPI_Finalize();

    return 0;
}
