using CarpeDiem.DataTools.Workbench.Views;
using System;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Common.Adapters
{
    public class WinFormsApplicationAdapter : IApplicationAdapter
    {
        public void Run(Lazy<IWorkbenchView> view)
        {
            ApplicationConfiguration.Initialize();
            Application.Run((Form)view.Value);
        }

        public void Quit()
        {
            Application.Exit();
        }
    }
}