using CarpeDiem.DataTools.Calculator.Responses;
using CarpeDiem.DataTools.Common.Factories;
using CarpeDiem.DataTools.Common.Resolvers;

namespace CarpeDiem.DataTools.Calculator.Factories;

public class SumResponseFactory : BaseFactory<ISumResponse>, ISumResponseFactory
{
    public SumResponseFactory(IResolver<ISumResponse> resolver)
        : base(resolver)
    {
    }
}