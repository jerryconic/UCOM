Cube c1 = new Cube(3, 4, 5);
Cube c2 = new Cube(6);
Console.WriteLine(c1);
Console.WriteLine(c2);
//Everything is object


//override(覆載) vs overload(多載)
public class Cube
{
    private double _length, _width, _height;

    /// <summary>
    /// 立方體
    /// </summary>
    /// <param name="length">長</param>
    /// <param name="width">寬</param>
    /// <param name="height">高</param>
    public Cube(double length, double width, double height)
    {
        _length = length;
        _width = width;
        _height = height;
    }
    public Cube(double length)
    {
        _length = length;
        _width = length;
        _height = length;
    }


    /// <summary>
    /// 體積
    /// </summary>
    /// <returns></returns>
    public double Volume()
    {
        return _length * _width * _height;
    }
    /// <summary>
    /// 表面積
    /// </summary>
    /// <returns></returns>
    public double Area()
    {
        return 2 * (_length * _width + _length * _height + _width * _height);
    }

    public override string ToString()
    {
        return $"Cube:({_length},{_width},{_height}), Area={Area()}, Volume={Volume()}";
    }
}