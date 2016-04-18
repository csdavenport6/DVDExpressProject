using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using DVDExpressProject.Classes;

namespace DVDExpressProject.DataLayer
{
    class MemberDL
    {
        // Members
        private static string connectionString = ConfigurationManager.ConnectionStrings["S2T5"].ConnectionString;
        // Properties
        public static string ConnectionString
        {
            get { return MemberDL.connectionString; }
            set { MemberDL.connectionString = value; }
        }
        public static List<Member> GetMemberList()
        {
            string sqlText;

            sqlText = "SELECT *";
            sqlText += "FROM Member";

            List<Member> memList = new List<Member>();

            if (connectionString == string.Empty)
                throw new ArgumentException("EmployeeDL.ConnectionString property is empty.");

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlText, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member member = new Member();
                if (reader.IsDBNull(0) == false)
                {
                    member.MemID = reader.GetInt32(0);
                }

                if (reader.IsDBNull(1) == false)
                {
                    member.Username = reader.GetString(1);
                }

                if (reader.IsDBNull(2) == false)
                {
                    member.Password = reader.GetString(2);
                }

                if (reader.IsDBNull(3) == false)
                {
                    member.FirstName = reader.GetString(3);
                }

                if (reader.IsDBNull(4) == false)
                {
                    member.LastName = reader.GetString(4);
                }

                if (reader.IsDBNull(5) == false)
                {
                    member.DOB = reader.GetDateTime(5);
                }

                if (reader.IsDBNull(6) == false)
                {
                    member.Address1 = reader.GetString(6);
                }

                if (reader.IsDBNull(7) == false)
                {
                    member.Address2 = reader.GetString(7);
                }

                if (reader.IsDBNull(8) == false)
                {
                    member.City = reader.GetString(8);
                }

                if (reader.IsDBNull(9) == false)
                {
                    member.ZIP = reader.GetInt32(9);
                }

                if (reader.IsDBNull(10) == false)
                {
                    member.Phone = reader.GetString(10);
                }

                if (reader.IsDBNull(11) == false)
                {
                    member.MemStatus = reader.GetString(11);
                }

                if (reader.IsDBNull(12) == false)
                {
                    member.CreditCardNo = reader.GetInt32(12);
                }

                if (reader.IsDBNull(13) == false)
                {
                    member.Balance = reader.GetDouble(13);
                }

                memList.Add(member);
            }

            reader.Close();
            command.Dispose();
            connection.Close();

            return memList;
        }


    }
}
