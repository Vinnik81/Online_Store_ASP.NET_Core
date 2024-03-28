using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.ViewModels
{
    public class CartVM
    {
        public OrderHeader OrderHeader { get; set; }
        public IEnumerable<Cart> ListOfCart { get; set; } = new List<Cart>();
    }
}
