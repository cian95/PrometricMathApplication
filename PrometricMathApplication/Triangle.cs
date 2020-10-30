using System;
using System.Text;

namespace PrometricMathApplication
{
    public class Triangle : Shape
    {
        public Double A { get; set; }
        public Double B { get; set; }
        public Double C { get; set; }
        public Double Height { get; set; }
        public Double Base { get; set; }

        public override double Perimiter() => A + B + C;

        public override double SurfaceArea() => Height * Base / 2;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"A\": " + A + ",");
            sb.Append("\"B\": " + B + ",");
            sb.Append("\"C\": " + C + ",");
            sb.Append("\"Height\": " + Height + ",");
            sb.Append("\"Base\": " + Base);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString()
        {
           return $"TRIANGLE: A = {A}, B = {B}, C + {C}, Height = {Height}, Base = {Base}";
        }
    }
}
