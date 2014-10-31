using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Forum.Business.Data;
using Forum.DAL.Data;
using Forum.Models;
namespace Forum.DAL
{
    public class AutoMapper
    {

        public AutoMapper()
        {
            Mapper.CreateMap<TopicD, TopicB>();
            Mapper.CreateMap<TopicB, TopicModel>();
            Mapper.CreateMap<MessageD, MessageB>();
            Mapper.CreateMap<MessageB, MessageModel>();
            Mapper.CreateMap<ForumD, ForumB>();
            Mapper.CreateMap<ForumB, ForumModel>();
            Mapper.CreateMap<CategorieD, CategorieB>();
            Mapper.CreateMap<CategorieB, CategorieModel>();
        }
    }
}

/* 
 *  Mapper.CreateMap<Personne, Employee>().ForMember(emp => emp.NomComplet,
           map => map.MapFrom(p => p.Nom + " " + p.Prenom));

            // Création une instance de 'Personne'
            Personne pers = new Personne
            {
                Prenom = "Dave",
                Nom = "Lizotte",
                Adresse = "Québec",
                Contact = 1234567890
            };

            // Obtenir une instance de la classe 'Personne' en tant que 'Employe' (Mappage)
            Employee emplo = Mapper.Map<Personne, Employee>(pers);

            };*/