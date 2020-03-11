using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._CommonSteps
{
    public class Order
    {
        public long Id { get; private set; }
        public string OrderType { get; set; }
        public List<string> Items { get; }

        public Order(long id, string orderType, List<string> items)
        {
            this.Id = id;
            this.OrderType = orderType;
            this.Items = new List<string>(items);
        }
        public void AddNewItem(string item) 
        {
            this.Items.Add(item);
        }
    }
}
