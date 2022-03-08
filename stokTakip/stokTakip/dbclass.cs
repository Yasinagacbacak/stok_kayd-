using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace stokTakip
{
    class sqlBaglantisi
    {
        
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-L6BKOKP\TEW_SQLEXPRESS;Initial Catalog=STOK;Integrated Security=True");

            baglan.Open();
            return baglan;
        }

    }
}
