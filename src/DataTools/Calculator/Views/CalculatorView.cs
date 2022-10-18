using System.ComponentModel;
using System.Windows.Forms;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Presenters;

namespace CarpeDiem.DataTools.Calculator.Views;

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
        const int padding = -19;
        value1TextBox.DataBindings.Add("Text", model, nameof(model.Value1));
        errorProvider.SetIconPadding(value1TextBox, padding);
        value2TextBox.DataBindings.Add("Text", model, nameof(model.Value2));
        errorProvider.SetIconPadding(value2TextBox, padding);
        resultLabel.DataBindings.Add("Text", model, nameof(model.Result));
        messageLabel.DataBindings.Add("Text", model, nameof(model.Message));

        sumButton.Click +=
            (o, a) =>
            {
                errorProvider.SetError(value1TextBox, model[nameof(model.Value1)]);
                errorProvider.SetError(value2TextBox, model[nameof(model.Value2)]);

                if (model.Error.Length == 0)
                {
                    presenter.Sum(o, a);
                }
            };
    }

    private void WinFormsMiniCalcView_Load(object sender, EventArgs e)
    {
        presenter.Initialize();
    }
}