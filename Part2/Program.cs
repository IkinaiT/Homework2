using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Петров Иван Иванович";
            int age = 25;
            string email = "nepetya1996@gmail.com";
            float infScores = 87f, mathScores = 93f, physScores = 71f, scoresSumm, averageScores;

            Console.WriteLine($"Личная информация:\nФ.И.О.: {fullName}\nВозраст: {age}\nE-mail: {email}\nБаллы по информатике: {infScores}\nБаллы по математьке: {mathScores}\nБаллы по физике: {physScores}\n\n");

            scoresSumm = infScores + mathScores + physScores;
            averageScores = scoresSumm / 3;

            Console.WriteLine($"Подсчет баллов: \nОбщая сумма баллов: {scoresSumm: #.##}\nСредний бал: {averageScores: #.##}\n");
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
