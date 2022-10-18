using CarpeDiem.DataTools.Calculator.Mappers;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class CalculatorPresenter : ICalculatorPresenter
{
    private readonly ICalculatorModel model;
    private readonly ICalculatorView view;
    private readonly ISumRequestMapper sumRequestMapper;
    private readonly ICalculatorModelMapper calculatorModelMapper;
    private readonly ICalculatorService service;

    public CalculatorPresenter
    (
        ICalculatorModel model,
        ICalculatorView view,
        ISumRequestMapper sumRequestMapper,
        ICalculatorModelMapper calculatorModelMapper,
        ICalculatorService service
    )
    {
        this.model = model;
        this.view = view;
        this.sumRequestMapper = sumRequestMapper;
        this.calculatorModelMapper = calculatorModelMapper;
        this.service = service;
    }

    public void Initialize()
    {
        view.Bind();
    }

    public void Sum(object? sender, EventArgs e)
    {
        int value1 = int.Parse(model.Value1);
        int value2 = int.Parse(model.Value2);
        var request = sumRequestMapper.Map(value1, value2);
        var response = service.Sum(request);
        calculatorModelMapper.Map(model, response);
    }
}