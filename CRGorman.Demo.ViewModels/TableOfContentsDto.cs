using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRGorman.Demo.ViewModels
{

    /// <summary>
    /// A simple list of names and Ids for missions.
    /// </summary>
    public class TableOfContentsDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string VanityURL { get; set; } = string.Empty;

        public List<TableOfContentsActsDto> Acts { get; set; }

        public int Order { get; set; }
    }

    public class TableOfContentsActsDto
    {
        public int Id { get; set; }
        public int ActNumber { get; set; }
        public string Name { get; set; }

        public List<TableOfContentsMissionsDto> Missions { get; set; }
    }

    public class TableOfContentsMissionsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
    }
}
