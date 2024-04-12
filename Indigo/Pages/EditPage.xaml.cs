using Indigo.Components;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Indigo.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        ComputerCase contextCase;
        public EditPage(ComputerCase computerCase)
        {
            InitializeComponent();
            this.contextCase = computerCase;
            DataContext = contextCase;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "*.jpg|*.jpg"
            };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextCase.MainImage = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextCase;
            }

        }
    }
}
