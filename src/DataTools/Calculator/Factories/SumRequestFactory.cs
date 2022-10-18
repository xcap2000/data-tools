using CarpeDiem.DataTools.Calculator.Requests;
using CarpeDiem.DataTools.Common.Factories;
using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Calculator.Factories;

public class SumRequestFactory : BaseFactory<ISumRequest>, ISumRequestFactory
{
    public SumRequestFactory(IResolver<ISumRequest> resolver)
        : base(resolver)
    {
    }
}