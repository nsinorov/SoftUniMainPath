namespace Cars.Models
{
    public interface ICar
    {
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

