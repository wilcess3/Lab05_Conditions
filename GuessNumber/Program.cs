// using System.Globalization;

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное.");
// }
// else {
//     Console.WriteLine("Число ранво нулю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     Console.WriteLine("Оценка: Отлично (5)"); 
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка: Хорошо (4)");
// } else if (score >= 51) {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// } else {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }


// Console.Write("Введите  количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >=14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешен");
// }
// else if(!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с  оценками. Срочно к преподавателю");
// }

// using System.Drawing;

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" :
// "несовершеннолетний" ;
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном (°С):");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int  n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} - {parity}");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");

// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-241, каб. 1-02, 10:10");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИСРПО - 18, РМП - 10, РПМ - 0");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     case "26":
//         Console.WriteLine("Секретный пункт! (посхалко)");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт {choice} не существует. Введите число от 1 до 4.");
//         break;
// }

// Console.Write("Выберите число месяца (1-12): ");
// string month = Console.ReadLine();
// switch (month) {
//     case "12":
//     case "1":
//     case "2":
//         Console.WriteLine("Сейчас зима");
//         break;
//     case "3":
//     case "4":
//     case "5":
//         Console.WriteLine("Сейчас весна");
//         break;
//     case "6":
//     case "7":
//     case "8":
//         Console.WriteLine("Сейчас лето");
//         break;
//     case "9":
//     case "10":
//     case "11":
//         Console.WriteLine("Сейчас осень");
//         break;
//     default:
//         Console.WriteLine($"Некорректный ввод: {month}. Введите число от 1 до 12");
//         break;
// }

// Random random = new Random();
// int secret = random.Next(1, 101);
// int attempts = 0;
// bool guessed = false;
// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");
// string GetHint(int difference) {
//     switch (difference) {
//         case <= 3:
//             return "🔥 Горячо!";
//         case <= 10:
//             return "♨ Тепло.";
//         case <= 25:
//             return "💧 Прохладно.";
//         default:
//             return "❄ Холодно!";
//     }
// }
// while (!guessed) {
//     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();

//     if (!int.TryParse(input, out int guess)) {
//         Console.WriteLine("❗❗ Введи целое число, а не текст!");
//         continue;
//     }
    
//     if (guess < 1 || guess > 100) {
//         Console.WriteLine("❗❗ Число должно быть от 1 до 100!");
//         continue;
//     }
//     attempts++;
//     if (guess < secret) {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше! {hint}\n");
//     }
//     else if (guess > secret) {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше! {hint}\n");
//     }
//     else {
//         guessed = true; // угадал!
//     }
// }
// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";
// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");

// Задание 1
// Console.Write("Введите пароль: ");
// string password = Console.ReadLine();
// Console.Write("Подтвердите пароль: ");
// string confirm = Console.ReadLine();
// if (password == confirm)
//     Console.WriteLine("Пароль принят");
// else
//     Console.WriteLine("Пароль не принят");


//Задание 2
// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());
// if (age >= 18)
//     Console.WriteLine("Доступ разрешён");
// else
//     Console.WriteLine("Доступ запрещён");


//Задание 3
// Console.Write("Введите первое число: ");
// double a = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double b = double.Parse(Console.ReadLine());

// Console.Write("Введите операцию (+, -, *, /): ");
// string operation = Console.ReadLine();

// switch (operation)
// {
//     case "+":
//         Console.WriteLine($"{a} + {b} = {a + b}");
//         break;
//     case "-":
//         Console.WriteLine($"{a} - {b} = {a - b}");
//         break;
//     case "*":
//         Console.WriteLine($"{a} * {b} = {a * b}");
//         break;
//     case "/":
//         if (b == 0)
//             Console.WriteLine("Ошибка: деление на ноль!");
//         else
//             Console.WriteLine($"{a} / {b} = {a / b}");
//         break;
//     default:
//         Console.WriteLine("Неизвестная операция");
//         break;
// }



//Задание 4
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine());
// int sum = 0;
// if (a > 0) sum += a;
// if (b > 0) sum += b;
// if (c > 0) sum += c;
// Console.WriteLine($"Сумма положительных чисел: {sum}");


//Задание 5
Console.Write("Ваш выбор (A/B): ");
string vibor = Console.ReadLine();
switch (vibor)
{
    case "A":
        Console.WriteLine("Дракон говорит:");
        Console.WriteLine("Кто не дышит, но живёт;");
        Console.WriteLine(" хоть не нужно — много пьёт;");
        Console.WriteLine(" и в жизни, и в смерти тело как лёд.\"");
        Console.Write("Ваш ответ: ");
        string otvet = Console.ReadLine().ToLower();

        if (otvet == "рыба")
        {
            Console.WriteLine("\nДракон открывает дверь в следующую комнату");
            Console.WriteLine("Вы нашли сокровища Dungeon Master'а!");
        }
        else
        {
            Console.WriteLine("Дракон вас съел! Игра окончена");
        }
        break;

    case "B":
        Console.WriteLine("Перед вами две двери: 1 и 2");
        Console.Write("Выберите дверь (1/2): ");
        string door = Console.ReadLine();

        switch (door)
        {
            case "1":
                Console.WriteLine("За дверью — сокровища Dungeon Master'а!");
                break;
            case "2":
                Console.WriteLine("Ловушка! Ядовитые шипы. Игра окончена");
                break;
            default:
                Console.WriteLine("Такой двери нет");
                break;
        }
        break;

    default:
        Console.WriteLine("Неверный выбор");
        break;
}