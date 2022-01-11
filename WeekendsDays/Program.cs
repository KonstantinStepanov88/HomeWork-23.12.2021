// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

// Если допустить, что дни недели пронумерованы с 1 до 7, тогда:
//Console.WriteLine("Введите число от 1 до 7: ");
//int number = int.Parse(Console.ReadLine());
//if ( number > 5 )
//    Console.WriteLine("Это выходной день");
//else
//    Console.WriteLine("Будний день");


int number = new Random().Next(1, 8);
Console.WriteLine("Если номер дня недели - " + number);
if ( number > 5 )
    Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Будний день");