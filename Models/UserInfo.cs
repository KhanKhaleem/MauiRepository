using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUI_Project.Models
{
    [Table("UserInformation")]
    public class UserInfo
    {
        [PrimaryKey , AutoIncrement]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
    }
}
