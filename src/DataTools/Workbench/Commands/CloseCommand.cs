using CarpeDiem.DataTools.Common.Adapters;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CloseCommand : IWorkbenchCommand
{
    private readonly IApplicationAdapter adapter;

    public CloseCommand(IApplicationAdapter adapter)
    {
        this.adapter = adapter;
    }

    public string Label => "Close";

    public string[] Hierarchy => new[] { "File" };

    public void Execute()
    {
        adapter.Quit();
    }
}