using System;
namespace SMOElementsLibrary
{
    /// <summary>
    /// Генерирует заявки по закону Рэлея
    /// </summary>
    public class Generator : BaseTimeElement
    {
        Random random = new Random();
        public double TotalTime { get; private set; }

        public int GeneratedRequests { get; private set; } = 0;

        public double Sigma { get; private set; }

        public Generator(double sigma)
        {
            Sigma = sigma;
        }

        public override void IncreaseTime()
        {
            double delay = 0;

            for (int i = 0; i < 100; i++)
            {
                delay += Math.Sqrt((-2) * Math.Pow(Sigma, 2) * Math.Log(1 - random.NextDouble()));
            }
            delay /= 100;

            TotalTime += delay;
            Time += delay;
        }

        public override Request ProcessRequest()
        {
            GeneratedRequests += 1;
            return new Request(GeneratedRequests, Time);
        }

        public override bool ReadyToProcessNext()
        {
            return true;
        }
    }
}
