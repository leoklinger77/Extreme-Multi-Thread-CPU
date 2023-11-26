using System.Collections.Concurrent;
using System.Threading;
using System;
using System.Diagnostics;
using System.Reactive.Concurrency;

//int numThreads = Environment.ProcessorCount;
//int numThreads = 1; // Obtém o número de núcleos do processador
//2.+147.483.647
Int32 numGUIDs = 1000;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
int i = 0;
for (i = 0; i < numGUIDs; i++) {
    //Guid guid = Guid.NewGuid();
    //Console.WriteLine(i);
}




stopwatch.Stop();
double elapsedTimeInSeconds = stopwatch.Elapsed.TotalSeconds;

Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Minutes + " Minutes");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Seconds + " Seconds");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Milliseconds + " Milliseconds");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.TotalNanoseconds + " Nanoseconds");
Console.WriteLine("Pontuação: " + CalculateScore(elapsedTimeInSeconds, numGUIDs).ToString("N3"));
static int CalculateScore(double elapsedTimeInSeconds, Int64 numGUIDS) {
    // Faça cálculos para determinar a pontuação com base no tempo de execução ou na taxa de geração de GUIDs
    // Quanto menor o tempo de execução ou maior a taxa de geração, maior a pontuação

    // Exemplo de cálculo de pontuação simples com base no tempo de execução:
    int score = (int)(numGUIDS / elapsedTimeInSeconds);

    return score;
}

/*
ConcurrentBag<Guid> guids = new ConcurrentBag<Guid>();
AutoResetEvent autoResetEvent = new AutoResetEvent(false);

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
Thread[] threads = new Thread[numThreads];
Int64 guidsPerThread = numGUIDs / numThreads;

for (int i = 0; i < numThreads; i++) {
    threads[i] = new Thread(() => GenerateGUIDs(guids, guidsPerThread, autoResetEvent));
    threads[i].Start();
}

autoResetEvent.WaitOne();
stopwatch.Stop();
GC.Collect();
double elapsedTimeInSeconds = stopwatch.Elapsed.TotalSeconds;

Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Minutes + " Minutes");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Seconds + " Seconds");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.Milliseconds + " Milliseconds");
Console.WriteLine("Tempo de processamento: " + stopwatch.Elapsed.TotalNanoseconds + " Nanoseconds");
Console.WriteLine("Pontuação: " + CalculateScore(elapsedTimeInSeconds, numGUIDs).ToString("N3"));

static void GenerateGUIDs(ConcurrentBag<Guid> guids, Int64 numGUIDs, AutoResetEvent autoResetEvent) {
    int i = 0;
    for (i = 0; i < numGUIDs; i++) {
        Guid guid = Guid.NewGuid();
        //Console.WriteLine(i);
        //guids.Add(guid);
    }

    if (i >= numGUIDs) {
        autoResetEvent.Set();
    }
}

static int CalculateScore(double elapsedTimeInSeconds, Int64 numGUIDS) {
    // Faça cálculos para determinar a pontuação com base no tempo de execução ou na taxa de geração de GUIDs
    // Quanto menor o tempo de execução ou maior a taxa de geração, maior a pontuação

    // Exemplo de cálculo de pontuação simples com base no tempo de execução:
    int score = (int)(numGUIDS / elapsedTimeInSeconds);

    return score;
}

*/