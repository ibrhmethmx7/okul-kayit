using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class Connection
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
