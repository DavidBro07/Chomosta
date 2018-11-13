using ChomostasApp.DB.Context;
using System.Collections.Generic;

namespace ChomostasApp.DB.DAO.Interfaces
{
    public interface ITablaPruebaDAO : IBaseDao
    {
        List<TablaPrueba> findAll();
    }
}
