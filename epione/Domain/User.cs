using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Role {admin,patient,doctor}
namespace Domain
{
    public class User 
        //: IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [MaxLength(50)]
        public String firstName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [MaxLength(50)]
        public String lastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public String email { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [MaxLength(50)]
        public String login { get; set; }
        [Required(ErrorMessage = "Required")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Confirmer le mot de passe")]
        public String confirmPassword { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [MaxLength(50)]
        public virtual Address address { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [MaxLength(50)]
        public String phoneNumber { get; set; }
        public Role role { get; set; }
        [ForeignKey("StepId")]
        public virtual ICollection<Step> steps { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        public String Speciality { get; set; }
        [ForeignKey("DisponibilityId")]
        public virtual ICollection<Disponibility> disponibilities { get; set; }


       

    }
   
}
