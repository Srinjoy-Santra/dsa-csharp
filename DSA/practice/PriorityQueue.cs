namespace DSA.practice;

/*
 * Similar question:
 * Resources :
 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.priorityqueue-2?view=net-6.0
 * https://khalidabuhakmeh.com/working-with-dotnet-six-priorityqueue
 */
public class PriorityQueue 
{
    private class GreatnessComparer : IComparer<Greatness>
    {
        // highest to lowest
        public int Compare(Greatness x, Greatness y) => y - x;
    }

    private enum Greatness
    {
        Meh,
        Ok,
        Good,
        Great,
        GOAT
    }
    
    public static void Run()
    {
        PriorityQueue<string, Greatness> superheroes 
            = new(new GreatnessComparer());

        superheroes.Enqueue("Hawkeye", Greatness.Meh);
        superheroes.Enqueue("Captain America", Greatness.GOAT);
        superheroes.Enqueue("Mantis", Greatness.Ok);
        superheroes.Enqueue("Scarlet Witch", Greatness.Good);
        superheroes.Enqueue("Black Widow", Greatness.Meh);
        superheroes.Enqueue("Spider-Man", Greatness.Great);
        superheroes.Enqueue("Dr. Strange", Greatness.Good);
        superheroes.Enqueue("Thor", Greatness.Great);
        superheroes.Enqueue("Shuri", Greatness.Great);
        superheroes.Enqueue("Black Panther", Greatness.Great);
        superheroes.Enqueue("Iron Man", Greatness.Ok);
        superheroes.Enqueue("Hulk", Greatness.Good);

        Console.WriteLine("Oh No! Hydra is attacking.");
        Console.WriteLine("Avengers... Assemble!");

        while (superheroes.TryDequeue(out var hero, out var greatness))
        {
            Console.WriteLine($"{hero} ({greatness}) has joined the fight...");
        }
    }
}