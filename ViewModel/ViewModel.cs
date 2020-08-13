using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo() { OrderID = 1001, CustomerName = "Maria Anders", Country="Germany", OrderDay = "Tuesday", UnitPrice = 10700 });
            _orders.Add(new OrderInfo() { OrderID = 1002, CustomerName = "Ana Trujilo", Country = "Mexico", OrderDay = "Thursday", UnitPrice = 36000 });
            _orders.Add(new OrderInfo() { OrderID = 1003, CustomerName = "Antonio Moreno", Country = "Mexico", OrderDay = "Today", UnitPrice = 40040 });
            _orders.Add(new OrderInfo() { OrderID = 1004, CustomerName = "Thomas Hardy", Country = "UK", OrderDay = "T1000", UnitPrice=10700});
            _orders.Add(new OrderInfo() { OrderID = 1005, CustomerName="Christina Berglund", Country = "Sweden", OrderDay = "T2000", UnitPrice=20300 });
            _orders.Add(new OrderInfo() { OrderID = 1006, CustomerName = "Hanna Moos", Country = "Germany", OrderDay = "T3000", UnitPrice = 10700 });
            _orders.Add(new OrderInfo() { OrderID = 1007, CustomerName = "Frederique Citeaux", Country = "France", OrderDay = "T4000", UnitPrice = 10700 });
            _orders.Add(new OrderInfo() { OrderID = 1008, CustomerName = "Martin Sommer", Country = "Spain", OrderDay = "Sunday", UnitPrice = 35000 });
            _orders.Add(new OrderInfo() { OrderID = 1009, CustomerName = "Laurence Lebihan", Country = "France", OrderDay = "Saturday", UnitPrice = 20030 });
            _orders.Add(new OrderInfo() { OrderID = 1010, CustomerName = "Elizabeth Lincoln", Country = "Canada", OrderDay = "Thisday", UnitPrice = 54000 });

        }
    }
}
            
        
     

