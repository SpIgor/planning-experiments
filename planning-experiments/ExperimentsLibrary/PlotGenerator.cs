using System;
using System.Collections.Generic;
using System.Text;
using TimeElementsLibrary;

namespace ExperimentsLibrary
{
    public static class PlotGenerator
    {
        static double modellingTime = 1000;
        static double load_step = 0.05;
        static double repeats = 30;

        public static double GetExperimentResult(double firstGenIntense, double secondGenIntense,
                                                 double procIntense, double procD,
                                                 double expectedLoad = 0)
        {
            double avgTime = 0;
            double avgLoad = 0;
            for (int i = 0; i < repeats; i++)
            {
                ModellingController controller = new ModellingController(firstGenIntense, secondGenIntense, procIntense, procD, modellingTime);
                Report report = controller.StartModelling();
                avgTime += report.GetAvgTime();
                avgLoad += report.Load();
            }
            avgLoad /= repeats;
            avgTime /= repeats;

            Console.WriteLine($"I1 = {firstGenIntense:F3}; I2 = {secondGenIntense:F3}; I3 = {procIntense:F3}; D = {procD:F3}");
            Console.WriteLine($"Ожидаемая загрузка {(firstGenIntense + secondGenIntense) / procIntense:F4}\nПолученная загрузка {avgLoad:F4}\nВремя ожидания {avgTime:F4}\n\n");
            return avgTime;
        }

        public static string GetPlotPoints()
        {
            double load = 0.1;
            double procIntense = 10;
            double procD = 0.3;
            List<double> y = new List<double>();
            List<double> x = new List<double>();

            while (load < 1)
            {
                double genIntense = (procIntense * load) / 2;

                x.Add(load);
                y.Add(GetExperimentResult(genIntense, genIntense, procIntense, procD, load));
                load += load_step;
            }

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < x.Count; i++)
            {
                builder.Append($"{x[i]};{y[i]};\n");
            }

            return builder.ToString();
        }
    }
}
