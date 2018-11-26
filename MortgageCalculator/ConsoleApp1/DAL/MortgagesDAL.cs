using MortgageCalculator;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MortgageCalculator
{
    public class MortgagesDAL : IMortgagesDAL
    {
        private string connectionString = (@"Data Source=.\sqlexpress;Initial Catalog=MortgageCalculator;Integrated Security=true;");

        public MortgagesDAL()
        {
        }
        public IList<Mortgage> GetAllMortgages()
        {
            List<Mortgage> output = new List<Mortgage>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create a command
                    SqlCommand command = new SqlCommand("SELECT * FROM mortgages;", conn);

                    // Execute the command
                    SqlDataReader reader = command.ExecuteReader();

                    // Loop through each row
                    while (reader.Read())
                    {
                        Mortgage mortgage = ConvertRowToMortgage(reader);
                        output.Add(mortgage);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error reading mortgage data.");
                throw;
            }
            return output;
        }

        private static Mortgage ConvertRowToMortgage(SqlDataReader reader)
        {
            Mortgage mortgage = new Mortgage();
            mortgage.MortgageId = Convert.ToInt32(reader["mortgage_Id"]);
            mortgage.PurchasePrice = Convert.ToDouble(reader["purchase_price"]);
            mortgage.DownPayment = Convert.ToDouble(reader["down_payment"]);
            mortgage.InterestRate = Convert.ToDouble(reader["interest_rate"]);
            mortgage.TermLength = Convert.ToInt32(reader["term_length"]);
            mortgage.Taxes = Convert.ToDouble(reader["taxes"]);
            mortgage.Insurance = Convert.ToDouble(reader["insurance"]);
            mortgage.Payment = Convert.ToDouble(reader["payment"]);
            return mortgage;
        }

        public void SubmitMortgage(Mortgage mortgage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO mortgages VALUES (@Address_Id, @Purchase_Price, @Down_Payment, @Interest_Rate, @Term_Length, @Taxes, @Insurance, @Payment, @UserName);", conn);
                    cmd.Parameters.AddWithValue("@Address_Id", mortgage.AddressId);
                    cmd.Parameters.AddWithValue("@Purchase_Price", mortgage.PurchasePrice);
                    cmd.Parameters.AddWithValue("@Down_Payment", mortgage.DownPayment);
                    cmd.Parameters.AddWithValue("@Interest_Rate", mortgage.InterestRate);
                    cmd.Parameters.AddWithValue("@Term_Length", mortgage.TermLength);
                    cmd.Parameters.AddWithValue("@Taxes", mortgage.Taxes);
                    cmd.Parameters.AddWithValue("@Insurance", mortgage.Insurance);
                    cmd.Parameters.AddWithValue("@Payment", mortgage.Payment);
                    cmd.Parameters.AddWithValue("@UserName", mortgage.UserName);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error reading mortgage data.");
                throw;
            }
        }

        public void SubmitAddress(Address address)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO city VALUES (@name, @countryCode, @district, @population);", conn);
                    cmd.Parameters.AddWithValue("@street", address.Street);
                    cmd.Parameters.AddWithValue("@city", address.City);
                    cmd.Parameters.AddWithValue("@userName", address.UserName);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error reading mortgage data.");
                throw;
            }
        }
    }
}
