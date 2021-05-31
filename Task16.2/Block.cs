using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16._2
{
    class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block p = (Block)obj;
            return (Id == p.Id) && (Name == p.Name) && (Email == p.Email) && (City == p.City);
        }
        public override string ToString()
        {
            return $"Id = {Id},Name = {Name}, Email = {Email}, City = {City}";
        }
    }
}
