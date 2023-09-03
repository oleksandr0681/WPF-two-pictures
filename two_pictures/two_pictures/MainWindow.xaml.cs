// Задание 1 
//Возмите два рисунка (или фото ), например парк летом и осенью. 
// С помощью анимации свойства прозррачности сделайте смену картинки при загрузке постепенно.

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
using System.Windows.Media.Animation;

namespace two_pictures
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

        private void Window_Loaded(object sender, RoutedEventArgs e) // Окно загружено.
        {
            DoubleAnimation transparency_animation = new DoubleAnimation();
            transparency_animation.From = second_image.Opacity; // From: начальное значение, с которого будет начинается анимация.
            transparency_animation.To = 0.0; // To - конечное значение.
            transparency_animation.Duration = TimeSpan.FromSeconds(10); // время анимации в виде объекта TimeSpan.
            second_image.BeginAnimation(Image.OpacityProperty, transparency_animation); // Запуск анимации 
            // (Объект).BeginAnimation( свойство , значение);
        }

        private void button1_Click(object sender, RoutedEventArgs e) // Кнопка "Первая картинка".
        {
            DoubleAnimation transparency_animation = new DoubleAnimation();
            transparency_animation.From = second_image.Opacity; // From: начальное значение, с которого будет начинается анимация.
            transparency_animation.To = 0.0; // To - конечное значение.
            transparency_animation.Duration = TimeSpan.FromSeconds(10); // время анимации в виде объекта TimeSpan.
            second_image.BeginAnimation(Image.OpacityProperty, transparency_animation); // Запуск анимации 
            // (Объект).BeginAnimation( свойство , значение);
        }

        private void button2_Click(object sender, RoutedEventArgs e) // Кнопка "Вторая картинка".
        {
            DoubleAnimation transparency_animation = new DoubleAnimation();
            transparency_animation.From = second_image.Opacity; // From: начальное значение, с которого будет начинается анимация.
            transparency_animation.To = 1.0; // To - конечное значение.
            transparency_animation.Duration = TimeSpan.FromSeconds(10); // время анимации в виде объекта TimeSpan.
            second_image.BeginAnimation(Image.OpacityProperty, transparency_animation); // Запуск анимации 
            // (Объект).BeginAnimation( свойство , значение);
        }
    }
}
