using CarpeDiem.DataTools.Common.Views;

namespace CarpeDiem.DataTools.Common.Adapters;

public interface IApplicationAdapter
{
    void Run(Func<IView> getView);

    void Quit();
}