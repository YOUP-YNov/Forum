﻿using Forum.DAL.Data;
using Forum.DAL.Data.Mappeur;
using Forum.myDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Forum.DAL
{
    public class MessageDAL
    {
        string connexionstring = "data source=avip9np4yy.database.windows.net,1433;initial catalog=YoupDEV;persist security info=True;user id=youpDEV;password=youpD3VASP*;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection myConnection;
        public MessageDAL()
        {
            myConnection = new SqlConnection(connexionstring);
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public bool CreateMessage(MessageD mes)
        {
            using (ps_FOR_GetMessageTableAdapter MessageDal = new ps_FOR_GetMessageTableAdapter())
            {
                MessageDal.ps_FOR_CreateMessage(mes.Topic_id, mes.Utilisateur_id,mes.DatePoste,mes.ContenuMessage);
            }
                return true;
        }

        public bool EditMessage(MessageD mes)
        {
            using (ps_FOR_GetMessageTableAdapter MessageDal = new ps_FOR_GetMessageTableAdapter())
            {
                MessageDal.ps_FOR_UpdateMessage(mes.Message_id, mes.ContenuMessage);
            }
            return true;
        }

        public bool DeleteMessage(int id)
        {

            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = myConnection;
                    command.CommandText = "DELETE FROM FOR_Message WHERE Message_id = " + id;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MessageD> GetListTopicMessage(int idTopic)
        {

            myDataSet.ps_FOR_GetMessageDataTable datatable;

            using (ps_FOR_GetMessageTableAdapter MessageDal = new ps_FOR_GetMessageTableAdapter())
            {
                datatable = MessageDal.ps_FOR_GetListTopicMessage(idTopic);
            }
            return MessageMappeur.ToMessageD(datatable).ToList();
        }



        public List<MessageD> GetListUserMessage(int idUser)
        {
            List<MessageD> listM = new List<MessageD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Message WHERE Utilisateur_id = " + idUser, myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listM.Add(new MessageD
                        {
                            Message_id = Convert.ToInt32(reader["Message_id"]),
                            Topic_id = Convert.ToInt32(reader["Topic_id"]),
                            DatePoste = Convert.ToDateTime(reader["DatePoste"]),
                            Utilisateur_id = Convert.ToInt32(reader["Utilisateur_id"]),
                            ContenuMessage = reader["ContenuMessage"].ToString()
                        });
                    }
                }
            }
            return listM;
        }

        public List<MessageD> GetListMessage()
        {
            List<MessageD> listM = new List<MessageD>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Message", myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listM.Add(new MessageD
                        {
                            Message_id = Convert.ToInt32(reader["Message_id"]),
                            Topic_id = Convert.ToInt32(reader["Topic_id"]),
                            DatePoste = Convert.ToDateTime(reader["DatePoste"]),
                            Utilisateur_id = Convert.ToInt32(reader["Utilisateur_id"]),
                            ContenuMessage = reader["ContenuMessage"].ToString()
                        });
                    }
                }
            }
            return listM;
        }

        public MessageD GetMessage(int id)
        {
            MessageD Mes = new MessageD();
            using (SqlCommand command = new SqlCommand("SELECT * FROM FOR_Message WHERE Message_id = " + id, myConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mes.Message_id = Convert.ToInt32(reader["Message_id"]);
                        Mes.Topic_id = Convert.ToInt32(reader["Topic_id"]);
                        Mes.DatePoste = Convert.ToDateTime(reader["DatePoste"]);
                        Mes.Utilisateur_id = Convert.ToInt32(reader["Utilisateur_id"]);
                        Mes.ContenuMessage = reader["ContenuMessage"].ToString();
                    }
                }
            }
            return Mes;
        }

        /*public void ReportMessage(int id) //A completer, pas moyen de signaler un messsage avec la bdd actuelle
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = myConnection;
                command.CommandText = "UPDATE FOR_Message SET ContenuMessage = '" + mes.ContenuMessage + "' WHERE Message_id = " + mes.Message_id;
                command.ExecuteNonQuery();
            }
        }*/

        public void Dispose()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}