namespace minecraft.Application.Lists;

public class FuncEqualityComparer<T> : IEqualityComparer<T>
{
    private readonly Func<T, T, bool> func;

    public FuncEqualityComparer(Func<T, T, bool> func)
    {
        this.func = func ?? throw new ArgumentNullException(nameof(func));
    }

    public bool Equals(T x, T y) => func(x!, y!);

    public int GetHashCode(T obj) => obj!.GetHashCode();
}

