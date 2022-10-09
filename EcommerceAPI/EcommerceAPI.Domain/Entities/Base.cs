using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Entities
{
    public class Base
    {
        private int _id;

        public int Id { get => _id; set => _id = value; }
    }
}
