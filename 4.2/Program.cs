using System;

namespace PW42
{
    class Package
    {
        public string PackageDescription { get; set; }
        public double Weight { get; set; }

        public Package(string PackageDescription, double weight)
        {
            PackageDescription = PackageDescription;
            Weight = weight;
        }
    }

    class DeliveryService
    {
        public double WeightLimit { get; private set; }
        public double TotalWeight { get; private set; }

        public DeliveryService(double weightLimit)
        {
            WeightLimit = weightLimit;
            TotalWeight = 0;
        }

        public void SendPackage(Package package)
        {
            if (TotalWeight + package.Weight > WeightLimit)
            {
                Console.WriteLine($"Посылка весит: ({package.Weight}) кг. Превышен лимит веса: ({WeightLimit} кг). Отправка прервана.");
            }
            else
            {
                TotalWeight += package.Weight;
                Console.WriteLine($"Посылка отправлена: {package.PackageDescription} ({package.Weight} кг)");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DeliveryService deliveryService = new DeliveryService(10);

            Package package1 = new Package("Посылка1", 1);
            deliveryService.SendPackage(package1);

            Package package2 = new Package("Посылка2", 2);
            deliveryService.SendPackage(package2);

            Package package3 = new Package("Посылка3", 30);
            deliveryService.SendPackage(package3);

            Console.ReadKey();
        }
    }
}
