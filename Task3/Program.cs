/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
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

// выводим в консоль кубы от 1 до N:

void CalcPow3(int target) {
    string output = $"{target} -> ";
    int index = 1;
        while (index < target) {
        output += $"{Math.Pow(index, 3)}, ";
        index++;
    }
    output += $"{Math.Pow(index, 3)}";
    Console.WriteLine(output);
}

int userNumber = GetNumber("Введите число: ");
CalcPow3(userNumber);