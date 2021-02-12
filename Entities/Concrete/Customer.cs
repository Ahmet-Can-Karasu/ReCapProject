using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntiti
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
