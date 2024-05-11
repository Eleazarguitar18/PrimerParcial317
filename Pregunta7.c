#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <time.h>

#define NUM_SAMPLES 1000000
#define NUM_THREADS 2

int points_inside_circle[NUM_THREADS] = {0};

void *monte_carlo_pi(void *arg) {
    int thread_id = *((int *)arg);
    double x, y;
    
    srand(time(NULL));

    for (int i = 0; i < NUM_SAMPLES / NUM_THREADS; i++) {
        x = (double)rand() / RAND_MAX * 2 - 1;
        y = (double)rand() / RAND_MAX * 2 - 1;

        if (x * x + y * y <= 1)
            points_inside_circle[thread_id]++;
    }

    return NULL;
}

int main() {
    pthread_t threads[NUM_THREADS];
    int thread_args[NUM_THREADS];

    for (int i = 0; i < NUM_THREADS; i++) {
        thread_args[i] = i;
        pthread_create(&threads[i], NULL, monte_carlo_pi, &thread_args[i]);
    }

    for (int i = 0; i < NUM_THREADS; i++) {
        pthread_join(threads[i], NULL);
    }

    int total_inside_circle = 0;
    for (int i = 0; i < NUM_THREADS; i++) {
        total_inside_circle += points_inside_circle[i];
    }

    double pi_estimate = 4.0 * total_inside_circle / NUM_SAMPLES;

    printf("Estimated value of π (pi): %f\n", pi_estimate);

    return 0;
}
