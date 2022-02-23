using System.Collections.ObjectModel;
using WPF_RestaurantMenu.Models;

namespace WPF_RestaurantMenu.ViewModels
{
    public class MenuItemViewModel : ObservableCollection<MenuItemModel>
    {
        public MenuItemViewModel()
        {
            FillMenuItemCollection();
        }

        private void FillMenuItemCollection()
        {
            var m1 = new MenuItemModel(1, "Coke", true, 8);
            Add(m1);
            var m2 = new MenuItemModel(2, "Diet Coke", true, 8);
            Add(m2);
            var m3 = new MenuItemModel(3, "Fries", true, 17);
            Add(m3);
            var m4 = new MenuItemModel(4, "Big Burger", true, 29);
            Add(m4);
            var m5 = new MenuItemModel(5, "Salad", true, 22);
            Add(m5);
            var m6 = new MenuItemModel(6, "Deserts", false, 19);
            Add(m6);
            var m7 = new MenuItemModel(7, "Coffee Cream", true, 14);
            Add(m7);
            var m8 = new MenuItemModel(8, "Hot Chocolate", true, 15);
            Add(m8);
        }
    }
}
