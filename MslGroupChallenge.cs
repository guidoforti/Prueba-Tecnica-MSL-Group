public class MslChallenge
{



    public MslChallenge()
    {

    }



    public void CalculateFirstChallenge(int number, string word, object obj)
    {
        /// <summary>
        ///  calculates first challenge 
        ///  if the objet is a string, the method concatenates it with the string param
        /// if the objet is a integer , the method sum the objetc with the number param
        /// </summary>
        /// <param name="number" example="12"> number </param>
        /// <param name="word" example="hello"> word </param>
        /// <param name="obj" example="object"> obj </param>
        try
        {
            if (obj is int)
            {
                int numberObjetc = (int)obj;
                int result = numberObjetc + number;
                Console.WriteLine("the sum of numbers is " + result);
            }
            else if (obj is string)
            {
                string stringObjetc = (string)obj;

                Console.WriteLine("the phrase is " + stringObjetc + " " + word);

            }
            else
            {

                throw new Exception("the object has not a valid value");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void SecondMethod(Dictionary<int, string> myDictionary)
    {

        /// <summary>
        ///  the method iterates over an dictionary and evaluate if the key of
        /// the objects its a pair or an odd number . then it creates two list one 
        /// for the odd numbers and one for the pair numbers.
        /// </summary>
        /// <param name="miDictionary" > myDictionary </param>

        string pairHeader = "-----PAIR VALUES-----";
        string oddHeader = "-----ODD VALUES-----";
        List<string> listOfPairs = new List<string>();
        List<string> listOfOdds = new List<string>();

        try
        {
            foreach (var number in myDictionary)
            {

                if (number.Key % 2 == 0)
                {
                    listOfPairs.Add(number.Value);
                }
                else
                {
                    listOfOdds.Add(number.Value);
                }
            }


            printList(listOfPairs, pairHeader);

            printList(listOfOdds, oddHeader);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    private static void printList(List<string> listToPrint, string header)
    {
        Console.WriteLine(header);
        for (int i = 0; i < listToPrint.Count; i++)
        {
            Console.WriteLine(listToPrint[i]);
        }
    }
}