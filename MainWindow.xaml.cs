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

namespace WPF_task4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate2.Text);
            double sumGrivn = Convert.ToDouble(sum2.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSum2.Text = resGrivn.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrahm = Convert.ToDouble(rate3.Text);
            double sumDrahm = Convert.ToDouble(sum3.Text);
            double resDrahm = rateDrahm * sumDrahm;
            resSum3.Text = resDrahm.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distInch = Convert.ToDouble(dist.Text);
            double resInch = distInch * 0.0254;
            res.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distFut = Convert.ToDouble(dist.Text);
            double resFut = distFut * 0.3048;
            res.Text = resFut.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distMile = Convert.ToDouble(dist.Text);
            double resMile = distMile * 1609.344;
            res.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distVirst = Convert.ToDouble(dist.Text);
            double resVirst = distVirst * 1066.8;
            res.Text = resVirst.ToString();
        }
    }
}
