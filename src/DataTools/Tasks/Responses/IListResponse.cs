namespace CarpeDiem.DataTools.Tasks.Responses;

public interface IListResponse
{
    IReadOnlyList<ITaskResponse> Tasks { get; }
}