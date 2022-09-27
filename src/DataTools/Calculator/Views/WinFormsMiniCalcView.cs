using CarpeDiem.DataTools.Calculator.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Calculator.Views
{
    public partial class WinFormsMiniCalcView : UserControl, IMiniCalcView
    {
        private readonly IMiniCalcPresenter presenter;

        public WinFormsMiniCalcView(IMiniCalcPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        public string Value1
        {
            get => value1TextBox.Text;
            set => value1TextBox.Text = value;
        }
        public string Value2
        {
            get => value1TextBox.Text;
            set => value2TextBox.Text = value;
        }
        public string Result { set => resultLabel.Text = value; }

        private void WinFormsMiniCalcView_Load(object sender, EventArgs e)
        {
            presenter.Initialize();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            presenter.Sum();
        }
    }
}
