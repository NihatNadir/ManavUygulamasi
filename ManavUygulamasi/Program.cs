using System;
using System.ComponentModel.Design;
namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoşgeldiniz!");

            string[] fruits = { "Elma", "Armut", "Çilek", "Muz", "Diğer" }; // Meyveleri dizi içerisine aktarıldı
            int[] prices = { 2, 3, 2, 3, 4 }; // Fiyatlar dizi içerisine aktarıldı
            string text = string.Join(",", fruits); // text değişkenine meyvelerin arasına virgül konmasını ve birbiri ile toplanması atandı

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{fruits[i]} = {prices[i]} TL");
                fruits[i] = fruits[i].ToLower();
            }
            Console.Write($"\nHangi meyveyi satın almak istersiniz? ({text}) : ");

            string selectedFruit = Console.ReadLine().ToLower(); // Kullanıcıdan alınan meyve küçük harfe dönüştürüldü

            // Switch ile yapılışı

            switch (selectedFruit) // Kullanıcıdan alınan meyveye göre fiyatlandırması
            {
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[0]} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[1]} TL");
                    break;
                case "çilek":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[2]} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[3]} TL");
                    break;
                default:
                    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[4]} TL");
                    break;
            }

            // If ile yapılışı 

            if (selectedFruit == fruits[0]) // Kullanıcıdan alınan meyveye göre fiyatlandırması
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[0]} TL");
            else if (selectedFruit == fruits[1])
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[1]} TL");
            else if (selectedFruit == fruits[2])
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[2]} TL");
            else if (selectedFruit == fruits[3])
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[3]} TL");
            else
                Console.WriteLine($"Seçtiğiniz meyvenin fiyatı : {prices[4]} TL");
        }

        // Bu örnekte if kullanmak daha avantajlı gibi kodun kısalığı açısından if avantajlı gibi
    }
}