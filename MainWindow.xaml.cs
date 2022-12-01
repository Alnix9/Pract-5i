using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Генеральский_практическая_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PerimetrButton(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbDoublingA.Text, out int _A) & !int.TryParse(tbDoublingB.Text,out int _B) & !int.TryParse(tbDoublingC.Text,out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем узнавать их периметр" , "Вы нублан" , MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            else
            {
                 Triangle _triangle1 = new Triangle(_A,_B,_C);
                 _triangle1.Perimetr(_A, _B, _C);
                 tbPerimetr1.Text = Convert.ToString(_triangle1.A + _triangle1.B + _triangle1.C);
            }
        }
        private void DoublingButton(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры прежде чем узнавать удваивать их", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Triangle _doubling = new Triangle(_A, _B, _C);
                _doubling.Doubling(_A, _B, _C);
                tbDoublingA.Text = Convert.ToString(_doubling.A);
                tbDoublingB.Text = Convert.ToString(_doubling.B);
                tbDoublingC.Text = Convert.ToString(_doubling.C);
            }
        }
        private void SetParams1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA1.Text, out int _A) & !int.TryParse(tbSideB1.Text, out int _B) & !int.TryParse(tbSideC1.Text, out int _C))
            {
                MessageBox.Show("Установите параметры", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Triangle _setParams1 = new Triangle(_A, _B, _C);
            _setParams1.SetParams(_A, _B, _C);
            tbTriangle1.Text = Convert.ToString(_setParams1.A) + "," + Convert.ToString(_setParams1.B) + "," + Convert.ToString(_setParams1.C);
        }
        private void SetParams2(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbSideA2.Text, out int _A) & !int.TryParse(tbSideB2.Text, out int _B) & !int.TryParse(tbSideC2.Text, out int _C))
            {
                MessageBox.Show("Установите параметры", "Вы нублан", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Triangle _setParams2 = new Triangle(_A, _B, _C);
            _setParams2.SetParams(_A, _B, _C);
            tbTriangle2.Text = Convert.ToString(_setParams2.A) + "," + Convert.ToString(_setParams2.B) + "," + Convert.ToString(_setParams2.C);
        }
        private void About_Program(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5. Создать класс Triangle (треугольник) с полями-сторонами. " +
                "Создать необходимые \r\nметоды и свойства. Определить метод вычисления периметра. " +
                "Создать \r\nперегруженные методы SetParams, для установки параметров объекта, в том числе \r\nувеличения размеров треугольника в 2 раза.");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

   

