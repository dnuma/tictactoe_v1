//Author: David Numa

using System.Windows;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        /// <summary>
        /// Main function, executed each time the user clicks on a button to do a move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedElement = SelectedElement(sender);
            vm.Player1Turn(selectedElement);
        }

        /// <summary>
        /// Find the selected button then return the string to identify the element
        /// </summary>
        /// <param name="sender"> button selected </param>
        /// <returns> element selected </returns>
        private string SelectedElement(object sender)
        {
            if (sender.Equals(button00)) return "pos00";
            else if (sender.Equals(button01)) return "pos01";
            else if (sender.Equals(button02)) return "pos02";
            else if (sender.Equals(button10)) return "pos10";
            else if (sender.Equals(button11)) return "pos11";
            else if (sender.Equals(button12)) return "pos12";
            else if (sender.Equals(button20)) return "pos20";
            else if (sender.Equals(button21)) return "pos21";
            else return "pos22";
        }

        /// <summary>
        /// Call the MVVM method to start a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            vm.NewGame();
        }
    }
}