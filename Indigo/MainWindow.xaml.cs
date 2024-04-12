using Indigo.Components;
using Indigo.Pages;
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
            MainFrame.Navigate(new ListPage());
        }
        
    }
}
