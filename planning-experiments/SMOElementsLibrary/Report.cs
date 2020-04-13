using System;
namespace SMOElementsLibrary
{
    public struct Report
    {
        public int generatedRequests;
        public int enqueuedRequests;
        public int dequeuedRequests;
        public int processedRequests;

        public double generatorTotalTime;
        public double processorTotalTime;

        public double modellingTime;

        public double generatorCalcIntense;
        public double processorCalcIntense;

        public double GeneratorIntense { get => generatedRequests / generatorTotalTime; }
        public double ProcIntense { get => processedRequests / processorTotalTime; }

        public double totalWaitingTime;
        public double AvgWaitingTime { get => totalWaitingTime / processedRequests; }
        public double Load { get => GeneratorIntense / ProcIntense; }

        public override string ToString()
        {
            return $"Сгенерировано заявок {generatedRequests} за {generatorTotalTime:F2}\n" +
                $"Среднее время на создание заявки {generatorTotalTime / generatedRequests:F2}\n\n" +
                $"Обработано заявок {processedRequests} за {processorTotalTime:F2}\n" +
                $"Среднее время на обработку заявки {processorTotalTime / processedRequests:F2}\n\n" +
                $"Заявок было добавлено в очередь {enqueuedRequests} и извлечено из очереди {dequeuedRequests}\n\n" +
                $"Рассчетная интенсивность генератора {generatorCalcIntense:F2}\n" +
                $"Полученная интенсивность генератора {GeneratorIntense:F2}\n\n" +
                $"Рассчетная интенсивность обработчика {processorCalcIntense:F2}\n" +
                $"Полученная интенсивность обработчика {ProcIntense:F2}\n\n" +
                $"Среднее время ожидания в очереди {AvgWaitingTime:F2}\n" +
                $"Полученная загрузка {Load:F2}\n";
        }
    }
}
