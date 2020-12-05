using System.Windows;
using System.Windows.Controls;

namespace Resistor_Color_Code_Calculator
{
    public partial class MainWindow : Window
    {
        long firstBand;
        long secondBand;
        long thirdBand;

        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement element in LayoutRoot.Children)
            {
                if (element is Button button)
                {
                    if (float.TryParse(button.Content.ToString(), out _))
                        button.Click += Button_Click;
                }
            }
        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Укажите поочередно цвета всех колец слева на право, выбрав цвет из таблицы. Сопротивление резистора и допуск будет указан в поле вывода.");
        }
        private void ButtonSubstring_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text.Substring(0,textBlock.Text.Length - 1) ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string content = (string)button.Content;


            if (Grid.GetColumn(button) == 0)
            {
                firstBand = int.Parse(content);
                textBlock.Text += content;
            }
            else if (Grid.GetColumn(button) == 1)
            {
                secondBand = int.Parse(content);
                secondBand = int.Parse(firstBand.ToString() + secondBand.ToString());
                textBlock.Text = secondBand.ToString();
            }
            else if (Grid.GetColumn(button) == 2)
            {
                button.IsEnabled = false;
            }
            else if (Grid.GetColumn(button) == 3)
            {
                textBlock.Text = string.Empty;
                thirdBand = int.Parse(content);
                textBlock.Text += $"{secondBand}*{thirdBand}";
            }
            else if (Grid.GetColumn(button) == 4)
            {

                textBlock.Text = string.Empty;
                string contenttwo = (string)button.Content;
                string tolerance = contenttwo;
                textBlock.Text += $"{UnitHelper.TruncateZeroes(thirdBand * secondBand)}Ω ±{tolerance}%";
            }
        }
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }
    }
}
