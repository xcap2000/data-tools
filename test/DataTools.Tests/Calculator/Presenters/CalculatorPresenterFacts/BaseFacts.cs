using CarpeDiem.DataTools.Calculator.Mappers;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Services;

namespace CarpeDiem.DataTools.Calculator;

public static partial class CalculatorPresenterFacts
{
    public abstract class BaseFacts
    {
        protected readonly ICalculatorModel model;
        protected readonly ICalculatorView view;
        protected readonly ICalculatorService service;
        protected readonly ISumRequestMapper sumRequestMapper;
        protected readonly ICalculatorModelMapper calculatorModelMapper;
        protected readonly ICalculatorPresenter presenter;

        protected BaseFacts()
        {
            model = For<ICalculatorModel>();
            view = For<ICalculatorView>();
            sumRequestMapper = For<ISumRequestMapper>();
            calculatorModelMapper = For<ICalculatorModelMapper>();
            service = For<ICalculatorService>();
            presenter = new CalculatorPresenter
            (
                model,
                view,
                service,
                sumRequestMapper,
                calculatorModelMapper
            );
        }
    }
}