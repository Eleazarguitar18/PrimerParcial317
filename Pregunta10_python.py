# enlace de colab: https://colab.research.google.com/drive/1C_9VQtvUz4QMHj0bx4GjRaLNaszD5-w9?usp=sharing
import multiprocessing

def generate_series(start, end, result_queue):
    series = []
    for i in range(start, end + 1, 2):
        series.append(i)
    result_queue.put(series)

def main():
    N = 10  # Número total de términos
    M = 4   # Número de vectores (procesadores)

    result_queue = multiprocessing.Queue()

    processes = []
    for i in range(M):
        start = i * (N // M) + 2
        end = start + (N // M) * 2 - 2
        process = multiprocessing.Process(target=generate_series, args=(start, end, result_queue))
        processes.append(process)
        process.start()

    for process in processes:
        process.join()

    result = []
    while not result_queue.empty():
        result.extend(result_queue.get())

    print("Serie generada:")
    for i, value in enumerate(result):
        print(f"Vector {i + 1}: {value}")

if __name__ == "__main__":
    main()
