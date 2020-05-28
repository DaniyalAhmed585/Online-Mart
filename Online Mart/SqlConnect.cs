using System;
using System.Data.SqlClient;

namespace Online_Mart
{
    internal class SqlConnect
    {
        public static implicit operator SqlConnect(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}