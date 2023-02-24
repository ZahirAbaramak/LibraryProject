using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Author : IEntity
    {
        public int  Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DateOfPlace { get; set; }
        public string AuthorAbout { get; set; }
       
    }
}
