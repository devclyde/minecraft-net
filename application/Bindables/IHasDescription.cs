namespace minecraft.Application.Bindables;

/// <summary>
/// Interface for objects that have a description.
/// </summary>
public interface IHasDescription
{
    /// <summary>
    /// The description for this object.
    /// </summary>
    string Description { get; }
}
