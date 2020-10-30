using System;
using System.Text;

namespace PrometricMathApplication
{
    public class Circle : Shape
    {
        public Double Radius { get; set; }
        public override Double SurfaceArea() => Math.PI * Radius * Radius;
        public override double Perimiter() => 2 * Math.PI * Radius;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"radius\": " + Radius);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString() => $"CIRCLE: Radius = {Radius}";
        
    }
}
