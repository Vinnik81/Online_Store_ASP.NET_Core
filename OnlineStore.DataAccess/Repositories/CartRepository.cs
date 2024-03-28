using OnlineStore.DataAccess.Data;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

		public void DecrementCartItem(Cart cart, int count)
		{
			if (cart != null)
			{
				if (cart.Count <= 0)
				{
					cart.Count = 0;
				}
				else
				{
					cart.Count -= count;
				}
				Update(cart);
			}
		}

		public void IncrementCount(Cart cart, int count)
        {
            if (cart != null)
            {
                if (cart.Count <= 0)
                {
                    cart.Count = 0;
                }
                else
                {
                    cart.Count += count;
                }
                Update(cart);
            }
        }

        public void Update(Cart cart)
        {
            var cartDb = _context.Carts.FirstOrDefault(x => x.Id == cart.Id);
            if (cartDb != null)
            {
                cartDb.Count = cart.Count;
            }
        }
    }
}
