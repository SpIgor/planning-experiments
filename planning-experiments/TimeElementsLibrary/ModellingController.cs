using System;
namespace TimeElementsLibrary
{
    public class ModellingController
    {
        Generator firstGenerator, secondGenerator;
        Processor processor;
        Queue queue = new Queue();
        double modellingTime;
        double timeStep = 0.001;

        public ModellingController(double fistGenIntense, double secondGenIntense,
                                   double procIntense, double procD,
                                   double modellingTime = 1000)
        {
            double firstGenSigma = 1 / (Math.Sqrt(Math.PI / 2) * fistGenIntense);
            firstGenerator = new Generator(firstGenSigma);

            double secondGenSigma = 1 / (Math.Sqrt(Math.PI / 2) * secondGenIntense);
            secondGenerator = new Generator(secondGenSigma);

            double procM = 1 / procIntense;
            procD = procM * procD;
            processor = new Processor(procM, procD, queue);
            this.modellingTime = modellingTime;
        }

        public Report StartModelling()
        {
            double currentTime = 0;

            while (currentTime < modellingTime)
            {
                firstGenerator.Decrease(timeStep);
                secondGenerator.Decrease(timeStep);
                processor.Decrease(timeStep);

                if (firstGenerator.Delay <= 0)
                {
                    firstGenerator.GenerateDelay();
                    queue.AddRequest(currentTime);
                }

                if (secondGenerator.Delay <= 0)
                {
                    secondGenerator.GenerateDelay();
                    queue.AddRequest(currentTime);
                }

                if (processor.ifProcessing == false)
                {
                    if (processor.GetRequestFromQueue() == true)
                    {
                        queue.GetRequest(currentTime);
                        processor.StartProcessing();
                    }
                }
                else if (processor.Delay <= 0)
                {
                    processor.EndProcessing();
                }

                currentTime += timeStep;
            }

            return new Report(firstGenerator, secondGenerator, processor, queue);
        }
    }
}
