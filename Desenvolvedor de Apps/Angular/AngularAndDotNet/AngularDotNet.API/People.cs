using System.ComponentModel.DataAnnotations;

namespace AngularDotNet.API
{
    public class People
    {
        [Key]
        public Guid idPeople { get; set; }
        public string namePeople { get; set; } = string.Empty;
        public string lastNamePeople { get; set; } = string.Empty;
        public int agePeople { get; set; }
        public string professionPeople { get; set; } = string.Empty;

    }
}