using System;
using System.Data.SqlClient;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                
                con = new SqlConnection(@"data source = (localdb\MSSQLLocalDB; database = Northwind; integrated security = SSPI");
                
                SqlCommand cm = new SqlCommand("select * from Employees", con);
                
                con.Open();
                
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["FirstName"] + " " + sdr["LastName"] + sdr["Title"] + " " + sdr["BirthDate"]);

                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong " + e);
            }
        }
    }
}
