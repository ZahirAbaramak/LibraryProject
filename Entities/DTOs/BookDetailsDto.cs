using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class BookDetailsDto : IEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string About { get; set; }

    }
}
