using CarpeDiem.DataTools.Common.Adapters;
using static NSubstitute.Substitute;

namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public abstract class BaseFacts
    {
        protected readonly IApplicationAdapter adapter;
        protected readonly IWorkbenchCommand command;

        protected BaseFacts()
        {
            adapter = For<IApplicationAdapter>();
            command = new CloseCommand(adapter);
        }
    }
}