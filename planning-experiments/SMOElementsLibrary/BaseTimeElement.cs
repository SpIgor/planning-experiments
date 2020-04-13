using System;
namespace SMOElementsLibrary
{
    public abstract class BaseTimeElement
    {
        public double Time { get; set; }
        public int ProcessedRequests { get; set; }
        public abstract void IncreaseTime();
        public abstract Request ProcessRequest();
        public abstract bool ReadyToProcessNext();
    }
}
