using System.Globalization;
using minecraft.Application.Graphics;

namespace minecraft.Application.Bindables;

public class BindableMarginPadding : RangeConstrainedBindable<MarginPadding>
{
    protected override MarginPadding DefaultMinValue => new(float.MinValue);
    protected override MarginPadding DefaultMaxValue => new(float.MaxValue);

    public BindableMarginPadding(MarginPadding defaultValue = default)
        : base(defaultValue)
    {
    }

    public override string ToString() => Value.ToString();

    public override void Parse(object input)
    {
        switch (input)
        {
            case string str:
                string[] split = str.Trim("() ".ToCharArray()).Split(',');

                if (split.Length != 4)
                    throw new ArgumentException($"Input string was in wrong format! (expected: '(<top>, <left>, <bottom>, <right>)', actual: '{str}')");

                Value = new MarginPadding
                {
                    Top = float.Parse(split[0], CultureInfo.InvariantCulture),
                    Left = float.Parse(split[1], CultureInfo.InvariantCulture),
                    Bottom = float.Parse(split[2], CultureInfo.InvariantCulture),
                    Right = float.Parse(split[3], CultureInfo.InvariantCulture),
                };
                break;

            default:
                base.Parse(input);
                break;
        }
    }

    protected sealed override MarginPadding ClampValue(MarginPadding value, MarginPadding minValue, MarginPadding maxValue)
    {
        return new MarginPadding
        {
            Top = Math.Clamp(value.Top, minValue.Top, maxValue.Top),
            Left = Math.Clamp(value.Left, minValue.Left, maxValue.Left),
            Bottom = Math.Clamp(value.Bottom, minValue.Bottom, maxValue.Bottom),
            Right = Math.Clamp(value.Right, minValue.Right, maxValue.Right)
        };
    }

    protected sealed override bool IsValidRange(MarginPadding min, MarginPadding max)
    {
        return min.Top <= max.Top &&
               min.Left <= max.Left &&
               min.Bottom <= max.Bottom &&
               min.Right <= max.Right;
    }

    protected override Bindable<MarginPadding> CreateInstance() => new BindableMarginPadding();
}
