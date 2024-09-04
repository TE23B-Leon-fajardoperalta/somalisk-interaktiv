Console.WriteLine("arm ett eller arm två?");
string arm = Console.ReadLine(); // gör en variabel


if (arm == "arm ett") // om variablen som läses ut av readline blir arm ett
{
    Console.WriteLine("har arm ett fingrar??");

}
else // om inte
{
 Console.WriteLine("har arm två fingrar!!"); // skriv andra senariot 
}

string arm2 = Console.ReadLine();
if (arm2 == "ja")
{

Console.WriteLine("wow du har fingrar!");

}

else 
{
    Console.WriteLine("köp nya");
}
Console.ReadLine();