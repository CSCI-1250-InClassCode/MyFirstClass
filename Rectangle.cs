public class Rectangle
{
    private int length;
    private int width;

    public Rectangle()
    {
        this.length = 5;
        this.width = 5;
    }
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public Rectangle(double length, double width)
    {
        this.length = (int)Math.Floor(length);
        this.width = (int)Math.Floor(width);
    }

    public Rectangle(string length, string width)
    {
        this.length = int.Parse(length);
        this.width = int.Parse(width);
    }


    public void SetWidth(int width)
    {
        this.width = width;
    }

    public void SetLength(int l)
    {
        length = l;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetLength()
    {
        return length;
    }

    public int Area()
    {
        return length * width;
    }

    public void AddToLength(int l)
    {
        length += l;
    }

       public void AddToLength(double l)
    {
        length += (int)l;
    }


    public void AddToWidth(int w)
    {
        width += w;
    }

}