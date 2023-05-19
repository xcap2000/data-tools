namespace CarpeDiem.DataTools.Tasks.Responses;

public class ListResponse : IListResponse
{
    public ListResponse(IReadOnlyList<ITaskResponse> tasks)
    {
        Tasks = tasks;
    }

    public IReadOnlyList<ITaskResponse> Tasks { get; }
}