using System;

namespace PracticalHolidayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continueProgram = true;
            while (continueProgram)
            {
                int bodrumPrice = 4000;
                int marmarisPrice = 3000;
                int cesmePrice = 5000;

                string userInput = "";
                int selectedPackagePrice = 0;
                bool isUserInputValid = false;

                while (!isUserInputValid)
                {

                    Console.WriteLine("Yol Arkadası Tatil Uygulmasına hoş geldiniz. ");

                    Console.WriteLine("Lütfen bir paket seçim yapınız: ");

                    Console.WriteLine($"1. Bodrum (Paket başlangıç fiyatı {bodrumPrice} TL)");
                    Console.WriteLine($"2. Marmaris (Paket başlangıç fiyatı {marmarisPrice} TL)");
                    Console.WriteLine($"3. Çeşme (Paket başlangıç fiyatı {cesmePrice}TL)");

                    string input = Console.ReadLine();
                    input = input.ToLower();


                    if (input == "bodrum" || input == "1")
                    {
                        userInput = "bodrum";
                        selectedPackagePrice = bodrumPrice;
                        Console.WriteLine($"Tebrikler bodrum paketi sectiniz ");
                        isUserInputValid = true;
                    }
                    else if (input == "marmaris" || input == "1")
                    {
                        userInput = "Marmaris";
                        selectedPackagePrice = marmarisPrice;
                        Console.WriteLine($"Tebrikler marmaris paketi sectiniz ");
                        isUserInputValid = true;
                    }
                    else if (input == "çeşme" || input == "1")
                    {
                        userInput = "Çeşme";
                        selectedPackagePrice = cesmePrice;
                        Console.WriteLine($"Tebrikler çeşme paketi  sectiniz fiyat : {cesmePrice}");
                        isUserInputValid = true;
                    }
                    else
                    {

                        Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyiniz.");

                    }

                }


                Console.WriteLine("----------------------------------------------------------------------------------------------");



                Console.Write("Kac kisi icin tatil planlamak istersiniz :");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("----------------------------------------------------------------------------------------------");



                Console.WriteLine($"Ozet : \nPaket seciminiz {userInput} Fiyat :{selectedPackagePrice}   \nKac kisilik : {numberOfPeople}" +
                    $"" +
                    $"Toplam fiyat : {selectedPackagePrice * numberOfPeople}");




                Console.WriteLine("----------------------------------------------------------------------------------------------");

                int highway = 1500;
                int airline = 4000;
                bool isTransportationValid = false;
                string transportation = "";
                int selectedTransportationPrice = 0;

                while (!isTransportationValid)
                {
                    Console.WriteLine("Lütfen bir ulaşım seçimi yapınız: ");
                    Console.WriteLine($"1. Kara yolu  (Kişi başı ulaşım tutarı gidiş - dönüş {highway} TL )");
                    Console.WriteLine($"2 - Hava yolu (Kişi başı ulaşım tutarı gidiş - dönüş {airline} TL)");
                    string input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "kara yolu" || input == "1")
                    {
                        transportation = "Kara yolu";
                        selectedTransportationPrice = highway;
                        Console.WriteLine($"Tebrikler kara yolu seçtiniz. Fiyat : {highway}");
                        isTransportationValid = true;
                    }
                    else if (input == "hava yolu" || input == "2")
                    {
                        transportation = "Hava yolu";
                        selectedTransportationPrice = airline;
                        Console.WriteLine($"Tebrikler hava yolu seçtiniz. Fiyat : {airline}");
                        isTransportationValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyiniz.");
                    }
                }

                Console.WriteLine("********************************************************************************");
                Console.WriteLine($"Toplam Ozet :");
                Console.WriteLine($"Paket Seciminiz : {userInput} Fiyat : {selectedPackagePrice} \nKisi sayisi : {numberOfPeople} \nGidis Turunuz : {transportation} Fiyat : {selectedTransportationPrice}\nTOTAL : {(selectedPackagePrice + selectedTransportationPrice) * numberOfPeople} ");

                Console.WriteLine("********************************************************************************");

                bool isFinish = false;
                while (!isFinish)
                {
                    Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                    string input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "e")
                    {
                        isFinish = true;
                    }
                    else if (input == "h")
                    {
                        isFinish = true;
                        continueProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyiniz.");
                    }
                }
            }

           




        }
    }
}
