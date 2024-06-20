using MindBox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Shapes
{
    /// <summary>
    /// Представляет треугольник с заданными длинами сторон.
    /// </summary>
    public class Triangle : IShape, ICanHaveRightAngle
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Сторона B
        /// </summary>        
        public double SideB { get; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Возвращает значение, указывающее, является ли треугольник прямоугольным или нет.
        /// </summary>
        public bool IsRightTriangle => CheckHaveRightAngle();

        /// <summary>
        /// Конструктор инициализирует новый экземпляр класса <see cref="Triangle"/> с заданными длинами сторон.
        /// </summary>
        /// <param name="a">Длина стороны A должна быть положительным числом.</param>
        /// <param name="b">Длина стороны B должна быть положительным числом.</param>
        /// <param name="c">Длина стороны C должна быть положительным числом.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Выбрасывается, если <paramref name="a"/>, <paramref name="b"/> или <paramref name="c"/> меньше или равны нулю, 
        /// или если сумма длин любых двух сторон не больше длины третьей стороны.
        /// </exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Side lengths must be positive numbers");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("The sum of the lengths of any two sides must be greater than the length of the third side.");
            }

            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Вычисляет площадь треугольника с использованием формулы Герона.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double CalculateArea()
        {
            double semiperimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return area;
        }

        /// <summary>
        /// Определяет, имеет ли фигура прямой угол.
        /// </summary>
        /// <returns>
        /// <c>true</c> если фигура имеет прямой угол, поэтому треугольник является прямоугольным; в противном случае <c>false</c>.
        /// </returns>
        public bool CheckHaveRightAngle()
        {
            return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2) || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2) || Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
        }
    }
}
