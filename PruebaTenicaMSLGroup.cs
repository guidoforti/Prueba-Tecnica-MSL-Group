// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
class PruebaTencnicaMSLGroup
 {
static void Main (String[] args)
{

/*------------------------------------------SETEO LAS CONDICIONES DE LA PREGUNTA UNO ----------------------------------*/
int number = 10;
string word = "prueba";
object objectNumber = 40;
object objectString = "pruebaObjeto";
object wrongObject = new object();

try 
{
functionOne (number , word, objectNumber);

functionOne (number , word, objectString);

functionOne (number , word, wrongObject);
}
catch (Exception e)
 {
    Console.WriteLine(e.Message);
 } 


/*------------------------------------------SETEO LAS CONDICIONES DE LA PREGUNTA DOS ----------------------------------*/
Dictionary <int , string> myDictionary = new Dictionary<int, string>();
List<string> pair = new List<string>();
List<string> odd = new List<string>();


myDictionary.Add(1 , "ONE");
myDictionary.Add(2, "TWO");
myDictionary.Add(3 , "THREE");
myDictionary.Add(4, "FOUR");
myDictionary.Add(5 , "FIVE");
myDictionary.Add(6, "SIX");
myDictionary.Add(7 , "SEVEN");
myDictionary.Add(8, "EIGHT");
myDictionary.Add(9 , "NINE");
myDictionary.Add(10, "TEN");



Console.WriteLine("-----PAIR VALUES-----");
functionTwo(myDictionary , odd, pair);

for (int i = 0 ; i < pair.Count ; i ++)
{
    Console.WriteLine(pair[i]);
}

Console.WriteLine("-----ODD VALUES-----");
for (int i = 0 ; i < odd.Count ; i ++)
{
    Console.WriteLine(odd[i]);
}
}

/*------------------------------------------FUNCION DE LA PREGUNTA UNO ----------------------------------*/
static void functionOne (int number, string word , object obj )   {

try {
if (obj is int) 
{
 int numberObjetc = (int)obj;
 int result = numberObjetc + number;
   Console.WriteLine("the sum of numbers is " + result);
}
else if (obj is string) 
{
    string stringObjetc = (string) obj;

    Console.WriteLine("the phares is " + stringObjetc + " " + word);

}
else {

    throw new Exception ("the object has not a valid value");
}

}
catch (Exception e) {
    Console.WriteLine(e.Message);
}
} 

/*------------------------------------------FUNCION DE LA PREGUNTA DOS ----------------------------------*/

static void functionTwo (Dictionary <int, string> myDictionary , List<string> odd , List<string> pair) 
{


foreach (var number in myDictionary) {

    if (number.Key % 2 == 0 )
    {
        pair.Add(number.Value);
    }
    else
    {
        odd.Add(number.Value);
    }
}


}
 }