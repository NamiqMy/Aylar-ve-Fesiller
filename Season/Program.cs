namespace Season
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aylara gore fesilleri tap");
            string? str = Console.ReadLine();

            int nstr = Convert.ToInt32(str);

            int ay = nstr;

            string sezon = DetermineSeason(ay);
            Console.WriteLine("Sezon: " + sezon);

        }

        static string DetermineSeason(int month)
        {
            string season;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Qis";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Yaz";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Yay";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Payiz";
                    break;
                default:
                    season = "Duzgun ay daxil edin";
                    break;
            }
            return season;
        }
    }
}