using CarpeDiem.DataTools.Common;

namespace CarpeDiem.DataTools.Greeting.View;

public interface IGreetingsView : IView
{
    string Message { set; }
}