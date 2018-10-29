using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ContactClassLibrary
{
    public class ContactLayer
    {
        public IEnumerable<Contact> GetContacts
        {
            get
            {
                string connectionString =
                ConfigurationManager.ConnectionStrings["DBase"].ConnectionString;

                List<Contact> contacts = new List<Contact>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllContacts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Contact contact = new Contact();
                        contact.ID = Convert.ToInt32(rdr["Id"]);
                        contact.firstName = rdr["FirstName"].ToString();
                        contact.lastName = rdr["LastName"].ToString();
                        contact.gender = rdr["Gender"].ToString();
                        contact.phoneNumber = rdr["PhoneNumber"].ToString();
                        contact.emailAddress = rdr["EmailAddress"].ToString();
                        contact.city = rdr["City"].ToString();

                        contacts.Add(contact);
                    }
                }

                return contacts;

            }
        }

        public void saveContact(Contact contact)
        {
            string connectionString =
          ConfigurationManager.ConnectionStrings["DBase"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddContact", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@fstname";
                paramName.Value = contact.firstName;
                cmd.Parameters.Add(paramName);

                SqlParameter paramlastName = new SqlParameter();
                paramlastName.ParameterName = "@lstname";
                paramlastName.Value = contact.lastName;
                cmd.Parameters.Add(paramlastName);

                SqlParameter paramGender = new SqlParameter();
                paramGender.ParameterName = "@Gender";
                paramGender.Value = contact.gender;
                cmd.Parameters.Add(paramGender);

                SqlParameter paramNumber = new SqlParameter();
                paramNumber.ParameterName = "@phonenumber";
                paramNumber.Value = contact.phoneNumber;
                cmd.Parameters.Add(paramNumber);

                SqlParameter paramEmail = new SqlParameter();
                paramEmail.ParameterName = "@emailAddress";
                paramEmail.Value = contact.emailAddress;
                cmd.Parameters.Add(paramEmail);

                SqlParameter paramCity = new SqlParameter();
                paramCity.ParameterName = "@City";
                paramCity.Value = contact.city;
                cmd.Parameters.Add(paramCity);

                

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EditContact(int id,Contact contact)
        {
            string connectionString =
          ConfigurationManager.ConnectionStrings["DBase"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAditContact", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramID = new SqlParameter();
                paramID.ParameterName = "@ID";
                paramID.Value = id;
                cmd.Parameters.Add(paramID);

                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@fstname";
                paramName.Value = contact.firstName;
                cmd.Parameters.Add(paramName);

                SqlParameter paramlastName = new SqlParameter();
                paramlastName.ParameterName = "@lstname";
                paramlastName.Value = contact.lastName;
                cmd.Parameters.Add(paramlastName);

                SqlParameter paramGender = new SqlParameter();
                paramGender.ParameterName = "@Gender";
                paramGender.Value = contact.gender;
                cmd.Parameters.Add(paramGender);

                SqlParameter paramNumber = new SqlParameter();
                paramNumber.ParameterName = "@phonenumber";
                paramNumber.Value = contact.phoneNumber;
                cmd.Parameters.Add(paramNumber);

                SqlParameter paramEmail = new SqlParameter();
                paramEmail.ParameterName = "@emailAddress";
                paramEmail.Value = contact.emailAddress;
                cmd.Parameters.Add(paramEmail);

                SqlParameter paramCity = new SqlParameter();
                paramCity.ParameterName = "@City";
                paramCity.Value = contact.city;
                cmd.Parameters.Add(paramCity);



                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteContact(int id)
        {
            string connectionString =
          ConfigurationManager.ConnectionStrings["DBase"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteContact", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramID = new SqlParameter();
                paramID.ParameterName = "@ID";
                paramID.Value = id;
                cmd.Parameters.Add(paramID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
