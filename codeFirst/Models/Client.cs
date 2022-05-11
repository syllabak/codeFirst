using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirst.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }


        [Display(Name = "Nom du client client"), MaxLength(80, ErrorMessage = "*"), Required(ErrorMessage = "saisir le le nom svp  pour avancer")]
        public string NomClient { get; set; }

        [Display(Name = "Prenom du client"), MaxLength(80, ErrorMessage = "*"), Required(ErrorMessage = "saisir le le PrenomClient svp  pour avancer")]
        public string PrenomClient { get; set; }

        [Display(Name = "Sa fonction"), MaxLength(80, ErrorMessage = "*"), Required(ErrorMessage = "saisir le le Fonction svp  pour avancer")]
        public string Fonction { get; set; }

        [Display(Name = "Son salaire"), Required(ErrorMessage = "saisir le Salair svp")]
        public long Salair { get; set; }

      
    }
}