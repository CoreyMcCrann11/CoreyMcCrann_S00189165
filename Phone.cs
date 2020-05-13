using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace CoreyMcCrann_S00189165
{
    public class Phone
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Operating_System { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

        public int PhoneID { get; set; }

        /* public void IncreasePrice()
        {
            decimal percentage = 0;
            decimal price = 0;

            price = price * percentage;

        }
        */

        public override string ToString()
        {
            return this.Name;
        }


    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }


}
