using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealSuperHeros.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AltarEgo { get; set; }
        public string PrimaryAbil { get; set; }
        public string SecondaryAbil { get; set; }
        public string CatchPhrase { get; set; }



    }
}