
namespace vpd
{
    internal class temperatura
    {
        static void Main(string[] args)
        {
            double temp;
            double umid;
            Console.Write("Insira um valor para temperatura: ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira um valor para umidade relativa: ");
            umid = Convert.ToInt32(Console.ReadLine());

            if (temp > 58)
            {
                temp = Math.Round((temp - 32) / 1.8);
            }
            
            double es = 0.611 * Math.Exp((17.27 * temp) / (temp + 237.3));
            double x = es * (umid / 100);
            double vpd = Math.Round(es - x,2);
            
            Console.WriteLine("O valor de VPD é "+vpd);

            if(vpd<0.4 || vpd > 1.6)
            {
                Console.WriteLine("Danger Zone");
            }
            if(vpd>=0.4 && vpd < 0.8)
            {
                Console.WriteLine("Propagation / Early Veg Stage");
            }
            if (vpd >= 0.8 && vpd < 1.2)
            {
                Console.WriteLine("Late Veg / Early Flower Stage");
            }
            if (vpd >= 1.2 && vpd <= 1.6)
            {
                Console.WriteLine("Mid / Late Flower Stage");
            }
        }
    }
}
    