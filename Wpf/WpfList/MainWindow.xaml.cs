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

namespace WpfList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Go to shop", Completion = 100 });
            items.Add(new TodoItem() { Title = "Buy stuff", Completion = 10 });

            TodoListBox.ItemsSource = items;

           
            //List<Inimesed> inimesed = new List<Inimesed>();
            //inimesed.Add(new Inimesed() { Eesnimi = "Joel", Perekonnanimi = "Õispuu", Vanus = 17 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Kenno", Perekonnanimi = "Pajunurm", Vanus = 16 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Jasper", Perekonnanimi = "Noorkõiv", Vanus = 18 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Valdur", Perekonnanimi = "Puu", Vanus = 43 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Pede", Perekonnanimi = "Kas", Vanus = 21 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Silver", Perekonnanimi = "Barnabas", Vanus = 20 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Tom Kristian", Perekonnanimi = "Abel", Vanus = 19 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Kevin", Perekonnanimi = "Uueni", Vanus = 69 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Homo", Perekonnanimi = "Pea", Vanus = 15 });
            //inimesed.Add(new Inimesed() { Eesnimi = "Siim", Perekonnanimi = "Polütehnikum", Vanus = 17 });

            //InimesedBox.ItemsSource = inimesed;
        }

        private void todoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Title = (TodoListBox.SelectedItem as TodoItem).Title;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            if (TodoListBox.SelectedItem != null)
                MessageBox.Show((TodoListBox.SelectedItem as TodoItem).Title);
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            TodoListBox.SelectedIndex = TodoListBox.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((TodoListBox.SelectedIndex >= 0) && (TodoListBox.SelectedIndex < (TodoListBox.Items.Count - 1)))
            {
                nextIndex = TodoListBox.SelectedIndex + 1;
            }
            TodoListBox.SelectedIndex = nextIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                if ((item is TodoItem) && ((item as TodoItem).Title.Contains("C#")))
                {
                    TodoListBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in TodoListBox.Items)
            {
                TodoListBox.SelectedItems.Add(item);
            }
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }

    //public class Inimesed
    //{
    //    public string Eesnimi { get; set; }
    //    public string Perekonnanimi { get; set; }
    //    public int Vanus { get; set; }
    //}
}
