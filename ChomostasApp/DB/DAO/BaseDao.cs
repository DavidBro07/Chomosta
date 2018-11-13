using ChomostasApp.DB.Context;
using ChomostasApp.DB.DAO.Interfaces;

namespace ChomostasApp.DB.DAO
{
    public class BaseDao : IBaseDao
    {
        protected ChomostaAppContext applicationDbContext;
        public BaseDao(ChomostaAppContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int SaveChanges()
        {
            int result = applicationDbContext.SaveChanges();
            return result;
        }
    }
}
