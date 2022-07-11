namespace DependecyInjection.Model
{
    public class NumGenerator:INumGenerator
    {
        public int RandomValue { get; }

        public  NumGenerator()
        {
            RandomValue = new Random().Next(1000);
           
        }
    }
}
