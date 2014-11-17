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
    public class TopicDAL
    {
        public bool CreateTopic(TopicD top)
        {
            using (ps_FOR_GetTopicTableAdapter TopicDal = new ps_FOR_GetTopicTableAdapter())
            {
                TopicDal.ps_FOR_CreateTopic(top.Sujet_id, top.Nom, top.DescriptifTopic, top.DateCreation, top.Resolu, top.Utilisateur_id);
            }
            return true;
        }

        public bool EditTopic(TopicD top)
        {
            using (ps_FOR_GetTopicTableAdapter TopicTable = new ps_FOR_GetTopicTableAdapter())
            {
                TopicTable.ps_FOR_CreateTopic(top.Sujet_id, top.Nom, top.DescriptifTopic, top.DateCreation, top.Resolu, top.Utilisateur_id);
            }
            return true;
        }

        public bool DeleteTopic(int id)
        {
            using (ps_FOR_GetTopicTableAdapter TopicTable = new ps_FOR_GetTopicTableAdapter())
            {
                TopicTable.ps_FOR_DeleteTopic(id);
            }
            return true;
        }

        public List<TopicD> GetListTopic(int Topic_id)
        {
            myDataSet.ps_FOR_GetTopicDataTable datatable;
            using (ps_FOR_GetTopicTableAdapter TopicTable = new ps_FOR_GetTopicTableAdapter())
            {
                datatable = TopicTable.ps_FOR_GetListTopic(Topic_id);
            }
            return TopicMappeur.ToTopicD(datatable).ToList();
        }

        public TopicD GetTopic(int id)
        {
            myDataSet.ps_FOR_GetTopicDataTable datatable;
            using (ps_FOR_GetTopicTableAdapter TopicDal = new ps_FOR_GetTopicTableAdapter())
            {
                datatable = TopicDal.ps_FOR_GetListTopic(id);
            }
            return TopicMappeur.ToTopicD(datatable).ElementAt(0);
        }

        internal List<TopicD> GetTopicByCategory(int IDCategory)
        {
            myDataSet.ps_FOR_GetTopicDataTable datatable;

            using (ps_FOR_GetTopicTableAdapter TopicTable = new ps_FOR_GetTopicTableAdapter())
            {
                datatable = TopicTable.ps_FOR_GetListTopicByCategorie(IDCategory);
            }
            return TopicMappeur.ToTopicD(datatable).ToList();
        }
    }
}