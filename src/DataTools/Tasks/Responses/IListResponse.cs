namespace CarpeDiem.DataTools.Tasks.Responses;

public interface IListResponse
{
    int Total { get; }
    IReadOnlyList<ITaskResponse> Tasks { get; }
}