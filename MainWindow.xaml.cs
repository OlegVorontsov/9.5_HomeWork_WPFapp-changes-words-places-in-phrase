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

namespace _9._5_HomeWork_WPFapp_changes_words_places_in_phrase
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

        /// <summary>
        /// Метод разделения фразы на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static private string[] Reverse(string text)
        {
            string[] Words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Words;
        }

        private void buttonSplitPhrase_Click(object sender, RoutedEventArgs e)
        {
            string[] Words = Reverse(phraseInput.Text);

            foreach (var item in Words)
            {
                phraseSplitter.Items.Add(item);
            }
        }

        private void buttonReversePhrase_Click(object sender, RoutedEventArgs e)
        {
            string[] Words = Reverse(phraseInput.Text);

            string outputPhrase = "";

            for (int i = Words.GetLength(0) - 1; i >= 0; i--)
            {
                outputPhrase += Words[i] + " ";
            }
            phraseReverser.Content = outputPhrase;
        }
    }
}
