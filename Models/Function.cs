using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Clinic_Management_System.Models
{
    public class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;

        public Function() 
        {
            Constr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=clinic;Integrated Security=True";
            con=new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public int SetDatas(string sql)
        {
            int cnt = 0;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = sql;
            cnt = cmd.ExecuteNonQuery();    
            con.Close();
            return cnt;
        }

        public DataTable GetDatas(string query) 
        {
            dt=new DataTable();
            sda = new SqlDataAdapter(query, Constr);
            sda.Fill(dt);
            return dt;

        }
    }
}