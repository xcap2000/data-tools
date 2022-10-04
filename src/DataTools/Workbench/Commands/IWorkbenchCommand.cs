namespace CarpeDiem.DataTools.Workbench.Commands;

public interface IWorkbenchCommand
{
    int Priority { get; }
    string[] Hierarchy { get; }
    string Label { get; }

    void Execute();
}