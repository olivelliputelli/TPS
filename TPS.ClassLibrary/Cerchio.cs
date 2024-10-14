namespace TPS.ClassLibrary
{
    public class Cerchio
    {
        public double Raggio { get; set; }
        public double Area() => Math.PI * Math.Pow(Raggio, 2);
        public double Circonferenza() => 2 * Math.PI * Raggio;
    }
}
