namespace CarpeDiem.DataTools.Workbench.Commands;

public interface IWorkbenchCommand
{
    string Label { get; }

    void Execute();
}