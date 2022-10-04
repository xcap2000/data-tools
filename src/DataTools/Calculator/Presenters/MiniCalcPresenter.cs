using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class MiniCalcPresenter : IMiniCalcPresenter
{
    private readonly IMiniCalcView view;
    private readonly IMiniCalcService service;

    public MiniCalcPresenter
    (
        IMiniCalcView view,
        IMiniCalcService service
    )
    {
        this.view = view;
        this.service = service;
    }

    public void Initialize()
    {
        view.Value1 = "";
        view.Value2 = "";
        view.Result = "";
    }

    public void Sum()
    {
        int value1 = int.Parse(view.Value1);
        int value2 = int.Parse(view.Value2);
        view.Result = service.Sum(value1, value2).ToString();
    }
}