using System.Globalization;

namespace minecraft.Application.Bindables;

public class BindableInt : BindableNumber<int>
{
    public BindableInt(int defaultValue = 0)
        : base(defaultValue)
    {
    }

    public override string ToString() => Value.ToString(NumberFormatInfo.InvariantInfo);

    protected override Bindable<int> CreateInstance() => new BindableInt();
}
