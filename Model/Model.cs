using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string orderDay;
        string country;
        string customerName;
        double? unitPrice;

        [Display(Name="Order ID")]
        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        [Display(Name = "Customer ID")]
        public string OrderDay
        {
            get { return orderDay; }
            set
            {
                orderDay = value;
                OnPropertyChanged("CustomerID");
            }
        }

        [Display(Name = "Customer Name")]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        [Display(Name = "Country")]
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        [Display(Name = "Unit Price")]
        public double? UnitPrice
        {
            get { return unitPrice; }
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

      
    

