using CarpeDiem.DataTools.Workbench.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Workbench.Views
{
    public partial class WinFormsWorkbenchView : Form, IWorkbenchView
    {
        public WinFormsWorkbenchView()
        {
            InitializeComponent();
        }

        public IEnumerable<IWorkbenchCommand> Commands
        {
            set
            {
            }
        }

        public void Activate(object o)
        {

        }
    }
}

