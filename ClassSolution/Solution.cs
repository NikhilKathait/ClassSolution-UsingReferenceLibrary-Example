public class Sample
{
    static void Main()
    {
        // Add ClassLibrary1 as reference to access Customer class present in it

        // Reference variables
        Customer c1, c2;

        // Objects
        c1 = new Customer();
        c1.CustomerID = 1;
        c1.CustomerName = "Nikhil";
        c2 = new Customer();
        c2.CustomerID = 2;
        c2.CustomerName = "Alex";

        System.Console.Write(c1.CustomerID + " , " + c1.CustomerName + " \n");
        System.Console.Write(c2.CustomerID + " , " + c2.CustomerName + " \n");

    }
}
