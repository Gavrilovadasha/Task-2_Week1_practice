using System;

namespace ChessBishop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат ладьи и фигуры.
            Console.WriteLine("Введите координаты слона и фигуры в формате 'a1 b2':");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');

            // Проверка корректности введенных данных.
            if (coordinates.Length != 2 || !IsValidCoordinate(coordinates[0]) || !IsValidCoordinate(coordinates[1]))
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            // Получение координат ладьи и фигуры.
            char bishopColomns = coordinates[0][0];
            int bishopRows = int.Parse(coordinates[0][1].ToString());
            char figureColomns = coordinates[1][0];
            int figureRows = int.Parse(coordinates[1][1].ToString());

            // Проверка бьёт ли ладья фигуру.
            if ( Math.Abs (bishopColomns - figureColomns) == Math.Abs(bishopRows - figureRows))
            {
                Console.WriteLine("Слон сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Слон не сможет побить фигуру");
            }
        }

        // Проверка корректности координат.
        static bool IsValidCoordinate(string coordinate)
        {
            if (coordinate.Length != 2)
            {
                return false;
            }

            char colomns = coordinate[0];
            int rows = int.Parse(coordinate[1].ToString());

            return (colomns >= 'a' && colomns <= 'h') && (rows >= 1 && rows <= 8);
        }

    }
}