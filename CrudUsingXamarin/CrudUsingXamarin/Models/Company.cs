using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsingXamarin.Models
{
    public class Company
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.Address + ")";
        }
    }
}
