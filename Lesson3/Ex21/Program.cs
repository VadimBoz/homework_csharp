// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] point1 = new int[3];
int[] point2 = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"Веедите координату {i + 1} первой точки: ");
    point1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    Console.Write($"Веедите координату {i + 1} второй точки: ");
    point2[i] = Convert.ToInt32(Console.ReadLine());
}

double Distanse(int[] point1_loc, int[] point2_loc) // определяем расстояние между точками
{
    return Math.Sqrt((point1_loc[0] - point2_loc[0]) * (point1_loc[0] - point2_loc[0]) +
    (point1_loc[1] - point2_loc[1]) * (point1_loc[1] - point2_loc[1]) +
    (point1_loc[2] - point2_loc[2]) * (point1_loc[2] - point2_loc[2]));

} //---------------------------------------------------------------------------------------

double distanse = Math.Round(Distanse(point1, point2), 2);
Console.WriteLine();
Console.WriteLine($"координаты первой точки [{point1[0]}, {point1[1]}, {point1[2]}]");
Console.WriteLine($"координаты второй точки [{point2[0]}, {point2[1]}, {point2[2]}]");
Console.WriteLine($"расстояние меджу точками: {distanse}");