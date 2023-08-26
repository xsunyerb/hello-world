using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldApi
{
    public class User
    {
        public User(string userName, DateTime birthday)
        {
            UserName = userName;
            Birthday = birthday;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
