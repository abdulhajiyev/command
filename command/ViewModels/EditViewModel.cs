using System.Windows;
using command.Command;
using command.Models;
using command.Views;

namespace command.ViewModels
{
    public class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand SaveCommand { get; set; }


        public EditViewModel()
        {
            var editView = new EditView();

            SaveCommand = new RelayCommand(
                action =>
                {
                    MessageBoxResult messageBoxResult = MessageBox.Show("Saved!");
                    if (messageBoxResult == MessageBoxResult.OK)
                    {
                        editView.Close();
                    }

                },
                predicate => true
            );
        }
    }
}
