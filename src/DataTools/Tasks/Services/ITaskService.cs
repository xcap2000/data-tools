using System.Threading.Tasks;
using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Services;

public interface ITaskService
{
    Task<IListTaskResponse> ListAsync(IListTaskRequest request);
}