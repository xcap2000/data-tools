using CarpeDiem.DataTools.Calculator.Factories;
using CarpeDiem.DataTools.Unit.Common.Factories;

namespace CarpeDiem.DataTools.Unit.Calculator.Factories;

public static class SumRequestFactoryFacts
{
    public class TheCreateMethod : BaseTheCreateMethod<ISumRequest, ISumRequestFactory>
    {
        protected override ISumRequestFactory CreateFactory()
            => new SumRequestFactory(resolver);
    }
}