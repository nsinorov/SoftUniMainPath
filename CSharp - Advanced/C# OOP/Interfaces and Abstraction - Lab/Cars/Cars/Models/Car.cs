namespace Cars.Models
{
    public abstract class Car : ICar
    {
        protected Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }

        public string Color { get; }

        public void Start()
        {
        }
        public void Stop()
        {
        }
    }
}
