//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace World2Mation
{
    
    public partial class Admin
    {
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }
}
