namespace ctci._3.StacksAndQueues
{
    public class AnimalShelter
    {
        public enum AnimalType
        {
            Dog = 0,
            Cat = 1
        }

        public int animalTypes;

        public int order;

        public class Animal
        {
            public string Name { get; set; }
            public AnimalType Type { get; set; }
            internal int Order { get; set; }
        }

        private LinkedList<Animal>[] animals;

        public AnimalShelter()
        {
            this.order = 0;
            this.animalTypes = AnimalType.GetValues(typeof(AnimalType)).Length;
            this.animals = new LinkedList<Animal>[this.animalTypes];
            for (int i = 0; i < this.animalTypes; i++)
            {
                this.animals[i] = new LinkedList<Animal>();
            }
        }

        public void Enqueue(AnimalType type, string name)
        {
            this.order++;
            var animal = new Animal { Name = name, Type = type, Order = this.order };
            this.animals[(int)animal.Type].AddLast(animal);
        }

        public Animal DequeueAny()
        {
            var animalType = this.GetFirstAnimalTypeByOrder();
            var animal = this.animals[(int)animalType].First.Value;
            this.animals[(int)animalType].RemoveFirst();
            return animal;
        }

        public Animal DequeueDog()
        {
            return this.DequeueAnimal(AnimalType.Dog);
        }

        public Animal DequeueCat()
        {
            return this.DequeueAnimal(AnimalType.Cat);
        }

        private Animal DequeueAnimal(AnimalType animalType)
        {
            var animal = this.animals[(int)animalType].First.Value;
            this.animals[(int)animalType].RemoveFirst();

            return animal;
        }

        private AnimalType GetFirstAnimalTypeByOrder()
        {
            var lastOrder = int.MaxValue;
            AnimalType? lastAnimalType = null;
            for (int i = 0; i < this.animalTypes; i++)
            {
                if (this.animals[i].First?.Value != null && this.animals[i].First.Value.Order < lastOrder)
                {
                    lastOrder = this.animals[i].First.Value.Order;
                    lastAnimalType = this.animals[i].First.Value.Type;
                }
            }

            return lastAnimalType.Value;
        }
    }
}
