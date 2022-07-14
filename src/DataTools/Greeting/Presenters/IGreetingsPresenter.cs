namespace CarpeDiem.DataTools.Greeting.Presenters;

public interface IGreetingsPresenter
{
    void OnFirstNameChanged(string firstName);
    void OnMiddleNameChanged(string middleName);
    void OnLastNameChanged(string lastName);
    void Greet();
}