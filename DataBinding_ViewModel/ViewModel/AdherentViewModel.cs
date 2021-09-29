using DataBinding_ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_ViewModel.ViewModel
{
    class AdherentViewModel
    {
        //public List<Adherent> ListeAdherents = new List<Adherent>();
        public List<Adherent> ListeAdherents { get; set; }

        private DBAdherentsEntities db = new DBAdherentsEntities(); 

        public AdherentViewModel()
        {
            if(ListeAdherents == null)
            {
                ListeAdherents = new List<Adherent>();
                ListeAdherents = db.Adherents.ToList();
            }
            
        }
    }
   

}
