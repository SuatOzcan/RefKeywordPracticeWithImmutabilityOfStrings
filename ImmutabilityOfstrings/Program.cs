// See https://aka.ms/new-console-template for more information

using ImmutabilityOfstrings;

string text1 = "abc";
Modify(text1);
Console.WriteLine(text1);
Alter(ref text1);
Console.WriteLine(text1);

void Modify(string input)
{
    input += "xyz"; // += "xyz" creates a new string array and assigns its address to the input variable.
                    // So text1 variable is not affected.
                    // Still, it is the same as integer parameter: String input copies the numerical value
                    // in the RAM address of text1 to the "input" parameter.
}

void Alter(ref string input)
{
    input += "xyz"; // Now this changes the address of text1. This either assigns the address of the new array to text1
                    // or creates the new array at the address of text1.
}

int demo = 0;

void Deneme(ref int yokus)
{
    yokus = yokus + 1;
}
Deneme(ref demo);
Console.WriteLine(demo);


Person Hakki = new Person() { Name= "Munise" };
void ChangeName(Person person, string newName)
{
    person = new Person { Name = newName }; // Ayni sekilde new Person { Name = newName } adresini person adresine atadi.
                                            // Similarly, new Person { Name = newName } address is assigned
                                            // to the person variable.
}
ChangeName(Hakki, "Akif");
Console.WriteLine(Hakki.Name);