namespace minecraft.Application.Bindables;

public class BindableLong : BindableNumber<long>
{
    public BindableLong(long defaultValue = default)
        : base(defaultValue)
    {
    }

    protected override Bindable<long> CreateInstance() => new BindableLong();
}
