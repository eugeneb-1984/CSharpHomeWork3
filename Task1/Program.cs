/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

//Принимаем число
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

// Проверяем палиндром
string CheckPalindrom(int number) {

    string PalindString = number.ToString();
    bool result = false;

    if (PalindString.Length % 2 !=0) {
        int PosLeft = 0;
        int PosRight = PalindString.Length - 1;
        bool diff = false;

        while (PosLeft != PosRight) {
            if (PalindString[PosLeft] != PalindString[PosRight]) {
                diff = true;
                break;
            }
            PosLeft ++;
            PosRight --;
        }
        if(!diff) result = true;
    }

    if (result) {
        return "Да";
    }
    else {
        return "Нет";
    }
}


int number = GetNumber("Введите число: ");
Console.WriteLine (CheckPalindrom(number));