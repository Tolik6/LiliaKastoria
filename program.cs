using System;

namespace LiliaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello frприветom Lilia!");
            Console.WriteLine("Это новый проект");
            
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            try
            {
                PrintGreeting(name);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Будет использовано имя по умолчанию.");
                PrintGreeting("Гость");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
            }
        }
        
        static void PrintGreeting(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }
            
            if (name.Length < 2)
            {
                throw new ArgumentException("Имя должно содержать хотя бы 2 символа");
            }
            
            Console.WriteLine($"Привет, {name}! Добро пожаловать в проект LiliaKastoria!");
        }
    }
}
