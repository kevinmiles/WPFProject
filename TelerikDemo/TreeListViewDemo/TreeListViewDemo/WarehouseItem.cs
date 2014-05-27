﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeListViewDemo
{
    public class WarehouseItem
    {
        public WarehouseItem(string name, int count, bool isenable = true)
        {
            this.Name = name;
            this.Count = count;
            this.Items = new ObservableCollection<WarehouseItem>();
            this.IsEnable = isenable;
        }
        public string Name { get; set; }
        public ObservableCollection<WarehouseItem> Items { get; set; }
        public int Count { get; set; }
        public bool IsEnable { get; set; }
    }

    public class WarehouseService
    {
        public static ObservableCollection<WarehouseItem> GetWarehouseData()
        {
            ObservableCollection<WarehouseItem> data = new ObservableCollection<WarehouseItem>();
            WarehouseItem drinks = new WarehouseItem("Drinks", 35);
            drinks.Items.Add(new WarehouseItem("Water", 10));
            WarehouseItem tea = new WarehouseItem("Tea", 20);
            tea.Items.Add(new WarehouseItem("Black", 10, false));
            tea.Items.Add(new WarehouseItem("Green", 10));
            drinks.Items.Add(tea);
            drinks.Items.Add(new WarehouseItem("Coffee", 5));
            data.Add(drinks);
            WarehouseItem vegetables = new WarehouseItem("Vegeatbles", 75);
            vegetables.Items.Add(new WarehouseItem("Tomato", 40));
            vegetables.Items.Add(new WarehouseItem("Carrot", 25));
            vegetables.Items.Add(new WarehouseItem("Onion", 10));
            data.Add(vegetables);
            WarehouseItem fruits = new WarehouseItem("Fruits", 55);
            fruits.Items.Add(new WarehouseItem("Cherry", 30));
            fruits.Items.Add(new WarehouseItem("Apple", 20));
            fruits.Items.Add(new WarehouseItem("Melon", 5));
            data.Add(fruits);
            return data;
        }
    }
}
