using System;
using System.Collections.Generic;

namespace SMOElementsLibrary
{
    public class ModellingController
    {
        Generator generator;
        Processor processor;
        RequestsQueue queue;
        public double ModellingTime { get; set; }
        readonly List<Request> processedRequests = new List<Request>();
        readonly List<BaseTimeElement> allElements = new List<BaseTimeElement>();
        readonly List<BaseTimeElement> processingElements = new List<BaseTimeElement>();

        public double CalcGeneratorIntense()
        {
            return 1 / (Math.Sqrt(Math.PI / 2) * generator.Sigma);
        }

        public double CalcProcessorIntense()
        {
            return 1 / processor.M;
        }

        public ModellingController(bool ifGenIntense, double genSigma, double genIntense,
                                   bool ifProcIntense, double procM, double procSigma, double procIntense, double modellingTime = 1000)
        {
            if (ifGenIntense)
            {
                genSigma = 1 / (Math.Sqrt(Math.PI / 2) * genIntense);
            }
            generator = new Generator(genSigma);
            allElements.Add(generator);

            if (ifProcIntense)
            {
                procM = 1 / procIntense;
                procSigma = 1;
            }
            processor = new Processor(procM, procSigma);
            allElements.Add(processor);
            queue = processor.Queue;

            ModellingTime = modellingTime;
        }

        public double RequestWaitingTime(List<Request> processedRequests, Queue<Request> queue)
        {
            double total = 0;
            foreach (var request in processedRequests)
            {
                //Console.WriteLine(request.Id);
                total += request.DequeueTime - request.CreationTime;
            }

            //foreach (var request in queue)
            //{
            //    Console.WriteLine(request.Id);
            //total += ModellingTime - request.CreationTime;
            //}

            return total;
        }

        private BaseTimeElement GetMinTimeElement(List<BaseTimeElement> elements)
        {
            if (elements.Count == 1)
                return elements[0];

            BaseTimeElement minTimeElement = elements[0];

            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i].Time < minTimeElement.Time)
                    minTimeElement = elements[i];
            }

            return minTimeElement;
        }

        public Report StartModelling()
        {
            //int step = 0;

            generator.IncreaseTime();
            queue.Enqueue(generator.ProcessRequest());
            double currentTime = generator.Time;
            //double currentTime = 0;

            while (currentTime <= ModellingTime)
            {
                //Console.WriteLine("step = {0}", step);
                processingElements.Clear();
                foreach (var element in allElements)
                {
                    if (element.ReadyToProcessNext())
                    {
                        processingElements.Add(element);
                    }
                }
                BaseTimeElement timeElement = GetMinTimeElement(processingElements);
                //Console.WriteLine($"current_time = {currentTime}; element_time = {timeElement.Time}");
                if (timeElement is Generator)
                {
                    //Console.WriteLine($"gen {timeElement.Time}");
                    ((Generator)timeElement).IncreaseTime();
                    queue.Enqueue(((Generator)timeElement).ProcessRequest());
                    currentTime = timeElement.Time;
                }
                else
                {
                    if (((Processor)timeElement).Time < currentTime)
                        ((Processor)timeElement).Time = currentTime;
                    //Console.WriteLine($"processor {timeElement.Time}");
                    processedRequests.Add(((Processor)timeElement).ProcessRequest());
                    currentTime = timeElement.Time;
                    ((Processor)timeElement).IncreaseTime();
                }
                //step++;
            }

            return new Report()
            {
                generatedRequests = generator.GeneratedRequests,
                enqueuedRequests = queue.EnqueuedRequests,
                dequeuedRequests = queue.DequeuedRequests,
                processedRequests = processor.ProcessedRequests,

                generatorTotalTime = generator.TotalTime,
                processorTotalTime = processor.TotalTime,

                modellingTime = ModellingTime,

                generatorCalcIntense = CalcGeneratorIntense(),
                processorCalcIntense = CalcProcessorIntense(),

                totalWaitingTime = RequestWaitingTime(processedRequests, queue.Queue),
            };
        }
    }
}
