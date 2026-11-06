class Program
{
    static void Main()
    {
        int[] tablica = { 2, 4, 3, 2, 4, 2, 2, 5, 3, 4, 2 };
        Dictionary<int, int> wystapienia = new Dictionary<int, int>();
        foreach (int element in tablica) {
            //sprawdz czy jest juz element

        //przejsc po elementach tablicy
            if (wystapienia.ContainsKey(element))
            {
                //jezeli tak dodac 1
                wystapienia[element]++;
            }
            else
            {
                // jezeli nie => dopisac
                wystapienia[element] = 1;
            }
        }

        var posortowane = wystapienia.OrderByDescending(e => e.Value).ToDictionary<int, int>();
       
        Console.WriteLine(posortowane.ElementAt(0).Key);

        WypiszDictionary(posortowane);
    }

    static void WypiszDictionary(Dictionary<int, int> dict) {
        foreach(int key in dict.Keys)
        {
            Console.WriteLine($"{key} => {dict[key]}");
        }
    }
}