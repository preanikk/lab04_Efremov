// int age = 15;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");


// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешен");
// } else {
//     Console.WriteLine("Доступ запрещен");
//     Console.WriteLine($"До совершеннолетия осталось: {18 - age} года");
// }


// int age = 67;
// if (age < 13)
// {
//     Console.WriteLine("Ребенок");
// } else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// } else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// } else
// {
//     Console.WriteLine("Пенсионер");
// }


// int age = 16;
// double height = 1.4;
// bool soprovod = true;
// if (age >= 14 && height >= 1.5)
// {
//     Console.WriteLine("Можно кататься");
// } else if (age >= 14 && height < 1.5 && soprovod)
// {
//     Console.WriteLine("Можно кататься");
// } else
// {
//     Console.WriteLine("Пока нельзя");
// }


// //    Задача Б

// Console.Write("Введите оценку: ");
// int ocenka = int.Parse(Console.ReadLine());
// switch (ocenka) 
// {
//     case 5:
//         Console.WriteLine("Отлично");
//         break;
//     case 4:
//         Console.WriteLine("Хорошо");
//         break;
//     case 3:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case 2:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     default:
//         Console.WriteLine("Неверная оценка");
//         break;
// }


// //    Задача Г

// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine());
// if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//     Console.WriteLine("Год високосный");
// else
//     Console.WriteLine("Год не високосный");


// //    Вариант 1


// Console.Write("Введите целое число: ");
// int num = int.Parse(Console.ReadLine());
// if (num < 0) {
//     Console.WriteLine("Отрицательное");
// } else if (num > 0) {
//     Console.WriteLine("Положительное");
// } else {
//     Console.WriteLine("Ноль");
// }


// Вариант 6


Console.Write("Введите количество баллов: ");
int ocenka = int.Parse(Console.ReadLine());
if ( 90 <= ocenka && ocenka <= 100 ) {
    Console.WriteLine("Отлично");
}else if ( 75 <= ocenka && ocenka <= 89 ) {
    Console.WriteLine("Хорошо");
}else if ( 60 <= ocenka && ocenka <= 74 ) {
    Console.WriteLine("Удовлетворительно");
}else if ( 0 <= ocenka && ocenka <= 59 ) {
    Console.WriteLine("Неудовлетворительно");
}else {
    Console.WriteLine("Неверное значение");
}