using System;
using System.Collections.Generic;
using System.Text;
using TimeElementsLibrary;

namespace ExperimentsLibrary
{
    public class FIntenseExperiment
    {
        int paramsAmount = 4;
        int coeffsAmount = 16;

        int[,] matrix =
        {
            {1,-1,-1,-1,-1,1, 1, 1, 1, 1, 1, -1,-1,-1,-1,1},
            {1,-1,-1,-1,1, 1, 1, -1,1, -1,-1,-1,1, 1, 1, -1},
            {1,-1,-1,1, -1,1, -1,1, -1,1, -1,1, -1,1, 1, -1},
            {1,-1,-1,1, 1, 1, -1,-1,-1,-1,1, 1, 1, -1,-1,1},
            {1,-1,1, -1,-1,-1,1, 1, -1,-1,1, 1, 1, -1,1, -1},
            {1,-1,1, -1,1, -1,1, -1,-1,1, -1,1, -1,1, -1,1},
            {1,-1,1, 1, -1,-1,-1,1, 1, -1,-1,-1,1, 1, -1,1},
            {1,-1,1, 1, 1, -1,-1,-1,1, 1, 1, -1,-1,-1,1, -1},
            {1,1, -1,-1,-1,-1,-1,-1,1, 1, 1, 1, 1, 1, -1,-1},
            {1,1, -1,-1,1, -1,-1,1, 1, -1,-1,1, -1,-1,1, 1},
            {1,1, -1,1, -1,-1,1, -1,-1,1, -1,-1,1, -1,1, 1},
            {1,1, -1,1, 1, -1,1, 1, -1,-1,1, -1,-1,1, -1,-1},
            {1,1, 1, -1,-1,1, -1,-1,-1,-1,1, -1,-1,1, 1, 1},
            {1,1, 1, -1,1, 1, -1,1, -1,1, -1,-1,1, -1,-1,-1},
            {1,1, 1, 1, -1,1, 1, -1,1, -1,-1,1, -1,-1,-1,-1},
            {1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        };

        public double FirstGenMinIntense { get; }
        public double FirstGenMaxIntense { get; }
        public double SecondGenMinIntense { get; }
        public double SecondGenMaxIntense { get; }
        public double ProcMinIntense { get; }
        public double ProcMaxIntense { get; }
        public double ProcMinD { get; }
        public double ProcMaxD { get; }
        public double FristGenIntense { get; }
        public double SecondGenIntense { get; }
        public double ProcIntense { get; }
        public double ProcD { get; }
        public double[] Results { get => results; set => results = value; }
        public double[] Coeffs { get => coeffs; set => coeffs = value; }
        public double[] ZCenterList { get => zCenterList; set => zCenterList = value; }
        public double[] ZDeltaList { get => zDeltaList; set => zDeltaList = value; }
        public double[] X { get => x; set => x = value; }
        public double LinExpRes { get => linExpRes; set => linExpRes = value; }
        public double NonLinExpRes { get => nonLinExpRes; set => nonLinExpRes = value; }

        double[] coeffs;
        double[] results;
        double[] zCenterList;
        double[] zDeltaList;
        double[] x;

        double linExpRes = 0;
        double nonLinExpRes = 0;

        public FIntenseExperiment(double firstGenMinIntense, double firstGenMaxIntense,
                                  double secondGenMinIntense, double secondGenMaxIntense,
                                  double procMinIntense, double procMaxIntense,
                                  double procMinD, double procMaxD,
                                  double fristGenIntense, double secondGenIntense, double procIntense, double procD)
        {
            FirstGenMinIntense = firstGenMinIntense;
            FirstGenMaxIntense = firstGenMaxIntense;
            SecondGenMinIntense = secondGenMinIntense;
            SecondGenMaxIntense = secondGenMaxIntense;
            ProcMinIntense = procMinIntense;
            ProcMaxIntense = procMaxIntense;
            ProcMinD = procMinD;
            ProcMaxD = procMaxD;
            FristGenIntense = fristGenIntense;
            SecondGenIntense = secondGenIntense;
            ProcIntense = procIntense;
            ProcD = procD;

            Coeffs = new double[coeffsAmount];
            Results = new double[coeffsAmount];
            ZCenterList = new double[paramsAmount];
            ZDeltaList = new double[paramsAmount];
            X = new double[paramsAmount];
        }

        public void GetModellingResults()
        {
            for (int i = 0; i < coeffsAmount; i++)
            {
                double firstGenExpIntense, secondGenExpIntense, procExpIntense, procExpD;

                if (matrix[i, 1] == -1)
                    firstGenExpIntense = FirstGenMinIntense;
                else
                    firstGenExpIntense = FirstGenMaxIntense;

                if (matrix[i, 2] == -1)
                    secondGenExpIntense = SecondGenMinIntense;
                else
                    secondGenExpIntense = SecondGenMaxIntense;

                if (matrix[i, 3] == -1)
                    procExpIntense = ProcMinIntense;
                else
                    procExpIntense = ProcMaxIntense;

                if (matrix[i, 4] == -1)
                    procExpD = ProcMinD;
                else
                    procExpD = ProcMaxD;

                Results[i] = PlotGenerator.GetExperimentResult(firstGenExpIntense, secondGenExpIntense, procExpIntense, procExpD);
            }
            Console.WriteLine("\n\n");
        }

        public void GetCoeffs()
        {
            for (int j = 0; j < coeffsAmount; j++)
            {
                double sum = 0;
                for (int i = 0; i < coeffsAmount; i++)
                {
                    sum += matrix[i, j] * results[i];
                }
                coeffs[j] = sum / coeffsAmount;
            }
        }

        public void GetZLists()
        {
            ZCenterList[0] = (FirstGenMaxIntense + FirstGenMinIntense) / 2;
            ZDeltaList[0] = (FirstGenMaxIntense - FirstGenMinIntense) / 2;

            ZCenterList[1] = (SecondGenMaxIntense + SecondGenMinIntense) / 2;
            ZDeltaList[1] = (SecondGenMaxIntense - SecondGenMinIntense) / 2;

            ZCenterList[2] = (ProcMaxIntense + ProcMinIntense) / 2;
            ZDeltaList[2] = (ProcMaxIntense - ProcMinIntense) / 2;

            ZCenterList[3] = (ProcMaxD + ProcMinD) / 2;
            ZDeltaList[3] = (ProcMaxD - ProcMinD) / 2;

            X[0] = (FristGenIntense - ZCenterList[0]) / ZDeltaList[0];
            X[1] = (SecondGenIntense - ZCenterList[1]) / ZDeltaList[1];
            X[2] = (ProcIntense - ZCenterList[2]) / ZDeltaList[2];
            X[3] = (ProcD - ZCenterList[3]) / ZDeltaList[3];
        }

        public void LinExperiment()
        {
            LinExpRes = coeffs[0] + coeffs[1] * x[0] + coeffs[2] * x[1] + coeffs[3] * x[2] + coeffs[4] * x[3];
        }

        public void NonLinExperiment()
        {
            NonLinExpRes = coeffs[0] + coeffs[1] * x[0] + coeffs[2] * x[1] + coeffs[3] * x[2] + coeffs[4] * x[3]
                + coeffs[5] * x[0] * x[1] + coeffs[6] * x[0] * x[2] + coeffs[7] * x[0] * x[3] + coeffs[8] * x[1] * x[2] + coeffs[9] * x[1] * x[3] + coeffs[10] * x[2] * x[3]
                + coeffs[11] * x[0] * x[1] * x[2] + coeffs[12] * x[0] * x[1] * x[3] + coeffs[13] * x[0] * x[2] * x[3] + coeffs[14] * x[1] * x[2] * x[3]
                + coeffs[15] * x[0] * x[1] * x[2] * x[3];
        }
    }

    public class DIntenseExperiment
    {
        int paramsAmount = 4;
        int expAmount = 8;
        int coeffsAmount = 16;

        int[,] matrix =
        {
            {1,-1,-1,-1,-1,1, 1, 1, 1, 1, 1, -1,-1,-1,-1,1},
            {1,-1,-1,1, 1, 1, -1,-1,-1,-1,1, 1, 1, -1,-1,1},
            {1,-1,1, -1,1, -1,1, -1,-1,1, -1,1, -1,1, -1,1},
            {1,-1,1, 1, -1,-1,-1,1, 1, -1,-1,-1,1, 1, -1,1},
            {1,1, -1,-1,1, -1,-1,1, 1, -1,-1,1, -1,-1,1, 1},
            {1,1, -1,1, -1,-1,1, -1,-1,1, -1,-1,1, -1,1, 1},
            {1,1, 1, -1,-1,1, -1,-1,-1,-1,1, -1,-1,1, 1, 1},
            {1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        };

        public double FirstGenMinIntense { get; }
        public double FirstGenMaxIntense { get; }
        public double SecondGenMinIntense { get; }
        public double SecondGenMaxIntense { get; }
        public double ProcMinIntense { get; }
        public double ProcMaxIntense { get; }
        public double ProcMinD { get; }
        public double ProcMaxD { get; }
        public double FristGenIntense { get; }
        public double SecondGenIntense { get; }
        public double ProcIntense { get; }
        public double ProcD { get; }

        public double[] Results { get => results; set => results = value; }
        public double[] Coeffs { get => coeffs; set => coeffs = value; }
        public double[] ZCenterList { get => zCenterList; set => zCenterList = value; }
        public double[] ZDeltaList { get => zDeltaList; set => zDeltaList = value; }
        public double[] X { get => x; set => x = value; }
        public double LinExpRes { get => linExpRes; set => linExpRes = value; }
        public double NonLinExpRes { get => nonLinExpRes; set => nonLinExpRes = value; }

        double[] coeffs;
        double[] results;
        double[] zCenterList;
        double[] zDeltaList;
        double[] x;

        double linExpRes = 0;
        double nonLinExpRes = 0;

        public DIntenseExperiment(double firstGenMinIntense, double firstGenMaxIntense,
                                  double secondGenMinIntense, double secondGenMaxIntense,
                                  double procMinIntense, double procMaxIntense,
                                  double procMinD, double procMaxD,
                                  double fristGenIntense, double secondGenIntense, double procIntense, double procD)
        {
            FirstGenMinIntense = firstGenMinIntense;
            FirstGenMaxIntense = firstGenMaxIntense;
            SecondGenMinIntense = secondGenMinIntense;
            SecondGenMaxIntense = secondGenMaxIntense;
            ProcMinIntense = procMinIntense;
            ProcMaxIntense = procMaxIntense;
            ProcMinD = procMinD;
            ProcMaxD = procMaxD;
            FristGenIntense = fristGenIntense;
            SecondGenIntense = secondGenIntense;
            ProcIntense = procIntense;
            ProcD = procD;

            Coeffs = new double[coeffsAmount];
            Results = new double[expAmount];
            ZCenterList = new double[paramsAmount];
            ZDeltaList = new double[paramsAmount];
            X = new double[paramsAmount];
        }

        public void GetModellingResults()
        {
            for (int i = 0; i < expAmount; i++)
            {
                double firstGenExpIntense, secondGenExpIntense, procExpIntense, procExpD;

                if (matrix[i, 1] == -1)
                    firstGenExpIntense = FirstGenMinIntense;
                else
                    firstGenExpIntense = FirstGenMaxIntense;

                if (matrix[i, 2] == -1)
                    secondGenExpIntense = SecondGenMinIntense;
                else
                    secondGenExpIntense = SecondGenMaxIntense;

                if (matrix[i, 3] == -1)
                    procExpIntense = ProcMinIntense;
                else
                    procExpIntense = ProcMaxIntense;

                if (matrix[i, 4] == -1)
                    procExpD = ProcMinD;
                else
                    procExpD = ProcMaxD;

                Results[i] = PlotGenerator.GetExperimentResult(firstGenExpIntense, secondGenExpIntense, procExpIntense, procExpD);
            }
        }

        public void GetCoeffs()
        {
            for (int j = 0; j < coeffsAmount; j++)
            {
                double sum = 0;
                for (int i = 0; i < expAmount; i++)
                {
                    sum += matrix[i, j] * results[i];
                }
                coeffs[j] = sum / expAmount;
            }
        }

        public void GetZLists()
        {
            ZCenterList[0] = (FirstGenMaxIntense + FirstGenMinIntense) / 2;
            ZDeltaList[0] = (FirstGenMaxIntense - FirstGenMinIntense) / 2;

            ZCenterList[1] = (SecondGenMaxIntense + SecondGenMinIntense) / 2;
            ZDeltaList[1] = (SecondGenMaxIntense - SecondGenMinIntense) / 2;

            ZCenterList[2] = (ProcMaxIntense + ProcMinIntense) / 2;
            ZDeltaList[2] = (ProcMaxIntense - ProcMinIntense) / 2;

            ZCenterList[3] = (ProcMaxD + ProcMinD) / 2;
            ZDeltaList[3] = (ProcMaxD - ProcMinD) / 2;

            X[0] = (FristGenIntense - ZCenterList[0]) / ZDeltaList[0];
            X[1] = (SecondGenIntense - ZCenterList[1]) / ZDeltaList[1];
            X[2] = (ProcIntense - ZCenterList[2]) / ZDeltaList[2];
            X[3] = (ProcD - ZCenterList[3]) / ZDeltaList[3];
        }

        public void LinExperiment()
        {
            LinExpRes = coeffs[0] + coeffs[1] * x[0] + coeffs[2] * x[1] + coeffs[3] * x[2] + coeffs[4] * x[3];
        }

        public void NonLinExperiment()
        {
            NonLinExpRes = coeffs[0] + coeffs[1] * x[0] + coeffs[2] * x[1] + coeffs[3] * x[2] + coeffs[4] * x[3]
                + coeffs[5] * x[0] * x[1] + coeffs[6] * x[0] * x[2] + coeffs[7] * x[0] * x[3] + coeffs[8] * x[1] * x[2] + coeffs[9] * x[1] * x[3] + coeffs[10] * x[2] * x[3]
                + coeffs[11] * x[0] * x[1] * x[2] + coeffs[12] * x[0] * x[1] * x[3] + coeffs[13] * x[0] * x[2] * x[3] + coeffs[14] * x[1] * x[2] * x[3]
                + coeffs[15] * x[0] * x[1] * x[2] * x[3];
        }
    }
}
