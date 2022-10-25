using CarpeDiem.DataTools.Common.Adapters;
using CarpeDiem.DataTools.Common.Commands;

namespace CarpeDiem.DataTools.Workbench.Commands;

public static partial class CloseCommandFacts
{
    public abstract class BaseFacts
    {
        protected readonly IApplicationAdapter adapter;
        protected readonly ICommand command;

        protected BaseFacts()
        {
            adapter = For<IApplicationAdapter>();
            command = new CloseCommand(adapter);
        }
    }
}