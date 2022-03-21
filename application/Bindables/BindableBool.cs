namespace minecraft.Application.Bindables;

public class BindableBool : Bindable<bool>
{
    public BindableBool(bool value = false)
        : base(value)
    {
    }

    public override string ToString() => Value.ToString();

    public override void Parse(object input)
    {
        if (input is "1")
            Value = true;
        else if (input is "0")
            Value = false;
        else
            base.Parse(input);
    }

    public void Toggle() => Value = !Value;

    protected override Bindable<bool> CreateInstance() => new BindableBool();
}
