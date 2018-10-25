using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicUmbraco.Web.Models
{
    public class UmbracoContactModel
    {
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Du måste ange namn")]
        public string Name { get; set; }
        [Display(Name = "Företag")]
        public string Company { get; set; }
        [Display(Name = "E-post")]
        [EmailAddress(ErrorMessage = "Du måste ange en giltig e-post")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Meddelande")]
        public string Message { get; set; }
        [Display(Name = "GDPR")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Du måste godkänna GDPR")]
        public bool GDPR { get; set; }
        public string SendFrom { get; set; }
        public string Subject { get; set; }
    }
}