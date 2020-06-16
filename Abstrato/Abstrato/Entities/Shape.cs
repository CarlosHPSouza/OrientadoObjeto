using Abstrato.Entities.Enums;
namespace Abstrato.Entities
{
    abstract class  Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
