namespace minecraft.Application.Bindables;

/// <summary>
/// An interface that represents a leased bindable.
/// </summary>
public interface ILeasedBindable : IBindable
{
    /// <summary>
    /// End the lease on the source <see cref="Bindable{T}"/>.
    /// </summary>
    /// <returns>
    /// Whether the lease was returned by this call. Will be <c>false</c> if already returned.
    /// </returns>
    bool Return();
}

/// <summary>
/// An interface that representes a leased bindable.
/// </summary>
/// <typeparam name="T">The value type of the bindable.</typeparam>
public interface ILeasedBindable<T> : ILeasedBindable, IBindable<T>
{
}
