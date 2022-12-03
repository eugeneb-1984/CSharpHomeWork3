/*

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

// принимаем число
int GetNumber(string message) {
    bool isNumber = false;
    int Number = 0;
    while(!isNumber) {
        Console.Write(message);
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out Number)) {
            isNumber = true;
        }
        else {
            Console.WriteLine("Вы ошиблись при вводе. Введите число.");
        }
    }
    return Number;
}

double CalcDistance(int [] Point1, int [] Point2) {
    double distX = Math.Pow((Point2[0] - Point1[0]), 2); //6^2 = 36
    double distY = Math.Pow((Point2[1] - Point1[1]), 2); //8^2 = 64
    double distZ = Math.Pow((Point2[2] - Point1[2]), 2); //10^2 = 100

    double result = Math.Sqrt(distX + distY + distZ); // 

    return result;
}

int [] Point1 = new int [3];
int [] Point2 = new int [3];

Point1[0] = GetNumber("Введите X для точки 1: ");
Point1[1] = GetNumber("Введите Y для точки 1: ");
Point1[2] = GetNumber("Введите Z для точки 1: ");

Point2[0] = GetNumber("Введите X для точки 2: ");
Point2[1] = GetNumber("Введите Y для точки 2: ");
Point2[2] = GetNumber("Введите Z для точки 2: ");

double Dist = CalcDistance(Point1, Point2);

Console.WriteLine($"Расстояние между точками: {Dist}");