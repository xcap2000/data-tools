using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Presenters;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Calculator.Views;

// TODO - Move this module/plugin to another assembly.
public partial class CalculatorView : Form, ICalculatorView
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
        model.PropertyChanged +=
            (o, a) =>
            {
                switch (a.PropertyName)
                {
                    case "Value1Message":
                        errorProvider.SetError(value1TextBox, model.Value1Message);
                        break;
                    case "Value2Message":
                        errorProvider.SetError(value2TextBox, model.Value2Message);
                        break;
                }
            };

        sumButton.Click += presenter.Sum;
    }

    private void WinFormsMiniCalcView_Load(object sender, EventArgs e)
    {
        presenter.Initialize();
    }

    // TODO - Let it close and enable menu again, when menu is created again then recreate.
    // TODO - If it implements a marker interface we should enable creating more than one instance according to that.
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}