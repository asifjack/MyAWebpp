namespace MyAWebpp.Service
{
    public class AninalService : AnimalAbs, IAnimal
    {
        public int GetSpeed()
        {
            int speed = 100;
            return speed;
        }

        public void Run()
        {
            Console.WriteLine("Dog id runnng..");
        }
        public string AnimalName { get; set; }

        public override void Color()
        {
            Console.WriteLine("Black");
        }
    }
}
