using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Emprunt;
using DAL.Entity;
using DAL.Repos;


namespace BLL
{
    public class EmpruntService
    {
        public void Ajouter(Formulaire model)
        {
            Emprunt emprunt = new Emprunt()
            {
                
                Email = model.Email,
                Nom = model.Nom,
                Prenom = model.Prenom,
                Terrain=model.Terrain
            };
            emprunt.DateCreation = DateTime.Now;
            EmpruntRepos empruntRepos = new EmpruntRepos();
            empruntRepos.Create(emprunt);
        }

        public List<EmpruntListe> GetList()
        {
            EmpruntRepos empruntRepos = new EmpruntRepos();
            List<EmpruntListe> listvms = new List<EmpruntListe>(); ;

            foreach (var item in empruntRepos.All())
            {
                EmpruntListe empruntList = new EmpruntListe
                {
                    DateCreation = item.DateCreation,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    Id = item.Id
                };
                listvms.Add(empruntList);
            }

            return listvms;

        }

    }
}
