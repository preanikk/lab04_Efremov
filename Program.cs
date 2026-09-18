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


int age = 16;
double height = 1.4;
bool soprovod = true;
if (age >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
} else if (age >= 14 && height < 1.5 && soprovod)
{
    Console.WriteLine("Можно кататься");
} else
{
    Console.WriteLine("Пока нельзя");
}


