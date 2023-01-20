using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Workbench.Commands;

public class CloseCommand : BaseCommand
{
    private readonly IApplicationAdapter application;

    public CloseCommand(IApplicationAdapter application)
        : base(0, "File", "Close")
    {
        this.application = application;
    }

    public override void Execute()
    {
        application.Quit();
    }
}