using System;
using System.Collections.Generic;

namespace SMOElementsLibrary
{
    public class RequestsQueue
    {
        public Queue<Request> Queue { get; } = new Queue<Request>();
        public int EnqueuedRequests { get; private set; } = 0;
        public int DequeuedRequests { get; private set; } = 0;
        public int Count { get => Queue.Count; }
        public Queue<Request> UnprocessedRequests { get => Queue; }

        public void Enqueue(Request request)
        {
            Queue.Enqueue(request);
            EnqueuedRequests++;
        }

        public Request Dequeue(double time)
        {
            if (Count > 0)
            {
                DequeuedRequests++;
                Request request = Queue.Dequeue();
                request.DequeueTime = time;
                if (request.CreationTime > request.DequeueTime)
                {
                    Console.WriteLine($"Изъятие из очереди до добавления {request.CreationTime} - {request.DequeueTime}");
                    throw new Exception("Изъятие из очереди до добавления");
                }
                return request;
            }
            throw new Exception("Пустая очередь");
        }
    }
}
