namespace CarpeDiem.DataTools.Greeting.Model;

public interface IGreetingsModel
{
    string FirstName { get; set; }
    string MiddleName { get; set; }
    string LastName { get; set; }

    string Greet();
}