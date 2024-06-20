using MindBox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Shapes
{
    /// <summary>
    /// Представляет круг с определенным радиусом.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Возвращает или задает радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/> с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга. Должен быть положительным числом.</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если <paramref name="radius"/> меньше или равен нулю.</exception>        
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("The radius of a circle cannot be negative");
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
