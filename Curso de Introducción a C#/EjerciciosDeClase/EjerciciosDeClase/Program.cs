// See https://aka.ms/new-console-template for more information

//-->>>>>> //////// Print ////////////

Console.WriteLine("\n************ Print ************");

Console.WriteLine("Hello, World!");



//-->>>>>> ////////////////////// READ user entry  ////////////////////////

Console.WriteLine("\n************ READ user entry ************");

Console.WriteLine("What's your name? Please Write your full name");
string fullUserName = Console.ReadLine();

Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi");



//-->>>>>> ////////////////////// Operators. ////////////////////////////////////

Console.WriteLine("\n************ OPERATORS ************");

int number1;
int number2;

Console.WriteLine("Input the first number:");

// CAST explicit
number1 = Convert.ToInt32(Console.ReadLine());
//Another way to cast
//number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
number2 = Convert.ToInt32(Console.ReadLine()); 

int result = number1 * number2;
Console.WriteLine(number1 + " * " + number2 + " " + "The Result Is: " + result);



//-->>>>>> ///////// Logic Operators - Modifique algunas cosas ///////////

Console.WriteLine("\n************ Logic Operators ************");

bool valueLogicOperators1 = true;
bool valueLogicOperators2 = true;
bool valueLogicOperators3 = false;

        // && , ||, !

bool resultLogicOperators = valueLogicOperators1 && valueLogicOperators2 && valueLogicOperators3;
Console.WriteLine($"{valueLogicOperators1} and {valueLogicOperators2} and {valueLogicOperators3}: {resultLogicOperators}");

bool resultLogicOperators_2 = valueLogicOperators1 || valueLogicOperators2 || valueLogicOperators3;
Console.WriteLine($"{valueLogicOperators1} or {valueLogicOperators2} or {valueLogicOperators3}: {resultLogicOperators_2}");

bool resultLogicOperators_3 = !valueLogicOperators1;
Console.WriteLine($"!{valueLogicOperators1}: {resultLogicOperators_3}");



//-->>>>>> ///////// Relational Operators - Modifique algunas cosas ///////////

Console.WriteLine("\n************ Relational Operators ************");
int relationalOperatorsValue1 = 3;
int relationalOperatorsValue2 = 18;

bool relationalOperatorsResult0 = relationalOperatorsValue1 == relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} == {relationalOperatorsValue2} is: {relationalOperatorsResult0}");

bool relationalOperatorsResult1 = relationalOperatorsValue1 != relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} != {relationalOperatorsValue2} is: {relationalOperatorsResult1}");

bool relationalOperatorsResult2 = relationalOperatorsValue1 > relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} > {relationalOperatorsValue2} is: {relationalOperatorsResult2}");

bool relationalOperatorsResult3 = relationalOperatorsValue1 < relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} < {relationalOperatorsValue2} is: {relationalOperatorsResult3}");

bool relationalOperatorsResult4 = relationalOperatorsValue1 >= relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} >= {relationalOperatorsValue2} is: {relationalOperatorsResult4}");

bool relationalOperatorsResult5 = relationalOperatorsValue1 <= relationalOperatorsValue2;
Console.WriteLine($"The result of {relationalOperatorsValue1} <= {relationalOperatorsValue2} is: {relationalOperatorsResult5}");



//-->>>>>> ///////// Arrays - Matrices - Arreglos ///////////

Console.WriteLine("\n************ Arrays - Matrices - Arreglos ************\n");

    //Way declarate
    //string[] coffeeTypes = new string[] {"add", "add2};
    //Other way declarate
string[] coffeeTypes;
float[] coffeePrices;

coffeeTypes = new string[]  { "Expresso", "Largo", "Filtrado", "Latte" };
coffeePrices = new float[] { 1.2f,        1.5f,     5.0f,      5.5f }; // position -> index = [0, 1, 2…]
//place the f after the value in the float

    // change 'Largo' -> 'Lungo'
coffeeTypes[1] = "Lungo";
for (int i = 0; i < coffeeTypes.Length; i ++){
    Console.WriteLine($"Coffee {coffeeTypes[i]} ${coffeePrices[i]}");
}



//-->>>>>> ///////// List - Listas ///////////

Console.WriteLine("\n************ List - Listas ************\n");

List<string> tacoShoppingList = new List<string>();

tacoShoppingList.Add("Cinco Tacos de suadero");
tacoShoppingList.Add("Cuatro Tacos de Tripa");
tacoShoppingList.Add("Cinco tacos de pastor");
tacoShoppingList.Add("Cuatro Coca Colas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

tacoShoppingList.Remove("Cinco Tacos de suadero");
//delete by index
//tacoShoppingList.RemoveAt(0);
Console.WriteLine("\n**Execute: tacoShoppingList.Remove('Cinco Tacos de suadero');**\n");
for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}



//-->>>>>> ///////// Methods ///////////

Console.WriteLine("\n************ Methods (Random) ************\n");

Random random = new Random();
Console.WriteLine($"Execute Next(1, 10) method of Random class: {random.Next(1,10)}");
//Numbers 1 to 10 - random



//-->>>>>> ///////// String Methods ///////////
Console.WriteLine("\n************ String Methods ************\n");

string ClassTopic = "Métodos de strings";
string School = "Platzi";


string SchoolClone = School.Clone().ToString();
    Console.WriteLine($"{School}.Clone().ToString(): {SchoolClone}");


    Console.WriteLine($"{ClassTopic}.CompareTo({School}): {ClassTopic.CompareTo(School)}");

    Console.WriteLine($"{School}.Contains('Pla'): {School.Contains("Pla")}");

    Console.WriteLine($"{School}.EndsWith('zi'): {School.EndsWith("zi")}");

    Console.WriteLine($"{School}.StartsWith('Pl'): {School.StartsWith("Pl")}");

    Console.WriteLine($"{School}.Equals({SchoolClone}): {School.Equals(SchoolClone)}");

    Console.WriteLine($"{School}.IndexOf('a'): {School.IndexOf("a")}");

    Console.WriteLine($"{ClassTopic}.ToLower(): {ClassTopic.ToLower()}");
    Console.WriteLine($"{ClassTopic}.ToUpper(): {ClassTopic.ToUpper()}");

    Console.WriteLine($"{School}.Insert(6, ' es educación online efectiva'): {School.Insert(6, " es educación online efectiva")}");

    Console.WriteLine($"{ClassTopic}.LastIndexOf('s'): {ClassTopic.LastIndexOf("s")}");

    Console.WriteLine($"{ClassTopic}.Remove(6): {ClassTopic.Remove(6)}");

    Console.WriteLine($"{ClassTopic}.Replace('s', 'z'): {ClassTopic.Replace("s", "z")}");

    Console.WriteLine($"{ClassTopic}.Substring(2,10): {ClassTopic.Substring(2,10)}");

    string TextWithSpaces = "  hola, había espacios al principio y al final ";
    Console.WriteLine($"{TextWithSpaces}.Trim(): {TextWithSpaces.Trim()}");
    
string[] split = ClassTopic.Split(new char[] { 's' });		
		Console.WriteLine($"string[] split = {ClassTopic}.Split(new char[] { 's' });: ");
        Console.WriteLine(split[0]);
        Console.WriteLine(split[1]);
        Console.WriteLine(split[2]);

Console.WriteLine($"{ClassTopic}.Substring(2,10): {ClassTopic.Substring(2,10)}");



//-->>>>>> ///////// IF statement ///////////

Console.WriteLine("\n************ IF statement ************\n");

int anyValue = 14;
string message = "";

if (anyValue == 7)
{
    message = "The value 7";
}
else if (anyValue == 14)
{
    message = "The value 14";
}
else
{
    message = "The anyValue is not 7 or 14";
}
Console.WriteLine($"The answer is: {message}");



//-->>>>>> ///////// SWITCH statement ///////////

Console.WriteLine("\n************ SWITCH statement ************\n");

Console.WriteLine("Enter the selected soda: (cola-lime-orange-apple)");
		string caseSwitch = Console.ReadLine();

		switch (caseSwitch)
		{
          case "cola":
              Console.WriteLine("Cola soda - $2 USD");
              break;
          case "lime":
              Console.WriteLine("Lime soda - $1 USD");
              break;
          case "orange":
              Console.WriteLine("Orange soda - $1.5 USD");
              break;
		  case "apple":
			  Console.WriteLine("Apple soda - $1 USD");
              break;
          default:
              Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
              break;
		}



//-->>>>>> ///////// Cycle For ///////////

Console.WriteLine("\n************ Cycle For ************\n");

for (int i=0 /*initial condition*/; i < 50 /* rep limit*/; i = i+ 10 /*Increase*/)
{
    Console.WriteLine("Hello World! #{0}", i);
}



//-->>>>>> ///////// WHILE For ///////////

Console.WriteLine("\n************ Cycle WHILE - My way ************\n");

bool continueSoftwareExecution = true;
int choose;

while (continueSoftwareExecution)
{
    Console.WriteLine("1. Continue. 0. Exit");
    choose = Convert.ToInt32(Console.ReadLine());

    if (choose != 1)
        continueSoftwareExecution = false;
}
Console.WriteLine("Bye");



//-->>>>>> ///////// Create Methods ///////////

Console.WriteLine("\n************ Create Methods ************\n");

EjerciciosDeClase myMethod = new EjerciciosDeClase();
myMethod.IntegerAddition(3, 4);
Console.WriteLine($"Return Method: 3 * 4 = {myMethod.IntegerMultiplication(3, 4)}");
Console.WriteLine($"Return Method: 3 / 4 = {myMethod.FloatDivision(3, 4)}");

    public class EjerciciosDeClase{    

        public void IntegerAddition(int a, int b)
        {
        int addition = a + b;
        Console.WriteLine($"{a} + {b} = {addition}");
        }

        public int IntegerMultiplication(int a, int b)
	    {
		int multiplication = a * b;
		return multiplication;
	    }

        public float FloatDivision(float a, float b)
	    {
		float division = a / b;
		return division;
	    }
    }