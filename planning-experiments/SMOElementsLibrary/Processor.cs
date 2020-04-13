using System;
namespace SMOElementsLibrary
{
    public class Processor : BaseTimeElement
    {
        Random random = new Random();
        public RequestsQueue Queue { get; private set; } = new RequestsQueue();
        public double TotalTime { get; private set; }

        public double M { get; private set; }

        public double Sigma { get; private set; }

        public Processor(double m, double sigma)
        {
            M = m;
            Sigma = sigma;
        }

        public override void IncreaseTime()
        {
            double res = 0;
            while (res <= 0)
            {
                double r_sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    r_sum += random.NextDouble();

                }
                r_sum -= 5;
                res = Sigma * Math.Sqrt(12 / 10) * r_sum + M;
            }
            TotalTime += res;
            Time += res;
        }

        public override Request ProcessRequest()
        {
            ProcessedRequests++;
            return Queue.Dequeue(Time);
        }

        public override bool ReadyToProcessNext()
        {
            if (Queue.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
