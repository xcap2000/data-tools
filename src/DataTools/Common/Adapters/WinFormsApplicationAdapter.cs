using CarpeDiem.DataTools.Common.Views;
using System;
using System.Windows.Forms;

namespace CarpeDiem.DataTools.Common.Adapters;

public class WinFormsApplicationAdapter : IApplicationAdapter
{
    public void Run(Func<IView> getView)
    {
        ApplicationConfiguration.Initialize();
        Application.Run((Form)getView());
    }

    public void Quit()
    {
        Application.Exit();
    }
}