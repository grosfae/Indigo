using Indigo.Components;
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

namespace Indigo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fakePage = 1;
        int currentPage = 0;
        int maxPage = 0;
        int count = 2;
        public MainWindow()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            IEnumerable<ComputerCase> computerCases = App.DB.ComputerCase.ToList();
            maxPage = computerCases.Count() / count;
            computerCases = computerCases.Skip(count * currentPage).Take(count).ToList();
            LvNames.ItemsSource = computerCases.ToList();
            GenerateButtons();
        }
        private void GenerateButtons()
        {
            ForButtons.Children.Clear();
            for(int i = 1; i <= maxPage; i++)
            {
                Button button = new Button();
                button.Width = 50;
                button.Height = 50;
                button.Content = i.ToString();
                button.Click += ButtonPage_Click;
                button.Margin = new Thickness(5, 0, 5, 0);
                ForButtons.Children.Add(button);
            }
        }
        private void ButtonPage_Click(object sender, RoutedEventArgs e)
        {
            currentPage = int.Parse((sender as Button).Content.ToString()) - 1;
            fakePage = currentPage + 1;
            Refresh();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (fakePage < maxPage)
            {
                currentPage++;
                fakePage = currentPage + 1;
                Refresh();
            }
            else
            {
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(fakePage == 0)
            {
                return;
            }
            else
            {
                currentPage--;
                fakePage = currentPage + 1;
                Refresh();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (fakePage < maxPage)
            {
                currentPage = maxPage - 1;
                fakePage = currentPage + 1;
                Refresh();
            }
            else
            {
                return;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

                currentPage = 0;
                fakePage = currentPage + 1;
                Refresh();

        }
    }
}
