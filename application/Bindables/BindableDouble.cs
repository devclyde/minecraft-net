using System.Globalization;

namespace minecraft.Application.Bindables;

public class BindableDouble : BindableNumber<double>
{
    public BindableDouble(double defaultValue = 0)
        : base(defaultValue)
    {
    }

    public override string ToString() => Value.ToString("0.0###", NumberFormatInfo.InvariantInfo);

    protected override Bindable<double> CreateInstance() => new BindableDouble();
}
