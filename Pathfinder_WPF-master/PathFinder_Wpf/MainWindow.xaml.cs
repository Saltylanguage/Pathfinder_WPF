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

            CommandBinding cutCommand = new CommandBinding(ApplicationCommands.Cut);
            this.CommandBindings.Add(cutCommand);
            cutCommand.Executed += new ExecutedRoutedEventHandler(cutCommand_Executed);

            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);
            this.CommandBindings.Add(copyCommand);
            copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);

            CommandBinding pasteCommand = new CommandBinding(ApplicationCommands.Paste);
            this.CommandBindings.Add(pasteCommand);
            pasteCommand.Executed += new ExecutedRoutedEventHandler(pasteCommand_Executed);

            CommandBinding newCharCommand = new CommandBinding(ApplicationCommands.New);
            this.CommandBindings.Add(newCharCommand);
            newCharCommand.Executed += new ExecutedRoutedEventHandler(newCharCommand_Executed);

            CommandBinding loadCharCommand = new CommandBinding(ApplicationCommands.Open);
            this.CommandBindings.Add(loadCharCommand);
            loadCharCommand.Executed += new ExecutedRoutedEventHandler(loadCharCommand_Executed);

            CommandBinding quitCommand = new CommandBinding(ApplicationCommands.Close);
            this.CommandBindings.Add(quitCommand);
            quitCommand.Executed += new ExecutedRoutedEventHandler(quitCommand_Executed);
                  
           /// CommandBinding customCommand = new CommandBinding();
           /// this.CommandBindings.Add(customCommand);
           /// customCommand = new CommandBinding(CommandBindings.customCommand);
           /// customCommand.Executed += new ExecutedRoutedEventHandler(customCommand_Executed);
            
        }
        
        void customCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Custom Command Executed!");
        }
        

        void cutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Cut Executed!");
        }

        void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy Executed!");
        }

        void pasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Paste Executed");
        }

        void newCharCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("New Char Executed!");
        }

        void loadCharCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Load Char Executed");
        }

        void quitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Quit Executed");
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
