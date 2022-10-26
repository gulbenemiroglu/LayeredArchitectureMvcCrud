using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHastaneService
    {
        public List<Hastane> HastaneListele();
        public int HastaneEkle(Hastane p);
        public int HastaneGuncelle(Hastane p);
        public int HastaneSil(Hastane p);
    }
}
