namespace CarpeDiem.DataTools.Tasks.Requests;

public interface IListRequest
{
    int Page { get; }
    int PageSize { get; }
}