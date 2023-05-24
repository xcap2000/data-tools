namespace CarpeDiem.DataTools.Tasks.Responses;

public class ListResponse : IListResponse
{
    public ListResponse(int total, IReadOnlyList<ITaskResponse> tasks)
    {
        Total = total;
        Tasks = tasks;
    }

    public int Total { get; }

    public IReadOnlyList<ITaskResponse> Tasks { get; }
}