using System;


namespace d_and_d_builder
    {
    public class PlayerCharacter : Character
    {
        public int Level { get; set; } = 1;
        public string? Name { get; set; }
        public Race Race { get; set; }
        public Class Class { get; set; }

        public int GetAbilityModifier(int ability)
        {
           int abilityMod = (ability - 10) / 2;
            if (abilityMod <= -5)
            {
                return -5;
            }
            return abilityMod;
        }

        public List<Race> GetListOfRaceEnums()
        {
            List<Race> races = Enum.GetValues(typeof(Race)).Cast<Race>().ToList();
            int count = 0;
            foreach (Race race in races)
            {
                count++;
                Console.WriteLine();
                Console.WriteLine($"{count} {race}");
            }
            return races;
        }

        public List<Class> GetPlayerClass()
        {
            List<Class> classes = Enum.GetValues(typeof(Class)).Cast<Class>().ToList();

            int count = 0;
            foreach (Class @class in classes)
            {
                count++;
                Console.WriteLine();
                Console.WriteLine($"{count} {@class}");
            }
            return classes;
        }
    }

    
}


