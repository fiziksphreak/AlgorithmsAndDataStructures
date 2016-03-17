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
using AlgorithmLibraries;

namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void insertionSortBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> toSort = new List<string> {
                                      "test",
                                      "fun",
                                      "James",
                                      "wtf",
                                      "alpha",
                                      "dictionary",
                                      "Julie",
                                      "Sophie",
                                      "my love",
                                      "beautiful",
                                      "Amazon",
                                      "Google",
                                      "enough to test"
                                  };

            bool success = Sort.InsertionSort(ref toSort);
            if (success)
            {
                StringBuilder sb = new StringBuilder();

                foreach (string sorted in toSort)
                {
                    sb.Append(sorted + ", ");
                }

                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("sort failed");
            }
        }

        private void mergeSortBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
