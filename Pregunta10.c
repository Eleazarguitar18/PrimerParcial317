#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/wait.h>

#define N 10  // Número total de términos
#define M 4   // Número de procesos

int main() {
    int i, j;
    int start, end;
    int series[M][N/M];  // Matriz para almacenar la serie dividida entre M procesos

    for (i = 0; i < M; i++) {
        start = i * (N / M) + 2;
        end = start + (N / M) * 2 - 2;

        int pid = fork();
        if (pid == 0) {  // Proceso hijo
            for (j = start; j <= end; j += 2) {
                series[i][(j - start) / 2] = j;
            }
            exit(0);
        } else if (pid < 0) {  // Error
            perror("fork");
            exit(1);
        }
    }

    // Esperar a que todos los procesos hijos terminen
    for (i = 0; i < M; i++) {
        wait(NULL);
    }

    // Imprimir la serie completa
    printf("Serie generada:\n");
    for (i = 0; i < M; i++) {
        printf("Vector %d: ", i + 1);
        for (j = 0; j < N/M; j++) {
            printf("%d ", series[i][j]);
        }
        printf("\n");
    }

    return 0;
}
