using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Aprimori.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public int? MenuId { get; set; }

        public ICollection<Menu> SubMenu { get; set; }
    }
}
