using CarpeDiem.DataTools.Workbench.Adapters;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CloseCommand : IWorkbenchCommand
{
    private readonly IApplicationAdapter adapter;

    public CloseCommand(IApplicationAdapter adapter)
    {
        this.adapter = adapter;
    }

    public string Label => "Close";

    public void Execute()
    {
        adapter.Quit();
    }
}