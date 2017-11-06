﻿using System;
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
using System.Windows.Shapes;

namespace PharmacySystemClient
{
    /// <summary>
    /// Interaction logic for OrderPanel.xaml
    /// </summary>
    public partial class OrderPanel : Window
    {
        public OrderPanel()
        {
            InitializeComponent();
            DisplayProducts();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            UIRemote remote = new UIRemote();
            ViewMainMenu viewMenu = new ViewMainMenu();
            remote.SetCommand(viewMenu);
            remote.ExecuteCommand();
            this.Close();
        }

        private void DisplayProducts()
        {
            Order order = new Order();
            ProductResponse products = order.GetProducts();
            Console.WriteLine(products.Name);

            ProductList.Items.Add(products.Name);
            //ProductList.BeginUpdate;
        }
    }
}
