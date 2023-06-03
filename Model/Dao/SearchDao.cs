using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class SearchDao
    {
        TruyenOnlineDbContext db = null;
        public SearchDao()
        {
            db = new TruyenOnlineDbContext();
        }
       
        // list category
        public List<Truyen> getSearchBook(string searchString)
        {
            System.Diagnostics.Debug.WriteLine(searchString);
            var list = db.Truyens.Where(t=>t.Ten_Truyen.Contains(searchString)|| t.MetaTitle.Contains(searchString)).ToList();
            return list;
        }
    }
}
