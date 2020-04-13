using System;
using System.Text;
using SMOElementsLibrary;

namespace ExperimentsLibrary
{
    public class FExperiment
    {
        int coeffAmount;
        int N;
        int[,] matrix =
        {
            {1,-1,-1,-1, 1, 1, 1,-1},
            {1, 1,-1,-1,-1,-1, 1, 1},
            {1,-1, 1,-1,-1, 1, 1, 1},
            {1, 1, 1,-1, 1,-1, 1,-1},
            {1,-1,-1, 1, 1,-1,-1, 1},
            {1, 1,-1, 1,-1, 1,-1,-1},
            {1,-1, 1, 1,-1,-1,-1,-1},
            {1, 1, 1, 1, 1, 1,-1, 1},
        };

        double[] genIntense = new double[2];
        double[] procM = new double[2];
        double[] procD = new double[2];

        double expGenIntense;
        double expProcM;
        double expProcD;

        public double[] ExperimentResults { get; set; } = new double[8];
        double[] coeffs = new double[8];
        double[] x = new double[3];

        double[] zCenterList = new double[3];
        double[] zDeltaLIst = new double[3];

        public FExperiment(double minGenIntense, double maxGenIntense, double minProcM, double maxProcM,
            double minProcD, double maxProcD, double expGenIntense, double expProcM, double expProcD)
        {
            this.expGenIntense = expGenIntense;
            this.expProcM = expProcM;
            this.expProcD = expProcD;

            genIntense[0] = minGenIntense; genIntense[1] = maxGenIntense;
            procM[0] = minProcM; procM[1] = maxProcM;
            procD[0] = minProcD; procD[1] = maxProcD;


        }

        public void GetModellingResults()
        {
            ExperimentResults[0] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[0], procM[0], procD[0]);
            ExperimentResults[1] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[1], procM[0], procD[0]);
            ExperimentResults[2] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[0], procM[1], procD[0]);
            ExperimentResults[3] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[1], procM[1], procD[0]);
            ExperimentResults[4] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[0], procM[0], procD[1]);
            ExperimentResults[5] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[1], procM[0], procD[1]);
            ExperimentResults[6] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[0], procM[1], procD[1]);
            ExperimentResults[7] = PlotGenerator.GetAvgTimeOnProcSigma(genIntense[1], procM[1], procD[1]);
        }

        public double[] GetCoeffs()
        {
            for (int j = 0; j < 8; j++)
            {
                double sum = 0;
                for (int i = 0; i < 8; i++)
                {
                    sum += matrix[i, j] * ExperimentResults[i];
                }
                coeffs[j] = sum / 8;
            }

            return coeffs;
        }

        public double[] GetExperimentParams()
        {
            zCenterList[0] = (genIntense[1] + genIntense[0]) / 2;
            zDeltaLIst[0] = (genIntense[1] - genIntense[0]) / 2;

            zCenterList[1] = (procM[1] + procM[0]) / 2;
            zDeltaLIst[1] = (procM[1] - procM[0]) / 2;

            zCenterList[2] = (procD[1] + procD[0]) / 2;
            zDeltaLIst[2] = (procD[1] - procD[0]) / 2;

            x[0] = (expGenIntense - zCenterList[0]) / zDeltaLIst[0];
            x[1] = (expProcM - zCenterList[1]) / zDeltaLIst[1];
            x[2] = (expProcD - zCenterList[2]) / zDeltaLIst[2];

            return x;
        }

        public double LinExperiment()
        {
            return coeffs[0] + x[0] * coeffs[1] + x[1] * coeffs[2] + x[2] * coeffs[3];
        }

        public double NonLinExperiment()
        {
            return coeffs[0] + x[0] * coeffs[1] + x[1] * coeffs[2] + x[2] * coeffs[3]
                + x[0] * x[1] * coeffs[4] + x[0] * x[2] * coeffs[5] + x[1] * x[2] * coeffs[6]
                + x[0] * x[1] * x[2] * coeffs[7];
        }
    }
}
