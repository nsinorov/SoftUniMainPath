namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();
            dog.Eat();

            Puppy puppy = new Puppy();

            puppy.Bark();
            puppy.Eat();
            puppy.Weep();

            Cat cat = new Cat();

            cat.Eat();
            cat.Meow();
           
        }
    }
}