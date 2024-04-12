namespace citi.Tests._3.StacksAndQueues
{
    using ctci._3.StacksAndQueues;

    public class AnimalShelterTests
    {
        [Fact]
        public void AnimalShelterWorksAsExpected()
        {
            // Arrange
            var shelter = new AnimalShelter();

            // Act
            shelter.Enqueue(AnimalShelter.AnimalType.Dog, "Dog1");
            shelter.Enqueue(AnimalShelter.AnimalType.Dog, "Dog2");
            shelter.Enqueue(AnimalShelter.AnimalType.Cat, "Cat1");
            shelter.Enqueue(AnimalShelter.AnimalType.Dog, "Dog3");
            shelter.Enqueue(AnimalShelter.AnimalType.Cat, "Cat2");

            // Assert
            Assert.Equal("Dog1", shelter.DequeueAny().Name);
            Assert.Equal("Cat1", shelter.DequeueCat().Name);
            Assert.Equal("Dog2", shelter.DequeueAny().Name);
        }
    }
}
