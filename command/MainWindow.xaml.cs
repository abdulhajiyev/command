using System.Windows;
using command.Command;

namespace command
{
    public partial class MainWindow : Window
    {
        public MessageCommand MessageCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;

            MessageCommand = new MessageCommand(Display);
        }

        public void Display()
        {
            MessageBox.Show("MessageCommandWorks");
        }
    }
}
