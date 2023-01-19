using System.Reflection;

namespace CarpeDiem.DataTools.Common.Resolvers;

public class Resolver<T> : IResolver<T>
    where T : notnull
{
    private readonly ILifetimeScope lifetimeScope;
    private readonly Lazy<List<Tuple<string, Type>>> namesAndTypes;

    public Resolver(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
        namesAndTypes = new Lazy<List<Tuple<string, Type>>>
        (
            () =>
            {
                var containerRegistration = lifetimeScope.ComponentRegistry.Registrations
                    .Single
                    (
                        r =>
                            r.Services.OfType<IServiceWithType>().Any(s => s.ServiceType == typeof(T))
                    );

                var namesAndTypesDictionary = new List<Tuple<string, Type>>();

                var constructors = containerRegistration.Activator.LimitType.GetConstructors(BindingFlags.Instance | BindingFlags.Public);

                var constructor = constructors[0];

                foreach (var parameter in constructor.GetParameters())
                {
                    namesAndTypesDictionary.Add(Tuple.Create(parameter.Name!, parameter.ParameterType));
                }

                return namesAndTypesDictionary;
            }
        );
    }

    public T Resolve()
        => lifetimeScope.Resolve<T>();

    public T Resolve(params object[] arguments)
    {
        var parameters = new List<NamedParameter>();

        for (int index = 0; index < namesAndTypes.Value.Count; index++)
        {
            NamedParameter namedParameter;

            if (index < arguments.Length)
            {
                namedParameter = new NamedParameter
                (
                    namesAndTypes.Value[index].Item1,
                    arguments[index]
                );
            }
            else
            {
                namedParameter = new NamedParameter
                (
                    namesAndTypes.Value[index].Item1,
                    lifetimeScope.Resolve(namesAndTypes.Value[index].Item2)
                );
            }

            parameters.Add(namedParameter);
        }

        return lifetimeScope.Resolve<T>(parameters);
    }
}