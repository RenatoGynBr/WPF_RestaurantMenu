using System;
using System.ComponentModel;

namespace WPF_RestaurantMenu.Models
{
    public class MenuItemModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MenuItemModel()
        {
        }
        public MenuItemModel(int id, string name, bool active, decimal price)
        {
            try
            {
                IdMenuItem = id;
                Name = name;
                Active = active;
                Price = price;

            }
            catch (Exception)
            {

            }
        }

        private int _idMenuItem;
        private string _name { get; set; }
        private decimal _price { get; set; }
        private bool _active { get; set; }

        public int IdMenuItem
        {
            get { return _idMenuItem; }
            set
            {
                if (_idMenuItem != value)
                {
                    _idMenuItem = value;
                    OnPropertyChanged("IdMenuItem");
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        public bool Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    OnPropertyChanged("Active");
                }
            }
        }
    }
}
