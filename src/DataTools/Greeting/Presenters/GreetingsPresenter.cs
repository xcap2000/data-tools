using CarpeDiem.DataTools.Greeting.Model;
using CarpeDiem.DataTools.Greeting.View;

namespace CarpeDiem.DataTools.Greeting.Presenters;

public class GreetingsPresenter : IGreetingsPresenter
{
    private readonly IGreetingsView view;
    private readonly IGreetingsModel model;

    public GreetingsPresenter(IGreetingsView view, IGreetingsModel model)
    {
        this.view = view;
        this.model = model;
    }

    public void OnFirstNameChanged(string firstName)
    {
        model.FirstName = firstName;
    }

    public void OnMiddleNameChanged(string middleName)
    {
        model.MiddleName = middleName;
    }

    public void OnLastNameChanged(string lastName)
    {
        model.LastName = lastName;
    }

    public void Greet()
    {
        view.Message = model.Greet();
    }
}