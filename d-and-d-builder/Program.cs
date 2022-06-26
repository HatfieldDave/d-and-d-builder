
using d_and_d_builder;

PlayerCharacter player = new PlayerCharacter();

bool done = false;
while (!done)
{
    // Intro
    Console.WriteLine("Welcome to CharacterBuider");
    Console.WriteLine();
    Console.Write("What's your characters name? ");
    string charName = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"{charName} ya say? It fits...I suppose.");
    Console.WriteLine();
    Console.WriteLine("So this is a weird question but...What race are you? I mean" +
        " I hate to ask but...you know D&D and all. I could care less, but it does affect your" +
        " stats.");

    // Race selection
    List<Race> races = player.GetListOfRaceEnums();

    
    Console.Write("coose one: ");

    string raceChoiceString = Console.ReadLine();
    int raceChoice = int.Parse(raceChoiceString);

    switch (raceChoice)
    {
        case 1:
            races.IndexOf(0);
            break;
    }

    // Class Selecton
    Console.WriteLine();
    Console.WriteLine("Tight, that was awkward for both of us. I dont belive that race has anything to do with" +
        " skills or stats but some dude named Gary Gygax did so Wizards just kept it going. I do think we should " +
        $" Celebrate others and their culture so I celebrate you {charName}");
    Console.WriteLine("Alrirght onto the next thing. What class are you? Not like socio-economic class," +
        $" more like what you do. What do you do {charName}");
    List<Class> classes = player.GetListOfClassEnums();

    string classChoiceString = Console.ReadLine();
    int classChoice = int.Parse(classChoiceString);

    switch (classChoice)
    {
        case 1:
            classes.IndexOf(0);
            break;
    }




}