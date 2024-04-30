#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>
#include <time.h>

#define NUM_SAMPLES 1000000

int main(int argc, char *argv[])
{
    int rank, size, i;
    double x, y, pi_estimate, pi_sum, start_time, end_time;
    int count = 0;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    srand(time(NULL) + rank);

    start_time = MPI_Wtime();

    for (i = 0; i < NUM_SAMPLES / size; i++)
    {
        x = (double)rand() / RAND_MAX;
        y = (double)rand() / RAND_MAX;
        if (x * x + y * y <= 1.0)
        {
            count++;
        }
    }

    MPI_Reduce(&count, &pi_sum, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);

    if (rank == 0)
    {
        pi_estimate = 4.0 * pi_sum / NUM_SAMPLES;
        end_time = MPI_Wtime();
        printf("Estimated value of pi: %f\n", pi_estimate);
        printf("Time taken: %f seconds\n", end_time - start_time);
    }

    MPI_Finalize();

    return 0;
}
