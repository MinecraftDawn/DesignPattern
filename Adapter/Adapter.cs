namespace DesignPattern.Adapter
{

    // Adaptee
    interface Bike
    {
        void ride();
    }

    class MyBike : Bike
    {
        public void ride()
        {
            Console.WriteLine("騎乘腳踏車");
        }
    }

    // Target
    interface ElectricCar
    {
        void powerDriven();
    }

    class ElectricBike : ElectricCar
    {
        private Bike bike;

        public ElectricBike(Bike bike)
        {
            this.bike = bike;
        }

        public void powerDriven()
        {
            Console.WriteLine("電動模式開啟");
            bike.ride();
        }
    }
}
