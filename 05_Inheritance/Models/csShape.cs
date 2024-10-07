using System.Numerics;

namespace Models;

    abstract public class csShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

         public virtual double Area => throw new NotImplementedException();

        public static bool operator == (csShape left, csShape right) => (left.Width, left.Height) == (right.Width, right.Height);
        public static bool operator != (csShape left, csShape right) => (left.Width, left.Height) != (right.Width, right.Height);
    }

    // Triangle is derived from Shape.  
    public class csTriangle : csShape
    {
        public override double Area => Width * Height / 2;

        public override string ToString() => $"i am a {nameof(csTriangle)} with area: {Area}";

    }
    // Rectangle is derived from Shape
    public class csRectangle : csShape
    {
        public override double Area => Width * Height;
        public override string ToString() => $"i am a {nameof(csRectangle)} with area: {Area}";
    }

    public class csSquare : csRectangle{
        public new double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        public new double Height { get => base.Height; set{ base.Height = value; base.Width = value;} }

        public override string ToString() => $"i am a {nameof(csSquare)} with area: {Area}, side: {Width}";
    }

    public class csCircle: csSquare
    {
        public double Radius { get => base.Width/2; set => base.Width = value*2;}
        public override double Area => Math.PI * Radius * Radius;

        public override string ToString() => $"i am a {nameof(csCircle)} with area: {Area}, radius: {Radius}";

    }
