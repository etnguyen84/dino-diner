﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
/*
* Order.cs
* Author: Ethan Nguyen
*/
namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {

        //public ObservableCollection<IOrderItem> Items { get; set; }
        /// <summary>
        /// represents items added to the order
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); } }
        /// <summary>
        /// background variable that represents items added to the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            items.Add(item);
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("Items");
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
                NotifyOfPropertyChanged("TotalCost");
                NotifyOfPropertyChanged("Items");
            }
            return removed;
        }


        /// <summary>
        /// getter that calculates total price from the prices of all order items
        /// </summary>
        public double SubtotalCost { 
            get
            {
                double cost = 0;
                foreach (IOrderItem item in Items)
                {
                    cost += item.Price;
                }

                if (cost < 0)
                {
                    return 0;
                } else
                {
                    return cost;
                }
            }
        }

        /// <summary>
        /// getter and protected setter for the current sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// getter sales tax cost calculated from current sales tax rate and subtotal cost
        /// </summary>
        public double SalesTaxCost { 
            get
            {
                return SalesTaxRate * SubtotalCost;

            }
        }

        /// <summary>
        /// getter to get the total cost of the ordre
        /// </summary>
        public double TotalCost { 
            get
            {
                return SalesTaxCost + SubtotalCost;
            }

        }

        /// <summary>
        /// constructor for an order object, takes the taxRate for the order as a parameter
        /// </summary>
        public Order()
        {
            //Items = new ObservableCollection<IOrderItem>();
            items = new List<IOrderItem>();
            //this.items.CollectionChanged += this.OnCollectionChanged;
            SalesTaxRate = .10;
        }
        /// <summary>
        /// event for when property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        /// <summary>
        /// Helper method that invokes a new propertychanged event
        /// </summary>
        /// <param name="propertyName"> property that is being changed</param>
        public void NotifyOfPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


    }
}
