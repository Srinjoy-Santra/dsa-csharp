/*
 An animal shelter, which holds only dogs and cats, operates on a
strictly "first in, first out" basis. People must adopt either the
"oldest" (based on arrival time) of all animals at the shelter, or
they can select whether they would prefer a dog or a cat (and will
receive the oldest animal of that type). They cannot select which
specific animal they would like. Create the data structures to
maintain this system and implement operations such as enqueue,
dequeueAny, dequeueDog, and dequeueCat. You may use the built in
LinkedList data structure.
*/

namespace DSA.ctci;

public abstract class Animal
{
    public string Name { get; set; }
    public int Order { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
}

public class AnimalShelter
{
    private Queue<Dog> Dogs;
    private Queue<Cat> Cats;

    public AnimalShelter()
    {
        Dogs = new Queue<Dog>();
        Cats = new Queue<Cat>();
    }
    public void Enqueue(Animal animal)
    {
        animal.Order = Dogs.Count + Cats.Count;
        if (animal is Dog dog)
        {
            Dogs.Enqueue(dog);
        }
        else
        {
            Cats.Enqueue(animal as Cat);
        }
    }
    
    public Animal DequeueAny()
    {
        if (Dogs.Count == 0)
            return Cats.Dequeue();
        if(Cats.Count == 0)
            return Dogs.Dequeue();
        
        if(Dogs.Peek().Order < Cats.Peek().Order)
            return DequeueDog();
        return DequeueCat();
    }
    
    public Dog DequeueDog()
    {
        return Dogs.Dequeue();
    }
    
    public Cat DequeueCat()
    {
        return Cats.Dequeue();
    }
}