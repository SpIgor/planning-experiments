using System;
using System.Collections.Generic;
using System.Text;
using Gtk;
using SMOElementsLibrary;
using ExperimentsLibrary;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnStartModellingBtnClicked(object sender, EventArgs e)
    {
        bool ifGenIntense = GenIntenseRBtn.Active;
        double genIntense = GenIntenseSBtn.Value;
        double genSigma = GenSigmaSBtn.Value;

        bool ifProcIntense = false;
        double procM = ProcMSBtn.Value;
        double procSigma = ProcDSBtn.Value;
        double procIntense = 0;

        double modellingTime = ModellingTimeSBtn.Value;

        ModellingController controller = new ModellingController(ifGenIntense, genSigma, genIntense,
            ifProcIntense, procM, procSigma, procIntense, modellingTime);
        Report report = controller.StartModelling();

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(report.ToString());

        ResTextView.Buffer.Clear();
        ResTextView.Buffer.Text = stringBuilder.ToString();
    }

    protected void OnStartExperimentClicked(object sender, EventArgs e)
    {
        StringBuilder builder = new StringBuilder();

        double minGenIntense = FirstGenMinIntense.Value; double maxGenIntense = FirstGenMaxIntense.Value;
        double minProcM = ProcMinM.Value; double maxProcM = ProcMaxM.Value;
        double minProcD = ProcMinD.Value; double maxProcD = ProcMaxD.Value;

        double expGenIntense = GenIntenseSBtn.Value;
        double expProcM = ProcMSBtn.Value;
        double expProcD = ProcDSBtn.Value;

        FExperiment experiment = new FExperiment(minGenIntense, maxGenIntense, minProcM, maxProcM,
            minProcD, maxProcD, expGenIntense, expProcM, expProcD);

        experiment.GetModellingResults();
        double[] coeffs = experiment.GetCoeffs();
        experiment.GetExperimentParams();

        double exp = PlotGenerator.GetAvgTime(expGenIntense, expProcM, expProcD);
        double linExp = experiment.LinExperiment();
        double nonLinExp = experiment.NonLinExperiment();

        builder.Append($"Коэффициенты линейного плана:\n");
        for (int i = 0; i < 3; i++)
        {
            builder.Append($"b{i} = {coeffs[i]:F2}\n");
        }

        builder.Append("\n\n");
        builder.Append($"Коэффициенты частично нелинейного плана:\n");
        for (int i = 0; i < 3; i++)
        {
            builder.Append($"b{i} = {coeffs[i]:F2}\n");
        }
        builder.Append($"b12 = {coeffs[4]:F2}\n");
        builder.Append($"b13 = {coeffs[5]:F2}\n");
        builder.Append($"b23 = {coeffs[6]:F2}\n");
        builder.Append($"b123 = {coeffs[7]:F2}\n");


        builder.Append("\n\n");
        builder.Append($"Среднее время ожидания заявки в очереди {exp:F2}\n");
        builder.Append($"Результат линейного плана {linExp:F2}\n");
        builder.Append($"Результаты частично нелинейного плана {nonLinExp:F2}\n");

        double linDelta = Math.Abs(exp - linExp) / exp * 100;
        double nonLinDelta = Math.Abs(exp - nonLinExp) / exp * 100;

        builder.Append("\n\n");
        builder.Append($"Отклонение линейного плана = {linDelta:F2}%\n");
        builder.Append($"Отклонение частично нелинейного плана = {nonLinDelta:F2}%\n");

        ResTextView.Buffer.Clear();
        ResTextView.Buffer.Text = builder.ToString();
    }
}
