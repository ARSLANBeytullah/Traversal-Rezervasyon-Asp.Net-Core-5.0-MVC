using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id); //Onay Bekleyen Rezervasyon için tanımlanan method imzası 
        List<Reservation> GetListWithReservationByAccepted(int id); //Onaylanmış Rezervasyon için tanımlanan method imzası 
        List<Reservation> GetListWithReservationByPrevious(int id); // Önceki Rezervasyon için tanımlanan method imzası 
    }
}
