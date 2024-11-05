//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPortfolio_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblProject
    {
        public int ProjectId { get; set; }
        [Required(ErrorMessage ="Proje Ad� Bo� Ge�ilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "G�rsel Url Bo� Ge�ilemez")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Proje A��klamas� Bo� Ge�ilemez")]
        [MaxLength(250,ErrorMessage ="A��klama b�l�m� en fazla 250 karakter olmal�d�r.")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Kategori Bo� Ge�ilemez")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Github Linki Bo� Ge�ilemez")]
        public string GithubUrl { get; set; }
    
        public virtual TblCategory TblCategory { get; set; }
    }
}
