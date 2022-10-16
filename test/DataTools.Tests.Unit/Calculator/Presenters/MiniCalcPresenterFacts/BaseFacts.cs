using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public static partial class MiniCalcPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly IMiniCalcView view;
        protected readonly IMiniCalcService service;
        protected readonly IMiniCalcPresenter presenter;

        protected BaseFacts()
        {
            view = For<IMiniCalcView>();
            service = For<IMiniCalcService>();
            presenter = new MiniCalcPresenter(view, service);
        }
    }
}