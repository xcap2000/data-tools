using CarpeDiem.DataTools.Common.Adapters;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CloseCommand : IWorkbenchCommand
{
    private readonly IApplicationAdapter application;

    public CloseCommand(IApplicationAdapter application)
    {
        this.application = application;
    }

    public int Priority { get; } = 0;

    public string Label => "Close";

    public string[] Hierarchy => new[] { "File" };

    public void Execute()
    {
        application.Quit();
    }
}