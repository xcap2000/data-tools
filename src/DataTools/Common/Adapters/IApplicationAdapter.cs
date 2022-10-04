using CarpeDiem.DataTools.Common.Views;
using System;

namespace CarpeDiem.DataTools.Common.Adapters;

public interface IApplicationAdapter
{
    void Run(Func<IView> getView);

    void Quit();
}