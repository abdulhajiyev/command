using System.Windows;
using command.Command;
using command.Models;
using command.Views;

namespace command.ViewModels
{
    public class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand CloseCommand { get; set; }


        public EditViewModel()
        {
            CloseCommand = new RelayCommand(a =>
            {
                if (a is Window window)
                {
                    window.Close();
                }
            });
        }
    }
}
