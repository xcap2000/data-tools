using CarpeDiem.DataTools.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpeDiem.DataTools.Common.Contexts;

// TODO - Implement.
public interface IContext
{
    DbSet<Task> Tasks { get; }
}