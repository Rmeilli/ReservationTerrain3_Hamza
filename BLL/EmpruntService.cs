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

                
                IdUtilisateur = model.IdUtilisateur,
                Id = model.Id,
                IdTerrain=model.IdTerrain
            };
            emprunt.Date = DateTime.Now;
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
                    Date = item.Date,
                    Id = item.Id,
                   
                    IdUtilisateur = item.IdUtilisateur,
                    IdTerrain=item.IdTerrain
                };
                listvms.Add(empruntList);
            }

            return listvms;

        }

    }
}
