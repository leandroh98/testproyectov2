using Newtonsoft.Json.Linq;
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
using WpfApp.Business;

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalculatorBusiness cb = new CalculatorBusiness();
            int sum = cb.Sum(2, 3);
            int diff = cb.Difference(10, 8);

            JObject jo = new JObject();
            

            JArray array = new JArray();
            array.Add(sum);
            array.Add(diff);

            JObject o = new JObject();
            o["Calculator Array"] = array;

            string json = o.ToString();

            MessageBox.Show(json);
        }
    }
}
