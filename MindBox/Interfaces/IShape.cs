using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Interfaces
{
    /// <summary>
    /// Определяет методы для геометрических фигур.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double CalculateArea();
    }
}
