using ContactBook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int ReturnValues;

        public DLL()
        {
            con = new SqlConnection("Data Source=DESKTOP-04SEUSQ;Initial Catalog=ContactBook;Integrated Security=True");
        }
        public void SetConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
                con.Close();
        }

        public int Authentication(users u)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from users where userName = @userName and pass = @pass", con);
                cmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = u.userName;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = u.pass;
                SetConnection();
                ReturnValues = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                SetConnection();
            }
            return ReturnValues;
        }

        public int addContact(contacts c)
        {
            try
            {
                //SetConnection();
                cmd = new SqlCommand("insert into contacts (id,cName,cSurname,numberI,numberII,numberIII,emailAdress,webAdress,adress,info) values (@ID,@cName,@cSurname,@numberI,@numberII,@numberIII,@emailAdress,@webAdress,@adress,@info)", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = c.id;
                cmd.Parameters.Add("@cName", SqlDbType.NVarChar).Value = c.cName;
                cmd.Parameters.Add("@cSurname", SqlDbType.NVarChar).Value = c.cSurname;
                cmd.Parameters.Add("@numberI", SqlDbType.NVarChar).Value = c.numberI;
                cmd.Parameters.Add("@numberII", SqlDbType.NVarChar).Value = c.numberII;
                cmd.Parameters.Add("@numberIII", SqlDbType.NVarChar).Value = c.numberIII;
                cmd.Parameters.Add("@emailAdress", SqlDbType.NVarChar).Value = c.emailAdress;
                cmd.Parameters.Add("@webAdress", SqlDbType.NVarChar).Value = c.webAdress;
                cmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = c.adress;
                cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = c.info;
                SetConnection();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SetConnection();
            }
            return ReturnValues; 
        }

        public int updateContact(contacts c)
        {
            try
            {
                cmd = new SqlCommand(@"update contacts
Set
cName = @cName,
cSurname = @cSurname,
numberI = @numberI,
numberII = @numberII,
numberIII = @numberIII,
emailAdress = @emailAdress,
webAdress = @webAdress,
adress = @adress,
info = @info
where 
id= @id
", con);
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = c.id;
                cmd.Parameters.Add("@cName", SqlDbType.NVarChar).Value = c.cName;
                cmd.Parameters.Add("@cSurname", SqlDbType.NVarChar).Value = c.cSurname;
                cmd.Parameters.Add("@numberI", SqlDbType.NVarChar).Value = c.numberI;
                cmd.Parameters.Add("@numberII", SqlDbType.NVarChar).Value = c.numberII;
                cmd.Parameters.Add("@numberIII", SqlDbType.NVarChar).Value = c.numberIII;
                cmd.Parameters.Add("@emailAdress", SqlDbType.NVarChar).Value = c.emailAdress;
                cmd.Parameters.Add("@webAdress", SqlDbType.NVarChar).Value = c.webAdress;
                cmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = c.adress;
                cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = c.info;
                SetConnection();
                ReturnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SetConnection();
            }
            return ReturnValues;
        }

        public int deleteContact(Guid id)
        {
            try
            {
                cmd = new SqlCommand(@"delete contacts 
where id = @id", con);
                cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
                SetConnection();
                ReturnValues = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                SetConnection();
            }
            return ReturnValues;
        }

        public SqlDataReader listContact()
        {
            cmd = new SqlCommand("select * from contacts", con);
            SetConnection();
            return cmd.ExecuteReader();
        }

        public SqlDataReader listContactId(Guid id)
        {
            cmd = new SqlCommand("select * from contacts where id=@id", con);
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
            SetConnection();
            return cmd.ExecuteReader();
        }
    }
}
