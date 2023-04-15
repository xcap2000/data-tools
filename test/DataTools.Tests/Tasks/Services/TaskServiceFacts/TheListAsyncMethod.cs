using CarpeDiem.DataTools.Common.Entities;
using CarpeDiem.DataTools.Tasks.Requests;
using MockQueryable.NSubstitute;

namespace CarpeDiem.DataTools.Tasks.Services;

public static partial class TaskServiceFacts
{
    public class TheListAsyncMethod : BaseFacts
    {
        public TheListAsyncMethod(TasksFixture fixture)
            : base(fixture)
        {
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void ListsNoTasks()
        {
            var tasks = new List<Task>();

            var tasksDbSet = tasks
                .AsQueryable()
                .BuildMockDbSet();

            context
                .Tasks
                .Returns(tasksDbSet);

            var request = new ListRequest
            (
                page: 0,
                pageSize: 10
            );

            var response = await service.ListAsync(request);

            Empty(response.Tasks);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void ListsFirstPage()
        {
            var tasks = new List<Task>
            {
                new Task(),
                new Task()
            };

            var tasksDbSet = tasks
                .AsQueryable()
                .BuildMockDbSet();

            context
                .Tasks
                .Returns(tasksDbSet);

            var request = new ListRequest
            (
                page: 0,
                pageSize: 2
            );

            var response = await service.ListAsync(request);

            Equal(2, response.Tasks.Count());
        }
    }
}