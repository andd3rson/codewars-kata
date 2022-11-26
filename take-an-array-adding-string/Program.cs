bool continued = false;
List<string> names = new();
Console.Write("Deseja adicionar y/n: ");
var add = Console.ReadLine() == "y" ? true : false;;
Console.Clear();
if (add)
{

    do
    {
        Console.Write("add a new name: ");
        names.Add(Console.ReadLine() ?? string.Empty);
        Console.Clear();
        Console.WriteLine("Would like to add anyone more?\n1 - Yes.\n0 - No. ");
        continued = Console.ReadLine() == "0" ? false : true;
        Console.Clear();
    }
    while (continued);

}

Console.WriteLine(LikeFunctions.LikeTransform(names));
