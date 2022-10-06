using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product("Бананы", 90, @"Image\banan.jpg", ProdCateg.Еда));
            products.Add(new Product("Утюг", 2100, @"Image\iron.jpg", ProdCateg.Техника));
            products.Add(new Product("Масло сливочное", 150, @"Image\butter.jpg", ProdCateg.Еда));
            products.Add(new Product("Цыпленок", 250, @"Image\kuritsa.jpg", ProdCateg.Еда));
            products.Add(new Product("Чайник", 1500, @"Image\kettle.jpg", ProdCateg.Техника));
            listBox.ItemsSource = products;
        }
    }
}
