using OpenTK.Mathematics;

namespace minecraft.Application.Graphics;

public struct MarginPadding
{
    public float Top;

    public float Left;

    public float Bottom;

    public float Right;

    public readonly float TotalHorizontal => Left + Right;

    /// <summary>
    /// Sets the values of both <see cref="Left"/> and <see cref="Right"/> to the assigned value.
    /// </summary>
    public float Horizontal
    {
        set => Left = Right = value;
    }

    public readonly float TotalVertical => Top + Bottom;

    public float Vertical
    {
        set => Top = Bottom = value;
    }

    public readonly Vector2 Total => new(TotalHorizontal, TotalVertical);

    public MarginPadding(float allSides)
    {
        Top = Left = Bottom = Right = allSides;
    }

    public readonly bool Equals(MarginPadding other) => Top == other.Top && Left == other.Left && Bottom == other.Bottom && Right == other.Right;

    public override readonly string ToString() => $@"({Top}, {Left}, {Bottom}, {Right})";

    public static MarginPadding operator -(MarginPadding mp) =>
        new()
        {
            Left = -mp.Left,
            Top = -mp.Top,
            Right = -mp.Right,
            Bottom = -mp.Bottom,
         };
}
