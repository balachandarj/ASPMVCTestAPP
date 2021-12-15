using ASPMVCTestAPP.Models;

namespace ASPMVCTestAPP.Services
{
    public class BikeService
    {
        public List<Bike> GetBikes()
        {
            // TODO Connect SQL DB and get list of bikes
            List<Bike> bikes = new List<Bike>();
            bikes.Add(new Bike() { Id = 1001, Name = "Benelli", MaxSpeed = 300, Model = "SX100" });
            bikes.Add(new Bike() { Id = 1002, Name = "Yamaha", MaxSpeed = 250, Model = "YX101" });
            bikes.Add(new Bike() { Id = 1003, Name = "Honda", MaxSpeed = 400, Model = "H200" });
            return bikes;
        }

        public void AddBike(Bike bike)
        {

        }
    }
}
