using System;
namespace SMOElementsLibrary
{
    public class Request
    {
        public int Id { get; private set; }
        public double CreationTime { get; private set; }
        public double DequeueTime { get; set; }

        public Request(int id, double time)
        {
            Id = id;
            CreationTime = time;
        }
    }
}
