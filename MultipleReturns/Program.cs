using MultipleReturns;

internal class Program
{
    //Tuple
    private static (int, string) GetPosition()
    {
        return (1, "position");
    }

    //Named Tuple
    private static (int position, string name) GetPositionV2()
    {
        return (1, "position");
    }

    private static void Main(string[] args)
    {
       //Create a Tuple with the Tuple literal
        (int, string) contact = (1, "Max Mustermann");
        Console.WriteLine($"{contact.Item2} hat die ID {contact.Item1}");
        //Output: Max Mustermann hat die ID 1
        

        //Create a Tuple with the Tuple class
        Tuple<int, string> contact2 = new Tuple<int, string>(1, "Name");

        //Tuple with named elements
        var contact3 = (ID: 1, Name: "Max Mustermann");
        Console.WriteLine($"{contact3.Name} hat die ID {contact3.ID}");

        //Tuple with multiple returns
        var adress = (Street: "Musterstraße", Number: 1, Zip: 12345, City: "Musterstadt");
        Console.WriteLine($"{adress.Street} {adress.Number}, {adress.Zip} {adress.City}");

        Console.WriteLine(contact.Item1);
        
        var positon = GetPosition();
        Console.WriteLine(positon);

        var secondPosition = GetPositionV2();

        
        secondPosition.position = 2;

        var (position, name) = GetPosition();

        (int, string) tuple = GetPosition();

        Console.WriteLine($"{tuple}");
        tuple = (1, "test");
        Console.ReadKey();
        Console.WriteLine($"{tuple}");

        var response = GetPosition();

        Console.WriteLine($"Position: {tuple.Item2}");
        Console.WriteLine($"Position: {response.Item1}");
        var assets = GetAssetList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });          
        Console.ReadKey();
    }

    private static List<Tuple<int, byte[]>> GetAssetList(List<int> contactIDs)
    {
        IAssetService assetService = new AssetService();

        // Loads assets for the given Contacts form a storage
        var assignedPictures = assetService.GetAssignedAssets(contactIDs);
        

        return assignedPictures;
    }

    //private static Tuple<int,string> TryToModifyATupleValue(Tuple<int, string> contact)
    //{
    //    // This will not work, because Tuple is immutable (read only)
    //    contact.Item1 = 2;
    //    contact.Item2 = "New Name";

    //    return contact;
    //}


}