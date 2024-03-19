

using System;
using System.ComponentModel;
class PruebaTencnicaMSLGroup
{
    static void Main(String[] args)
    {

        MslChallenge methodClass = new MslChallenge();
        // SETEO LAS CONDICIONES DE LA PREGUNTA UNO 
        int number = 10;
        string word = "prueba";
        object objectNumber = 40;
        object objectString = "pruebaObjeto";
        object wrongObject = 3.2;

        // SETEO LAS CONDICIONES DE LA PREGUNTA DOS 
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        // LLAMO AL PUNTO UNO

        try
        {

            methodClass.CalculateFirstChallenge(number, word, objectNumber);
            methodClass.CalculateFirstChallenge(number, word, objectString);
            methodClass.CalculateFirstChallenge(number, word, wrongObject);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



        try
        {
            // LLAMO AL PUNTO 2

            myDictionary.Add(1, "ONE");
            myDictionary.Add(2, "TWO");
            myDictionary.Add(3, "THREE");
            myDictionary.Add(4, "FOUR");
            myDictionary.Add(5, "FIVE");
            myDictionary.Add(6, "SIX");
            myDictionary.Add(7, "SEVEN");
            myDictionary.Add(8, "EIGHT");
            myDictionary.Add(9, "NINE");
            myDictionary.Add(10, "TEN");

            methodClass.SecondMethod(myDictionary);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



    }



}

