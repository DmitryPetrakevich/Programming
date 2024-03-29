﻿using System;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Обработка коллизии фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Метод, проверяющий коллизию двух прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются, false в противном случае.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double widthDifference = Math.Abs(rectangle1.Width + rectangle2.Width) / 2.0;
            double lengthDifference = Math.Abs(rectangle1.Height + rectangle2.Height) / 2.0;

            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                rectangle1.Height + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        /// <summary>
        /// Метод, проверяющий коллизию кругов.
        /// </summary>
        /// <param name="ring1">Первый круг.</param>
        /// <param name="ring2">Второй круг.</param>
        /// <returns>Возвращает true, если круги пересекаются, false  в противном случае.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
