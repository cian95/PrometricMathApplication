using System;

namespace PrometricMathApplication
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public abstract Double Perimiter();
        public abstract Double SurfaceArea();

        public abstract String ToJSON();

    }
}
