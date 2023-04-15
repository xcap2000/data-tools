namespace CarpeDiem.DataTools.Tasks.Requests;

public class ListRequest : IListRequest
{
    public ListRequest(int page, int pageSize)
    {
        Page = page;
        PageSize = pageSize;
    }

    public int Page { get; }
    public int PageSize { get; }
}