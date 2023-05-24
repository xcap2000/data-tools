using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Mappers;

public class ListResponseMapper : IListResponseMapper
{
    private readonly ITaskResponseMapper mapper;

    public ListResponseMapper(ITaskResponseMapper mapper)
    {
        this.mapper = mapper;
    }

    public IListResponse Map(int total, IEnumerable<ITask> tasks)
    {
        return new ListResponse(total, mapper.Map(tasks));
    }
}