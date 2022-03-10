using Gtk;

namespace CarpeDiem.DataTools.Workbench.Adapters;

public class ApplicationAdapter : IApplicationAdapter
{
    public void Quit()
    {
        Application.Quit();
    }
}