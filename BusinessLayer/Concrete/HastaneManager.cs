using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HastaneManager : IHastaneService
    {
        IHastaneDal _hastaneDal;
        public HastaneManager(IHastaneDal hastaneDal)
        {
            this._hastaneDal = hastaneDal;  
        }
        public List<Hastane> HastaneListele()
        {
            return _hastaneDal.List();
        }

        public int HastaneEkle(Hastane p)
        {
            if (p.HastaneAd.Length > 50)
            {
                return -1;
            }
            return _hastaneDal.Add(p);
        }

        public int HastaneGuncelle(Hastane p)
        {
            return _hastaneDal.Update(p);
        }

        public int HastaneSil(Hastane p)
        {
            return _hastaneDal.Delete(p);

        }
    }
}
