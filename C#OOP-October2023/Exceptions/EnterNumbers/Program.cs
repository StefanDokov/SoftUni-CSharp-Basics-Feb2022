public class StartUp
{

    static void Main()
    {
        List<int> lister = new();

        int counter = 0;
        int s = 1;
        while (counter < 10)
        {
            string inter = Console.ReadLine();

            try
            {
                Check(inter);
                counter++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        Console.WriteLine(String.Join(", ", lister));


        void Check(string input)
        {

            bool isNum = int.TryParse(input, out var num);

            if (isNum)
            {

                if (num > s && num < 100)
                {
                    lister.Add(num);
                    s = num;
                }
                else
                {

                    throw new Exception($"Your number is not in range {s} - 100!");
                }
            }
            else
            {
                throw new Exception("Invalid Number!");
            }


        }
    }

}