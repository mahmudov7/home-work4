class Circle
{
    private double radius;
    private double pi = 3.14;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle()
    {
        radius = 0;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return pi * radius * radius;
    }

    public double GetDiameter()
    {
        return 2 * radius;
    }

    public double GetCircumference()
    {
        return 2 * pi * radius;
    }
}