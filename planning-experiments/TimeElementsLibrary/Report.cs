using System;
namespace TimeElementsLibrary
{
    public class Report
    {
        public Generator FirstGenerator { get; }
        public Generator SecondGenerator { get; }
        public Processor Processor { get; }
        public Queue Queue { get; }

        public Report(Generator firstGenerator, Generator secondGenerator, Processor processor, Queue queue)
        {
            FirstGenerator = firstGenerator;
            SecondGenerator = secondGenerator;
            Processor = processor;
            Queue = queue;
        }

        public double GetAvgTime()
        {
            int length = Queue.OutTime.Count;
            double sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += Queue.OutTime[i] - Queue.InTime[i];
            }
            sum /= length;

            return sum;
        }

        public double Load()
        {
            return (FirstGeneratorIntense() + SecondGeneratorIntense()) / ProcIntense();
        }

        public double FirstGeneratorIntense()
        {
            return FirstGenerator.GeneratedRequests / FirstGenerator.CurrentTime;
        }

        public double SecondGeneratorIntense()
        {
            return SecondGenerator.GeneratedRequests / SecondGenerator.CurrentTime;
        }

        public double ProcIntense()
        {
            return Processor.ProcessedRequests / Processor.CurrentTime;
        }

        public override string ToString()
        {
            string res =
                $"Сгенерировано заявок:\n" +
                    $"\tПервым генератором {FirstGenerator.GeneratedRequests} за {FirstGenerator.CurrentTime:F2}\n" +
                    $"\tВторым генератором {SecondGenerator.GeneratedRequests} за {SecondGenerator.CurrentTime:F2}\n" +
                $"Обработано заявок {Processor.ProcessedRequests} за {Processor.CurrentTime:F2}\n\n" +
                $"Интенсивности генераторов:\n" +
                    $"\tПервого {FirstGeneratorIntense():F2}\n" +
                    $"\tВторого {SecondGeneratorIntense():F2}\n" +
                $"Интенсивность ОА {ProcIntense():F2}\n" +
                $"Полученная загрузка системы {Load():F2}\n\n" +
                $"Среднее время ожидания заявки {GetAvgTime():F2}\n\n\n";

            return res;
        }
    }
}
