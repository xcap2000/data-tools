namespace CarpeDiem.DataTools.Tasks.Responses;

public interface IListResponse
{
    IEnumerable<ITaskResponse> Tasks { get; }
}