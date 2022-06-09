// Insert Program Here
using template_csharp_class_of_your_choice;

TheVault thevault = new TheVault();
Shoe 
Retro1 = new Shoe();
thevault.Shoes.Add(Retro1);

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("****THIS IS THE SHOE VAULT****");
    Console.WriteLine("---------------------------------------\n");
    Console.WriteLine("KEEP TABS ON ALL OF YOUR KICKS\n");
    Console.WriteLine("Which would you like to do?");
    Console.WriteLine("1. Add a shoe to your vault");
    Console.WriteLine("2. View your whole vault");
    Console.WriteLine("3. Outfit Inspirtaion");
    Console.WriteLine("4. Random shoe generator");
    Console.WriteLine("5. Delete a shoe from your vault");
    Console.WriteLine("Press D if you're Done");

    string input = Console.ReadLine().ToLower();

    // Step 1: ask yourself whether the function is of the shoe or the vault
    // Step 2: call the method on an object of the respective type^
    // Step 3: Implement that method

    switch (input)
    {
        case "1":
            thevault.AddShoeToTheVault();
            break;
        case "2":
            Shoe.ViewYourWholeVault();
            break;
        case "3":
            //Shoe.OutfitInspiration();
            break;
        case "4":
            //Shoe.RandomShoeGenerator();
            break;
        case "5":
            //Shoe.DeleteAShoeFromYourVault();
            break;
        case "d":
            isRunning = false;
            Console.WriteLine("If you buy a new pair, be sure to update your Vault");
            break;
        default:
            break;
    }
}