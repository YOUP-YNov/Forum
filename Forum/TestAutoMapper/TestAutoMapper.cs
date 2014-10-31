using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
namespace Forum.DAL
{
    public class TestAutoMapper
    {

        public TestAutoMapper()
        {
            Mapper.CreateMap<Personne, Employee>().ForMember(emp => emp.NomComplet,
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

            Console.WriteLine(emplo.ToString());
        }
    }
}

/* = new Employee
            {
                Prenom = "Dave",
                Nom = "Lizotte",
                Adresse = "Québec",
                Contact = 1234567890,
                NomComplet = "blalalalal"
            };*/