using ChomostasApp.DB.Context;
using ChomostasApp.DB.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChomostasApp.DB.DAO
{
    public class TablaPruebaDAO : BaseDao, ITablaPruebaDAO
    {
        public TablaPruebaDAO(ChomostaAppContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public List<TablaPrueba> findAll()
        {
            return applicationDbContext.TablaPrueba.ToList();        
        }
    }
}
