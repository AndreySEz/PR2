using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void resButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Number number = new Number(Convert.ToInt32(numberBox.Text));
                number.Check();
            }
            catch
            {
                MessageBox.Show("Некорректное значение");
            }
        }
    }
}
