using OnlineStore.DataAccess.Data;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repositories
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUser
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
        public void Update(ApplicationUser applicationUser)
        {
            var userDb = _context.ApplicationUsers.FirstOrDefault(x => x.Id == applicationUser.Id);
            if (userDb != null)
            {
                userDb.Name = applicationUser.Name;
                userDb.PhoneNumber = applicationUser.PhoneNumber;
                userDb.Address = applicationUser.Address;
                userDb.City = applicationUser.City;
                userDb.State = applicationUser.State;
                userDb.PinCode = applicationUser.PinCode;

                _context.Entry(userDb).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }
    }
}
