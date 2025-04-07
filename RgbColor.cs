public class RgbColor : TripleNumbers
{
    public RgbColor(int r, int g, int b) : base(r, g, b) { }

    public RgbColor(RgbColor source) : base(source) { }

    public string ToHex()
    {
        return $"#{_a:X2}{_b:X2}{_c:X2}";
    }

    public RgbColor MixWith(RgbColor other)
    {
        return new RgbColor(
            (_a + other._a) / 2,
            (_b + other._b) / 2,
            (_c + other._c) / 2
        );
    }

    public override string ToString()
    {
        return $"R = {_a}, G = {_b}, B = {_c}";
    }
}