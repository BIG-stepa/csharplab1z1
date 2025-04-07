public class TripleNumbers
{
    protected readonly int _a;
    protected readonly int _b;
    protected readonly int _c;

    public TripleNumbers(int a, int b, int c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public TripleNumbers(TripleNumbers source) : this(source._a, source._b, source._c) { }

    public int GetProduct()
    {
        return _a * _b * _c;
    }

    public override string ToString()
    {
        return $"A = {_a}, B = {_b}, C = {_c}";
    }
}