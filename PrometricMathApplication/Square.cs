using System;
using System.Text;

namespace PrometricMathApplication
{
    public class Square : Shape
    {
        public Double Height { get; set; }
        public Double Width { get; set; }
        public Double Length { get; set; }

        public override Double SurfaceArea() => Height * Width;
        public override Double Perimiter() => (Width + Length) * 2;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"Height\": " + Height + ",");
            sb.Append("\"Width\": " + Width + ",");
            sb.Append("\"Length\": " + Length);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString() => $"SQUARE: Height = {Height}, Width {Width}, Length {Length}";
    }
}
