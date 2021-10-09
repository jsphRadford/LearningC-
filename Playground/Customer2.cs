using System.Collections.Generic;

namespace Playground
{
    partial class Program
    {
        public class Customer2
        {
            public int Id;
            public string Name;
            public readonly List<Order> Orders = new List<Order>();

            public Customer2(int id)
            {
                this.Id = id;
            }

            public Customer2(int id, string name) : this(id)
            {
                this.Name = name;
            }

            public void Promote()
            {
                
                //.....
            }

        }
    }
}
