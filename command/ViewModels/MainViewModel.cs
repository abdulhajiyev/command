using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using command.Command;
using command.Models;
using command.Repository;
using command.Views;

namespace command.ViewModels
{
    public class MainViewModel
    {
        public Car Car { get; }
        public ObservableCollection<Car> Cars { get; set; }

        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public EditViewModel EditViewModel { get; set; }

        public MainViewModel()
        {
            Car = new Car
            {
                Id = 0,
                Vendor = "BMW",
                Model = "X5",
                Year = "2014"
            };

            Cars = new FakeRepo().Cars;

            ShowCommand = new RelayCommand(e =>
            {
                MessageBox.Show($"{Car.Vendor}-{Car.Model}-{Car.Year}");
            }, p => true);

            EditCommand = new RelayCommand(
                e =>
                {
                    EditViewModel = new EditViewModel();
                    EditViewModel.Car = Car;

                    var editView = new EditView();
                    editView.DataContext = EditViewModel;
                    editView.ShowDialog();
                }
                );
        }
    }
}
