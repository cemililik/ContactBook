using ContactBook.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int Authentication(string userName, string pass)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pass))
            {
                return dll.Authentication(new Entities.users()
                {
                    userName = userName,
                    pass = pass
                });

            }
            else
                return -1;
        }

        public int addRecord(string cName, string cSurname, string numberI, string numberII, string numberIII, string emailAdress, string webAdress, string adress, string info)
        {
            if (!string.IsNullOrEmpty(cName) && !string.IsNullOrEmpty(cSurname) && !string.IsNullOrEmpty(numberI))
            {
                    return dll.addContact(new Entities.contacts()
                {
                    id = Guid.NewGuid(),
                    cName = cName,
                    cSurname=cSurname,
                    numberI=numberI,
                    numberII=numberII,
                    numberIII=numberIII,
                    emailAdress=emailAdress,
                    webAdress=webAdress,
                    adress=adress,
                    info=info
                });
            }
            else
                return -1;
        }

        public int updateRecord(Guid id, string cName, string cSurname, string numberI, string numberII, string numberIII, string emailAdress, string webAdress, string adress, string info)
        {
            if (id != Guid.Empty)
            {
                return dll.updateContact(new Entities.contacts()
                {
                    id = id,
                    cName = cName,
                    cSurname = cSurname,
                    numberI = numberI,
                    numberII = numberII,
                    numberIII = numberIII,
                    emailAdress = emailAdress,
                    webAdress = webAdress,
                    adress = adress,
                    info = info
                });
            }
            else return -1;
        }

        public int deleteContact(Guid id)
        {
            if (id != Guid.Empty)
            {
                return dll.deleteContact(id);
            }
            else return -1;
        }

        public List<contacts> listContact()
        {
            List<contacts> contactList = new List<contacts>(); 
            try
            {
                SqlDataReader reader = dll.listContact();
                while (reader.Read())
                {
                    contactList.Add(new contacts()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        cName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        cSurname = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        numberI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        numberII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        numberIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        emailAdress = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        webAdress = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        adress = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        info = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dll.SetConnection();
            }
            return contactList;
        }

        public contacts listContactId(Guid id)
        {
            contacts contactListId = new contacts();
            try
            {
                SqlDataReader reader = dll.listContactId(id);
                while (reader.Read())
                {
                    contactListId = new contacts()
                    {
                        id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        cName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        cSurname = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        numberI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        numberII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        numberIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        emailAdress = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        webAdress = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        adress = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        info = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dll.SetConnection();
            }
            return contactListId;
        }

    }
}
