using CarpeDiem.DataTools.Tasks.Requests;
using CarpeDiem.DataTools.Tasks.Responses;

namespace CarpeDiem.DataTools.Tasks.Presenters;

public static partial class TasksPresenterFacts
{
    public class TheInitializeMethod : BaseFacts
    {
        [Fact]
        [Trait("Category", "Unit")]
        public async void BindsAndHidratesModel()
        {
            var request = For<IListTaskRequest>();

            listTaskRequestMapper.Map(model)
                .Returns(request);

            var response = For<IListTaskResponse>();

            service.ListAsync(request)
                .Returns(response);

            await presenter.InitializeAsync();

            listTaskRequestMapper.Received(1).Map(model);
            await service.Received(1).ListAsync(request);
            tasksModelMapper.Received(1).Map(model, response);

            view.Received(1).Bind();
        }
    }
}