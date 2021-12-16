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


namespace Homework
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if(textBox!=null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox!=null)
            {

                textBox.FontSize = double.Parse(fontSize);
            }
        }
        private void ToolBar_Click(object sender, RoutedEventArgs eventArgs)
        {
            if (eventArgs.OriginalSource==bold)
            {
                if (textBox.FontWeight==FontWeights.Normal)
                {
                    textBox.FontWeight = FontWeights.Bold;
                    bold.Opacity = 0.5;
                }
                else
                { 
                    textBox.FontWeight = FontWeights.Normal;
                    bold.Opacity = 1;
                }
            }
            else if (eventArgs.OriginalSource == italic)
            {
                if (textBox.FontStyle==FontStyles.Normal)
                {
                    textBox.FontStyle = FontStyles.Italic;
                    italic.Opacity = 0.5;
                }
                else
                {
                    textBox.FontStyle = FontStyles.Normal;
                    italic.Opacity = 1;
                }
            }
            else if(eventArgs.OriginalSource == underline)
            {
                if (textBox.TextDecorations==TextDecorations.Baseline)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                    underline.Opacity = 0.5;
                }
                else
                {
                    textBox.TextDecorations = TextDecorations.Baseline;
                    underline.Opacity = 1;
                }
            }

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs arg)
        {

            if (textBox != null)
            {
              if (arg.OriginalSource == red)
                {
                    textBox.Foreground = Brushes.Red;
                }
            
                else
                {
                    textBox.Foreground = Brushes.Black;
                }
           }
            

        }

    }
}
