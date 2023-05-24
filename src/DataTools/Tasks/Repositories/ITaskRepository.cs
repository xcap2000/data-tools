using System.Threading.Tasks;
using CarpeDiem.DataTools.Common.Entities;

namespace CarpeDiem.DataTools.Tasks.Repositories;

public interface ITaskRepository
{
    Task<int> CountAsync();
    Task<IEnumerable<ITask>> ListAsync(int page, int pageSize);
}