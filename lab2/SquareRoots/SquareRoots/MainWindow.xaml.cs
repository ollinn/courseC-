using System;
using System.Windows;
using System.Windows.Controls;


namespace SquareRoots
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

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double numberDouble;
            // если НЕ получится преобразовать введенное число в тип double, то
            // выводим сообщение с ошибкой
            // out - передает по ссылке 
            if (!double.TryParse(inputTextBox.Text, out numberDouble))
            {
                MessageBox.Show("Please enter a double number");
                return;
            }
            
            // проверка на положительное число 
            if (numberDouble <= 0)
            {
                MessageBox.Show("Please enter a positive number");
                return;
            }

            double squareRoot = Math.Sqrt(numberDouble);
            frameworklLabel.Content = string.Format("{0} (Using the .NET Framework)", squareRoot);

            // способ вычисления корней по ньютону 
            // decimal - может представлять десятичные значения без ошибок округления
            decimal numberDecimal;
            if (!decimal.TryParse(inputTextBox.Text, out numberDecimal))
            {
                MessageBox.Show("Please enter a decimal number");
                return;
            }
            // math возвращает double, для преобразования используем convert
            // значение - минимальный диапазон, поддерживаемый типом decimal 
            // когда разница между двумя оценками будет меньше этого значения - останавливаемся
            decimal delta = Convert.ToDecimal(Math.Pow(10, -28));
            
            // начальное предположение, которое будет корректироваться
            decimal guess = numberDecimal / 2;

            // оценка результата первой итерации
            decimal result = ((numberDecimal / guess) + guess / 2);

            // для дальнейшего уточнения заводим цикл
            // цикл должен завершаться, когда разница между результатом и предположением 
            // меньше или равно дельте
            while (Math.Abs(result - guess) > delta)
            {
                // используем результат предыдущей итерации 
                // в качестве нового значения
                guess = result;
                // пробуем еще раз
                result = ((numberDecimal / guess) + guess) / 2;
            }

            // вывод результата
            newtonLabel.Content = string.Format("{0} (Using Newton)", result);
        }
    }
}
