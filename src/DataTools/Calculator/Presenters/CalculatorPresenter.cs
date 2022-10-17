using System;
using CarpeDiem.DataTools.Calculator.Models;
using CarpeDiem.DataTools.Calculator.Services;
using CarpeDiem.DataTools.Calculator.Views;

namespace CarpeDiem.DataTools.Calculator.Presenters;

public class CalculatorPresenter : ICalculatorPresenter
{
    private readonly ICalculatorModel model;
    private readonly ICalculatorView view;
    private readonly ICalculatorService service;

    public CalculatorPresenter
    (
        ICalculatorModel model,
        ICalculatorView view,
        ICalculatorService service
    )
    {
        this.model = model;
        this.view = view;
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
        model.Result = service.Sum(value1, value2).ToString();
    }
}