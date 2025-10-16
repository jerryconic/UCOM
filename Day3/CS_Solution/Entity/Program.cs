

/*
Entity ent1 = new Point(0, 0, 10, 10);
ent1.List();
Entity ent2 = new Line(0, 0, 10, 10, 40, 50);
ent2.List();
Entity ent3 = new Line(20, 20, 50, 60);
ent3.List();
Entity ent4 = new Line(new Point(1, 1), new Point(13, 6));
ent4.List();
*/

/*
List<Entity> lst = new List<Entity>();
lst.Add(new Point(0, 0, 10, 10));
lst.Add(new Line(0, 0, 10, 10, 40, 50));
lst.Add(new Line(20, 20, 50, 60));
lst.Add(new Line(new Point(1, 1), new Point(13, 6)));
foreach (Entity ent in lst)
    ent.List();
*/

List<Entity> lst =
[   new Point(0, 0, 10, 10),
    new Line(0, 0, 10, 10, 40, 50),
    new Line(20, 20, 50, 60),
    new Line(new Point(1, 1), new Point(13, 6)),
    new Circle(1,2,new Point(5, 5), 5)];

foreach (Entity ent in lst)
    ent.List();

public abstract class Entity
{
    protected static int entityCount = 0;
    protected int id;
    protected int color;
    protected int linetype;
    public abstract void List();

}

public abstract class Shape : Entity
{
    public abstract double Area();
}

public class Point : Entity
{
    private double x, y;
    public Point(int color, int linetype, double x, double y)
    {
        id = entityCount++;
        this.color = color;
        this.linetype = linetype;
        this.x = x;
        this.y = y;
    }
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override void List()
    {
        Console.WriteLine($"Entity Id:{id}\n  Point:\n  Color:{color}  Line Type:{linetype}\n  X={x},Y={y}");
        Console.WriteLine();
    }
    public double X
    {
        get { return x; }
    }
    public double Y
    {
        get { return y; }
    }
}

public class Line : Entity
{
    private double x1, y1, x2, y2;
    private double length;
    public Line(int color, int linetype, float x1, float y1, float x2, float y2)
    {
        id = entityCount++;
        this.color = color;
        this.linetype = linetype;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }
    public Line(int color, int linetype, Point p1, Point p2)
    {
        id = entityCount++;
        this.color = color;
        this.linetype = linetype;
        this.x1 = p1.X;
        this.y1 = p1.Y;
        this.x2 = p2.X;
        this.y2 = p2.Y;
        length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

    }
    public Line(double x1, double y1, double x2, double y2)
    {
        id = entityCount++;
        this.color = 0;
        this.linetype = 0;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }
    public Line(Point p1, Point p2)
    {
        id = entityCount++;
        this.color = 0;
        this.linetype = 0;
        this.x1 = p1.X;
        this.y1 = p1.Y;
        this.x2 = p2.X;
        this.y2 = p2.Y;
        length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

    }

    public override void List()
    {
        Console.WriteLine($"Entity Id:{id}\n  Line:\n  Color:{color}  Line Type:{linetype}");
        Console.WriteLine($"  Start Point: X={x1},Y={y1}");
        Console.WriteLine($"  End Point: X={x2},Y={y2}");
        Console.WriteLine($"  Length: {length}");
        Console.WriteLine();
    }
}
public class Circle : Shape
{
    private Point _center;
    private double _r;
    public Circle(int linetype, int color, Point center, double r)
    {
        this.color = color;
        this.linetype = linetype;
        id = entityCount++;
        _center = center;
        _r = r;
    }
    public Circle(Point center, double r)
    {
        color = 0;
        linetype = 0;
        id = entityCount++;
        _center = center;
        _r = r;
    }
    public override double Area()
    {
        return Math.PI * _r * _r;
    }

    public override void List()
    {
        Console.WriteLine($"Entity Id:{id}\n  Circle:\n  Color:{color}  Line Type:{linetype}");
        Console.WriteLine($"  Center Point: X={_center.X},Y={_center.Y}");
        Console.WriteLine($"  Radius: {_r}");
        Console.WriteLine($"  Area: {Area()}");
        Console.WriteLine();
    }
}