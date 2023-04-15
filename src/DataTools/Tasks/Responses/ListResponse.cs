namespace CarpeDiem.DataTools.Tasks.Responses;

public class ListResponse : IListResponse
{
    public ListResponse(IEnumerable<ITaskResponse> tasks)
    {
        Tasks = tasks;
    }

    public IEnumerable<ITaskResponse> Tasks { get; }
}