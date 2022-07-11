namespace CarpeDiem.DataTools.Workbench.Commands;

public interface IWorkbenchCommand
{
    string[] Hierarchy { get; }
    string Label { get; }

    void Execute();
}