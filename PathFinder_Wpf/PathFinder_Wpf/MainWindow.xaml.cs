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
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);
            ///  this.CommandBindings.Add(copyCommand);
            /// copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);
            
           
        }

        void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy Executed!");
        }
       
        private void setImage(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {
            TextBlock myText = new TextBlock();
            string myString = "18";
            myText.Text = myString;       
            TextBlock.SetForeground(myText, Brushes.White);
        }
    }
}
