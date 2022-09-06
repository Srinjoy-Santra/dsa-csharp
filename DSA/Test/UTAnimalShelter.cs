using DSA.ctci;

namespace Test
{
    public class UTAnimalShelter
    {
        [Fact]
        public void Solution_AnimalShelter_ReturnsExpected()
        {
            //Arrange
            // Cat names souce: https://www.purina.co.uk/articles/cats/behaviour/common-questions/famous-cats-in-history
            Animal ted = new Cat("Ted Nude-Gent");
            Animal tardar = new Cat("Tardar Sauce");
            Animal cole = new Cat("Cole");
            Animal nala = new Cat("Nala");

            // Dog names source : https://www.countryliving.com/uk/wildlife/dog-breeds/g32028241/famous-dogs-in-films/
            Animal marley = new Dog("Marley");
            Animal beethoven = new Dog("Beethoven");
            Animal slinky = new Dog("Slinky");
            Animal toto = new Dog("Toto");

            //Act
            AnimalShelter animalShelter = new();
            animalShelter.Enqueue(ted);
            animalShelter.Enqueue(tardar);
            animalShelter.Enqueue(marley);
            animalShelter.Enqueue(cole);
            animalShelter.Enqueue(beethoven);
            animalShelter.Enqueue(slinky);
            animalShelter.Enqueue(toto);
            animalShelter.Enqueue(nala);

            //Assert
            Assert.Equal(ted, animalShelter.DequeueAny());
            Assert.Equal(marley, animalShelter.DequeueDog());
            Assert.Equal(tardar, animalShelter.DequeueCat());

            animalShelter.DequeueAny();
            animalShelter.DequeueAny();
            animalShelter.DequeueAny();
            
            Assert.Equal(toto, animalShelter.DequeueAny());
            
            //Assert.Equal(null, animalShelter.DequeueDog());
            //Assert.Equal(null, animalShelter.DequeueCat());
        }
    }
}
