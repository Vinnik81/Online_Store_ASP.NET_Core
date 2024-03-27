using OnlineStore.DataAccess.Data;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _context;

        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);

            //var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == orderDetail.Id);
            //if (categoryDB != null)
            //{
            //    categoryDB.Name = orderDetail.Name;
            //    categoryDB.DisplayOrder = orderDetail.DisplayOrder;
            //}
        }
    }
}
