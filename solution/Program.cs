using System;

class Program
{
    static void Main(string[] args)
    {
        int remainingAttempts = 5;

        try
        {
            Console.Write("Platonun sağ üst koordinatlarını girin : ");
            string[] boundaries = Console.ReadLine().Split(' ');
            int platoX = int.Parse(boundaries[0]);
            int platoY = int.Parse(boundaries[1]);

            while (remainingAttempts > 0)
            {
                Console.WriteLine("Şimdi Rover bilgilerini girin Çıkmak için 'E' tuşuna basınız.");
                string input = Console.ReadLine();

                if (input.ToLower() == "e")
                    break;

                string[] roverInfo = input.Split(' ');
                if (roverInfo.Length != 3)
                {
                    Console.WriteLine("Geçersiz rover bilgisi, Tekrar deneyin.");
                    continue;
                }

                int roverX = int.Parse(roverInfo[0]);
                int roverY = int.Parse(roverInfo[1]);
                char roverMoveInfo = char.Parse(roverInfo[2].ToUpper());

                Console.Write("Rover komutlarını (örn:LMLMLMLMM) giriniz : ");
                string commands = Console.ReadLine();

                RoverManager.MoveRover(ref roverX, ref roverY, ref roverMoveInfo, platoX, platoY, commands);

                // Son konum bilgisi
                Console.WriteLine($"Son pozisyon: {roverX} {roverY} {roverMoveInfo}");

                remainingAttempts--;

                Console.WriteLine($"Kalan Hareket Hakkınız: {remainingAttempts} ");
            }

            if (remainingAttempts == 0)
            {
                Console.WriteLine("Hakkınız bitti!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ana Hata: {ex.Message}");
        }
    }

    // Diğer yardımcı methodları da RoverManager sınıfına taşıyabilirsiniz.
}
