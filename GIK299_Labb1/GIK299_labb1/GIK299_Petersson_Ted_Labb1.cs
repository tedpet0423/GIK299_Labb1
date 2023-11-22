// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //deklarerar variabler för namn och ålder på 4 pers
        string name1, name2, name3, name4;
        double age1, age2, age3, age4;
        
        //Hämtar namn och older för person 1
        Console.WriteLine("Enter a name of a family member:");
        name1 = Console.ReadLine();
        Console.WriteLine("Enter the persons age");
        age1 = Convert.ToDouble(Console.ReadLine());
        
        //Hämtar namn och older för person 2
        Console.WriteLine("Enter a second name of a family member:");
        name2 = Console.ReadLine();
        Console.WriteLine("Enter the persons age");
        age2 = Convert.ToDouble(Console.ReadLine());
        
        //Hämtar namn och older för person 3
        Console.WriteLine("Enter a third name of a family member:");
        name3 = Console.ReadLine();
        Console.WriteLine("Enter the persons age");
        age3 = Convert.ToDouble(Console.ReadLine());
        
        //Hämtar namn och older för person 4
        Console.WriteLine("Enter a fourth name of a family member:");
        name4 = Console.ReadLine();
        Console.WriteLine("Enter the persons age");
        age4 = Convert.ToDouble(Console.ReadLine());
        
        //rensar konsoll för att inte visa samma info flera gånger
        Console.Clear();
        
        //skriver ut namn och ålder på personerna som lagts till
        Console.WriteLine(name1 + " is " + age1 + " years old\n" +
                          name2 + " is " + age2 + " years old\n" +
                          name3 + " is " + age3 + " years old\n" +
                          name4 + " is " + age4 + " years old\n");
        //skriver ut namn på personerna som lagts till
        Console.WriteLine("The average age of " +
                          "" + name1 + ", " + name2 + ", " + name3 + 
                          " and " + name4 + " are:");
        //beräknar totalålder samt medelålder
        double totalAge = (age1 + age2 + age3 + age4);
        double averageAge = totalAge/ 4;
        
        //skriver ut och formaterar medelålder samt skriver ut totalålder
        Console.WriteLine(averageAge.ToString("##.00"));
        Console.WriteLine("And the combined age is:\n"+ totalAge + " years.");


    }
}