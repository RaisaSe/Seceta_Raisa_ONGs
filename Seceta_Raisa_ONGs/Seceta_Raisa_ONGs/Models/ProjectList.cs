using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace Seceta_Raisa_ONGs.Models
{ namespace SQLite

    {
        public class ProjectList
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
        }
    }
}

namespace Seceta_Raisa_ONGs
{
    class ProjectListDatabase
    {
    }
}