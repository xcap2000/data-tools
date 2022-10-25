using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CloseCommand : BaseCommand
{
    private readonly IApplicationAdapter application;

    public CloseCommand(IApplicationAdapter application)
    {
        this.application = application;
    }

    public override int Priority { get; } = 0;

    public override string Label => "Close";

    public override void Execute()
    {
        application.Quit();
    }
}