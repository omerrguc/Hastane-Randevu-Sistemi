using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
     class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=OMERGUC\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open();
            return baglan;
        
        
        }
    }
}
