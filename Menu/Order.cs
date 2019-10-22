using System;
using System.Collections.ObjectModel;
/*
 * Order.cs
 * Author: Ethan Nguyen
 */
namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// represents items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

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
            SalesTaxRate = .10;
        }
    }
}
