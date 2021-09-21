using System.Collections.ObjectModel;
using command.Models;

namespace command.Repository
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }

        public FakeRepo()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Id = 0,
                    Vendor = "AUDI",
                    Model = "A8",
                    Year = 2016
                },
                new Car
                {
                    Id = 1,
                    Vendor = "BMW",
                    Model = "M5",
                    Year = 2021
                },
                new Car
                {
                    Id = 2,
                    Vendor = "Mercedes",
                    Model = "C63",
                    Year = 2018
                }
            };
        }
    }
}
