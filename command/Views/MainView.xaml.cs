using System.Windows;
using command.Command;
using command.Models;

namespace command.Views
{
    public partial class MainView : Window
    {
        public Car Car { get; }
        public RelayCommand ShowCommand { get; set; }

        public MainView()
        {
            InitializeComponent();
            DataContext = this;

            Car = new Car
            {
                Id = 0,
                Vendor = "BMW",
                Model = "X5",
                Year = "2014"
            };
            ShowCommand = new RelayCommand(e =>
                {
                    MessageBox.Show($"{Car.Vendor}-{Car.Model}-{Car.Year}");
                }, p => true);
        }
    }
}
