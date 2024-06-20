using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Interfaces
{
    /// <summary>
    /// Интерфейс для определения наличия прямого угла в геометрической фигуре.
    /// </summary>
    public interface ICanHaveRightAngle
    {
        /// <summary>
        /// Проверяет, содержит ли геометрическая фигура прямой угол.
        /// Этот метод может быть переиспользован для различных фигур, например, для прямоугольной трапеции.
        /// </summary>
        /// <returns>Возвращает <c>true</c>, если фигура содержит прямой угол; в противном случае <c>false</c>.</returns>
        bool CheckHaveRightAngle();

    }
}
