using System.ComponentModel.DataAnnotations;

namespace SuperHeros23App.Models
{
    public class SuperHero23
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string PrimaryAbility  { get; set; }
        public string SecondaryAbility{ get; set; }

        public string AlterEgo { get; set; }
        public string CatchPhrase { get; set; }

        //public string CreatedBy { get; set; }
    }
}
