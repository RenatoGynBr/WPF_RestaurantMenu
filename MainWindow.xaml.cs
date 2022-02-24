using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using WPF_RestaurantMenu.Models;

namespace WPF_RestaurantMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //lstItems.Items.Add("New");
            //MessageBox.Show("To be added: " + txtIdMenuItem.Text + ":" + txtName.Text, "Message");
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = "Message: UPDATED";
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = lstItems.Items.CurrentItem;
            if (currentItem != null)
            {
                //var list = lstItems;
                //list.Items.Remove(currentItem);
                //lstItems.ItemsSource = list.ItemsSource;
                //MessageBox.Show("To be deleted: " + txtIdMenuItem.Text + ":" + txtName.Text, "Message");
            }
        }
    }
}
