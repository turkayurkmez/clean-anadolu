using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public  class DbHelper
    {
        public int ExecuteNonQuery(string query, Dictionary<string,object> parameters)
        {
            /* SqlConnection connection = new SqlConnection("connectionString");
             * SqlCommand command = new SqlCommand(query, connection);
             * command.Connection.Open();
             * int affectedRows = command.ExecuteNonQuery();
             * command.Connection.Close();
            */
            return 1;
        }
    }
}
