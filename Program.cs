using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListAllTitles();



            //Titles t = new Titles() { titleid = "CS01", titlename = "CSharp Programming", price = 350 };
            //InsertTitleData(t);

            Console.Read();




        }

        private static void InsertTitleData(Titles t)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SV06A6\\sqlexpress;Initial Catalog=pubs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("[dbo].[InsertTitle]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_titleid", t.titleid);
            cmd.Parameters.AddWithValue("@p_titlename", t.titlename);
            cmd.Parameters.AddWithValue("@p_price", t.price);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        private static void ListAllTitles()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SV06A6\\sqlexpress;Initial Catalog=pubs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from titles", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();//reads only one single row at a time
            Console.Write("{0,-10}", "TitleID |");
            Console.Write("{0,-50}", "TitleName |");
            Console.Write("{0,-95}", "Price |");
            Console.WriteLine();
            while (dr.Read())
            {
                Console.Write("{0,-20}", dr["title_id"]);
                Console.Write("{0,-50}", dr["title"]);
                Console.Write("{0,-95}", dr["price"]);
                Console.WriteLine();
              

            }

            conn.Close();
            conn.Dispose();
        }
    }
}
