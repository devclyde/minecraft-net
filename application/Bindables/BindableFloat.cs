using System.Globalization;

namespace minecraft.Application.Bindables;

public class BindableFloat : BindableNumber<float>
{
    public BindableFloat(float defaultValue = 0)
        : base(defaultValue)
    {
    }

    public override string ToString() => Value.ToString("0.0###", NumberFormatInfo.InvariantInfo);

    protected override Bindable<float> CreateInstance() => new BindableFloat();
}
