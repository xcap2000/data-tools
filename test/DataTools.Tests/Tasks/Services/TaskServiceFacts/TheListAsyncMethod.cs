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
            Equal(0, response.Total);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void ListsFirstPage()
        {
            var idTask1 = Guid.NewGuid();
            var idTask2 = Guid.NewGuid();
            var idTask3 = Guid.NewGuid();
            var idTask4 = Guid.NewGuid();

            var tasks = new List<Task>
            {
                new Task(idTask1),
                new Task(idTask2),
                new Task(idTask3),
                new Task(idTask4)
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

            Equal(2, response.Tasks.Count);
            Equal(idTask1, response.Tasks[0].Id);
            Equal(idTask2, response.Tasks[1].Id);
            Equal(4, response.Total);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public async void ListsSecondPage()
        {
            var idTask1 = Guid.NewGuid();
            var idTask2 = Guid.NewGuid();
            var idTask3 = Guid.NewGuid();
            var idTask4 = Guid.NewGuid();

            var tasks = new List<Task>
            {
                new Task(idTask1),
                new Task(idTask2),
                new Task(idTask3),
                new Task(idTask4)
            };

            var tasksDbSet = tasks
                .AsQueryable()
                .BuildMockDbSet();

            context
                .Tasks
                .Returns(tasksDbSet);

            var request = new ListRequest
            (
                page: 1,
                pageSize: 2
            );

            var response = await service.ListAsync(request);

            Equal(2, response.Tasks.Count);
            Equal(idTask3, response.Tasks[0].Id);
            Equal(idTask4, response.Tasks[1].Id);
            Equal(4, response.Total);
        }
    }
}