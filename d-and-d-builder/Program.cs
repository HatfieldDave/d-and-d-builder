
using d_and_d_builder;

PlayerCharacter player = new PlayerCharacter();
Dice d6 = new Dice(6);
Dice d20 = new Dice(20);


bool done = false;
while (!done)
{
    // Intro
    Console.WriteLine("Welcome to CharacterBuider");
    Console.WriteLine();
    Console.Write("What's your characters name? ");
    player.Name = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"{player.Name} ya say? It fits...I suppose.");
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
        $" celebrate others and their culture so I celebrate you {player.Name}");
    Console.WriteLine("Alrirght onto the next thing. What class are you? Not like socio-economic class," +
        $" more like what you do. What do you do {player.Name}");
    List<Class> classes = player.GetPlayerClass();

    Console.Write("coose one: ");

    string classChoiceString = Console.ReadLine();
    int classChoice = int.Parse(classChoiceString);

    switch (classChoice)
    {
        case 1:
            classes.IndexOf(0);
            break;
    }

    // PLAYER STATS
    
    int strRoll = d6.RollDice(3);
    int dexRoll = d6.RollDice(3);
    int conRoll = d6.RollDice(3);
    int intRoll = d6.RollDice(3);
    int wisRoll = d6.RollDice(3);
    int chaRoll = d6.RollDice(3);

    player.Strength = strRoll;
    player.Dexterity = dexRoll;
    player.Constitution = conRoll;
    player.Wisdom = wisRoll;
    player.Intelligence = intRoll;
    player.Charisma = chaRoll;

    Console.WriteLine();
    Console.WriteLine($"Strength = {player.Strength}");
    Console.WriteLine($"Dexterity = {player.Dexterity}");
    Console.WriteLine($"Constitutuion = {player.Constitution}");
    Console.WriteLine($"Wisdom = {player.Wisdom}");
    Console.WriteLine($"Intelligence = {player.Intelligence}");
    Console.WriteLine($"Charisma = {player.Charisma}");
    Console.WriteLine();
    Console.WriteLine($"Rad! here are your stats {player.Name}. I want you to know though, just like" +
        $" class or race these dont define you. You are special because you are you. You live therefore you are beautiful. ya feel?");



}