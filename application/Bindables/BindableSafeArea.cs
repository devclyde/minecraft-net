using minecraft.Application.Graphics;

namespace minecraft.Application.Bindables;

/// <summary>
/// A subclass of <see cref="Bindable{MarginPadding}"/> specifically for representing the "safe areas" of a device.
/// It exists to prevent regular <see cref="MarginPadding"/>s from being globally cached.
/// </summary>
public class BindableSafeArea : Bindable<MarginPadding>
{
    public BindableSafeArea(MarginPadding value = default)
        : base(value)
    {
    }

    protected override Bindable<MarginPadding> CreateInstance() => new BindableSafeArea();
}

