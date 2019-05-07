using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoursAdoNet
{
    public class Connection
    {
        private static SqlConnection _instance = null;
        private static object __v = new object();
        public static SqlConnection Instance
        {
            get
            {
                lock(__v)
                {
                    if (_instance == null)
                        _instance = new SqlConnection(@"Data Source = (localDb)\CoursAdoNet; Integrated Security = True");
                    return _instance;
                }       
            }
        }
        private Connection()
        {

        }
    }
}
