
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.Table table2;

	private global::Gtk.RadioButton GeneratorSigmaRBtn;

	private global::Gtk.SpinButton GenIntense;

	private global::Gtk.RadioButton GenIntenseRBtn;

	private global::Gtk.SpinButton GenSigma;

	private global::Gtk.Label GeneratorLabel;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Table table3;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.SpinButton ProcIntense;

	private global::Gtk.SpinButton ProcSigma;

	private global::Gtk.Label ProcessorLabel;

	private global::Gtk.VBox vbox5;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label3;

	private global::Gtk.SpinButton ModellingTimeSBtn;

	private global::Gtk.Button StartModellingBtn;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Button StartExperiment;

	private global::Gtk.Table table4;

	private global::Gtk.Label label11;

	private global::Gtk.Label label12;

	private global::Gtk.Label label5;

	private global::Gtk.Label label7;

	private global::Gtk.Label label8;

	private global::Gtk.Label label9;

	private global::Gtk.SpinButton MaxGenIntense;

	private global::Gtk.SpinButton MaxProcIntense;

	private global::Gtk.SpinButton MaxProcSigma;

	private global::Gtk.SpinButton MinGenIntense;

	private global::Gtk.SpinButton MinProcIntense;

	private global::Gtk.SpinButton MinProcSigma;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView ResTextView;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 20;
		this.hbox1.BorderWidth = ((uint)(15));
		// Container child hbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.table2 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.GeneratorSigmaRBtn = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Сигма"));
		this.GeneratorSigmaRBtn.CanFocus = true;
		this.GeneratorSigmaRBtn.Name = "GeneratorSigmaRBtn";
		this.GeneratorSigmaRBtn.DrawIndicator = true;
		this.GeneratorSigmaRBtn.UseUnderline = true;
		this.GeneratorSigmaRBtn.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.table2.Add(this.GeneratorSigmaRBtn);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2[this.GeneratorSigmaRBtn]));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.GenIntense = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.GenIntense.CanFocus = true;
		this.GenIntense.Name = "GenIntense";
		this.GenIntense.Adjustment.PageIncrement = 10D;
		this.GenIntense.ClimbRate = 1D;
		this.GenIntense.Digits = ((uint)(3));
		this.GenIntense.Numeric = true;
		this.GenIntense.Value = 0.191D;
		this.table2.Add(this.GenIntense);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.GenIntense]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.GenIntenseRBtn = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Интенсивность"));
		this.GenIntenseRBtn.CanFocus = true;
		this.GenIntenseRBtn.Name = "GenIntenseRBtn";
		this.GenIntenseRBtn.DrawIndicator = true;
		this.GenIntenseRBtn.UseUnderline = true;
		this.GenIntenseRBtn.Group = this.GeneratorSigmaRBtn.Group;
		this.table2.Add(this.GenIntenseRBtn);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.GenIntenseRBtn]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.GenSigma = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.GenSigma.CanFocus = true;
		this.GenSigma.Name = "GenSigma";
		this.GenSigma.Adjustment.PageIncrement = 10D;
		this.GenSigma.ClimbRate = 1D;
		this.GenSigma.Digits = ((uint)(3));
		this.GenSigma.Numeric = true;
		this.GenSigma.Value = 10D;
		this.table2.Add(this.GenSigma);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.GenSigma]));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment.Add(this.table2);
		this.frame1.Add(this.GtkAlignment);
		this.GeneratorLabel = new global::Gtk.Label();
		this.GeneratorLabel.Name = "GeneratorLabel";
		this.GeneratorLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Генератор");
		this.GeneratorLabel.UseMarkup = true;
		this.frame1.LabelWidget = this.GeneratorLabel;
		this.hbox1.Add(this.frame1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame1]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.table3 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Интенсивность");
		this.table3.Add(this.label1);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Дисперсия");
		this.table3.Add(this.label2);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3[this.label2]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.ProcIntense = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.ProcIntense.CanFocus = true;
		this.ProcIntense.Name = "ProcIntense";
		this.ProcIntense.Adjustment.PageIncrement = 10D;
		this.ProcIntense.ClimbRate = 1D;
		this.ProcIntense.Digits = ((uint)(3));
		this.ProcIntense.Numeric = true;
		this.ProcIntense.Value = 0.306D;
		this.table3.Add(this.ProcIntense);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3[this.ProcIntense]));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.ProcSigma = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.ProcSigma.CanFocus = true;
		this.ProcSigma.Name = "ProcSigma";
		this.ProcSigma.Adjustment.PageIncrement = 10D;
		this.ProcSigma.ClimbRate = 1D;
		this.ProcSigma.Digits = ((uint)(3));
		this.ProcSigma.Numeric = true;
		this.ProcSigma.Value = 0.33D;
		this.table3.Add(this.ProcSigma);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.ProcSigma]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment1.Add(this.table3);
		this.frame2.Add(this.GtkAlignment1);
		this.ProcessorLabel = new global::Gtk.Label();
		this.ProcessorLabel.Name = "ProcessorLabel";
		this.ProcessorLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Обработчик");
		this.ProcessorLabel.UseMarkup = true;
		this.frame2.LabelWidget = this.ProcessorLabel;
		this.hbox1.Add(this.frame2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame2]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 20;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Время моделирования");
		this.hbox2.Add(this.label3);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.ModellingTimeSBtn = new global::Gtk.SpinButton(0D, 100000D, 1D);
		this.ModellingTimeSBtn.CanFocus = true;
		this.ModellingTimeSBtn.Name = "ModellingTimeSBtn";
		this.ModellingTimeSBtn.Adjustment.PageIncrement = 10D;
		this.ModellingTimeSBtn.ClimbRate = 1D;
		this.ModellingTimeSBtn.Numeric = true;
		this.ModellingTimeSBtn.Value = 10000D;
		this.hbox2.Add(this.ModellingTimeSBtn);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ModellingTimeSBtn]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox5.Add(this.hbox2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.StartModellingBtn = new global::Gtk.Button();
		this.StartModellingBtn.CanFocus = true;
		this.StartModellingBtn.Name = "StartModellingBtn";
		this.StartModellingBtn.UseUnderline = true;
		this.StartModellingBtn.Label = global::Mono.Unix.Catalog.GetString("Моделировать");
		this.vbox5.Add(this.StartModellingBtn);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.StartModellingBtn]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		this.hbox1.Add(this.vbox5);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox5]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.StartExperiment = new global::Gtk.Button();
		this.StartExperiment.CanFocus = true;
		this.StartExperiment.Name = "StartExperiment";
		this.StartExperiment.UseUnderline = true;
		this.StartExperiment.Label = global::Mono.Unix.Catalog.GetString("Эксперимент");
		this.vbox6.Add(this.StartExperiment);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.StartExperiment]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.table4 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("максимальная");
		this.table4.Add(this.label11);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4[this.label11]));
		w22.TopAttach = ((uint)(1));
		w22.BottomAttach = ((uint)(2));
		w22.LeftAttach = ((uint)(2));
		w22.RightAttach = ((uint)(3));
		w22.XOptions = ((global::Gtk.AttachOptions)(4));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label12 = new global::Gtk.Label();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("максимальная");
		this.table4.Add(this.label12);
		global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4[this.label12]));
		w23.TopAttach = ((uint)(2));
		w23.BottomAttach = ((uint)(3));
		w23.LeftAttach = ((uint)(2));
		w23.RightAttach = ((uint)(3));
		w23.XOptions = ((global::Gtk.AttachOptions)(4));
		w23.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Интенсивность генератора минимальная");
		this.table4.Add(this.label5);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table4[this.label5]));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Интенсивность обработчика минимальная");
		this.table4.Add(this.label7);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4[this.label7]));
		w25.TopAttach = ((uint)(1));
		w25.BottomAttach = ((uint)(2));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Дисперсия обработчика минимальная");
		this.table4.Add(this.label8);
		global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4[this.label8]));
		w26.TopAttach = ((uint)(2));
		w26.BottomAttach = ((uint)(3));
		w26.XOptions = ((global::Gtk.AttachOptions)(4));
		w26.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("максимальная");
		this.table4.Add(this.label9);
		global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table4[this.label9]));
		w27.LeftAttach = ((uint)(2));
		w27.RightAttach = ((uint)(3));
		w27.XOptions = ((global::Gtk.AttachOptions)(4));
		w27.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MaxGenIntense = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MaxGenIntense.CanFocus = true;
		this.MaxGenIntense.Name = "MaxGenIntense";
		this.MaxGenIntense.Adjustment.PageIncrement = 10D;
		this.MaxGenIntense.ClimbRate = 1D;
		this.MaxGenIntense.Digits = ((uint)(3));
		this.MaxGenIntense.Numeric = true;
		this.MaxGenIntense.Value = 0.2D;
		this.table4.Add(this.MaxGenIntense);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table4[this.MaxGenIntense]));
		w28.LeftAttach = ((uint)(3));
		w28.RightAttach = ((uint)(4));
		w28.XOptions = ((global::Gtk.AttachOptions)(4));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MaxProcIntense = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MaxProcIntense.CanFocus = true;
		this.MaxProcIntense.Name = "MaxProcIntense";
		this.MaxProcIntense.Adjustment.PageIncrement = 10D;
		this.MaxProcIntense.ClimbRate = 1D;
		this.MaxProcIntense.Digits = ((uint)(3));
		this.MaxProcIntense.Numeric = true;
		this.MaxProcIntense.Value = 0.309D;
		this.table4.Add(this.MaxProcIntense);
		global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table4[this.MaxProcIntense]));
		w29.TopAttach = ((uint)(1));
		w29.BottomAttach = ((uint)(2));
		w29.LeftAttach = ((uint)(3));
		w29.RightAttach = ((uint)(4));
		w29.XOptions = ((global::Gtk.AttachOptions)(4));
		w29.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MaxProcSigma = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MaxProcSigma.CanFocus = true;
		this.MaxProcSigma.Name = "MaxProcSigma";
		this.MaxProcSigma.Adjustment.PageIncrement = 10D;
		this.MaxProcSigma.ClimbRate = 1D;
		this.MaxProcSigma.Digits = ((uint)(3));
		this.MaxProcSigma.Numeric = true;
		this.MaxProcSigma.Value = 0.35D;
		this.table4.Add(this.MaxProcSigma);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table4[this.MaxProcSigma]));
		w30.TopAttach = ((uint)(2));
		w30.BottomAttach = ((uint)(3));
		w30.LeftAttach = ((uint)(3));
		w30.RightAttach = ((uint)(4));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MinGenIntense = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MinGenIntense.CanFocus = true;
		this.MinGenIntense.Name = "MinGenIntense";
		this.MinGenIntense.Adjustment.PageIncrement = 10D;
		this.MinGenIntense.ClimbRate = 1D;
		this.MinGenIntense.Digits = ((uint)(3));
		this.MinGenIntense.Numeric = true;
		this.MinGenIntense.Value = 0.19D;
		this.table4.Add(this.MinGenIntense);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table4[this.MinGenIntense]));
		w31.LeftAttach = ((uint)(1));
		w31.RightAttach = ((uint)(2));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MinProcIntense = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MinProcIntense.CanFocus = true;
		this.MinProcIntense.Name = "MinProcIntense";
		this.MinProcIntense.Adjustment.PageIncrement = 10D;
		this.MinProcIntense.ClimbRate = 1D;
		this.MinProcIntense.Digits = ((uint)(3));
		this.MinProcIntense.Numeric = true;
		this.MinProcIntense.Value = 0.305D;
		this.table4.Add(this.MinProcIntense);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table4[this.MinProcIntense]));
		w32.TopAttach = ((uint)(1));
		w32.BottomAttach = ((uint)(2));
		w32.LeftAttach = ((uint)(1));
		w32.RightAttach = ((uint)(2));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.MinProcSigma = new global::Gtk.SpinButton(0D, 100D, 0.1D);
		this.MinProcSigma.CanFocus = true;
		this.MinProcSigma.Name = "MinProcSigma";
		this.MinProcSigma.Adjustment.PageIncrement = 10D;
		this.MinProcSigma.ClimbRate = 1D;
		this.MinProcSigma.Digits = ((uint)(3));
		this.MinProcSigma.Numeric = true;
		this.MinProcSigma.Value = 0.3D;
		this.table4.Add(this.MinProcSigma);
		global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table4[this.MinProcSigma]));
		w33.TopAttach = ((uint)(2));
		w33.BottomAttach = ((uint)(3));
		w33.LeftAttach = ((uint)(1));
		w33.RightAttach = ((uint)(2));
		w33.XOptions = ((global::Gtk.AttachOptions)(4));
		w33.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox6.Add(this.table4);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.table4]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		this.vbox2.Add(this.vbox6);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox6]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		this.vbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
		w36.Position = 0;
		w36.Expand = false;
		w36.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.ResTextView = new global::Gtk.TextView();
		this.ResTextView.CanFocus = true;
		this.ResTextView.Name = "ResTextView";
		this.ResTextView.Editable = false;
		this.ResTextView.CursorVisible = false;
		this.ResTextView.LeftMargin = 10;
		this.ResTextView.RightMargin = 10;
		this.GtkScrolledWindow.Add(this.ResTextView);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w38.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1236;
		this.DefaultHeight = 786;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.StartModellingBtn.Clicked += new global::System.EventHandler(this.OnStartModellingBtnClicked);
		this.StartExperiment.Clicked += new global::System.EventHandler(this.OnStartExperimentClicked);
	}
}
