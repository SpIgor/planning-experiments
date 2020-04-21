using System;
using System.Collections.Generic;
using System.Text;
using Gtk;
using ExperimentsLibrary;
using TimeElementsLibrary;

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
        double firstGenIntense = FirstGenIntense.Value;
        double secondGenIntense = SecondGenIntense.Value;
        double procIntenese = ProcIntense.Value;
        double procD = ProcD.Value;

        ModellingController controller = new ModellingController(firstGenIntense, secondGenIntense, procIntenese, procD);

        Report report = controller.StartModelling();

        ResTextView.Buffer.Clear();
        ResTextView.Buffer.Text = report.ToString();
    }

    protected void OnStartExperimentClicked(object sender, EventArgs e)
    {
        double firstGenIntense = FirstGenIntense.Value;
        double secondGenIntense = SecondGenIntense.Value;
        double procIntenese = ProcIntense.Value;
        double procD = ProcD.Value;

        double firstGenMinIntense = FirstGenMinIntense.Value; double firstGenMaxIntense = FirstGenMaxIntense.Value;
        double secondGenMinIntense = SecondGenMinIntense.Value; double secondGenMaxIntense = SecondGenMaxIntense.Value;
        double procMinIntense = ProcMinIntense.Value; double procMaxIntense = ProcMaxIntense.Value;
        double procMinD = ProcMinD.Value; double procMaxD = ProcMaxD.Value;

        FIntenseExperiment experiment = new FIntenseExperiment(firstGenMinIntense, firstGenMaxIntense,
                                                               secondGenMinIntense, secondGenMaxIntense,
                                                               procMinIntense, procMaxIntense,
                                                               procMinD, procMaxD,
                                                               firstGenIntense, secondGenIntense, procIntenese, procD);

        StringBuilder builder = new StringBuilder();

        experiment.GetModellingResults();
        experiment.GetCoeffs();
        experiment.GetZLists();
        experiment.LinExperiment();
        experiment.NonLinExperiment();

        builder.Append("ПФЭ\n");
        builder.Append("Линейный план\n");
        for (int i = 0; i < 4; i++)
        {
            builder.Append($"b{i} = {experiment.Coeffs[i]:F2}  ");
        }
        builder.Append("\nЧастично нелинейный план\n");
        for (int i = 0; i < 16; i++)
        {
            builder.Append($"b{i} = {experiment.Coeffs[i]:F2}  ");
        }

        double res = ExperimentsLibrary.PlotGenerator.GetExperimentResult(firstGenIntense, secondGenIntense, procIntenese, procD);
        double deltaLin = Math.Abs(res - experiment.LinExpRes) / res * 100;
        double deltaNonLin = Math.Abs(res - experiment.NonLinExpRes) / res * 100;

        while (deltaLin > deltaNonLin)
        {
            res = ExperimentsLibrary.PlotGenerator.GetExperimentResult(firstGenIntense, secondGenIntense, procIntenese, procD);
            deltaLin = Math.Abs(res - experiment.LinExpRes) / res * 100;
            deltaNonLin = Math.Abs(res - experiment.NonLinExpRes) / res * 100;
        }

        builder.Append("\n\nСравнение результатов\n");
        builder.Append($"Результат моделирования {res:F4}\n");
        builder.Append($"Результат линейной модели {experiment.LinExpRes:F4}\n");
        builder.Append($"Результат частично нелинейной модели {experiment.NonLinExpRes:F4}\n");

        builder.Append($"\nОтелонение линейной модели {deltaLin:F2}%\n");
        builder.Append($"Отелонение частично нелинейной модели {deltaNonLin:F2}%\n");

        ResTextView.Buffer.Clear();
        ResTextView.Buffer.Text = builder.ToString();
    }

    protected void OnPlotGeneratorClicked(object sender, EventArgs e)
    {
        ResTextView.Buffer.Clear();
        ResTextView.Buffer.Text = ExperimentsLibrary.PlotGenerator.GetPlotPoints();
    }
}
