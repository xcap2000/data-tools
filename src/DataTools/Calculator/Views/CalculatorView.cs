using System;
using System.Windows.Forms;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Presenters;

namespace CarpeDiem.DataTools.Calculator.Views;

// TODO - Change to supervising controller.
// TODO - Move this module/plugin to another assembly.
public partial class CalculatorView : UserControl, ICalculatorView
{
    private readonly ICalculatorModel model;
    private readonly ICalculatorPresenter presenter;

    public CalculatorView
    (
        ICalculatorModel model,
        ICalculatorPresenter presenter
    )
    {
        InitializeComponent();
        this.model = model;
        this.presenter = presenter;
    }

    public void Bind()
    {
        value1TextBox.DataBindings.Add("Text", model, "Value1");
        value2TextBox.DataBindings.Add("Text", model, "Value2");
        resultLabel.DataBindings.Add("Text", model, "Result");
        sumButton.Click += presenter.Sum;
    }

    private void WinFormsMiniCalcView_Load(object sender, EventArgs e)
    {
        presenter.Initialize();
    }
}