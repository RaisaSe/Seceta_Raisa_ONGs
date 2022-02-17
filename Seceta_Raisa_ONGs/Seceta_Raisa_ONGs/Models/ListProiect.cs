using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Seceta_Raisa_ONGs.Models
{
    class ListProiect
    {
        public class ListProiect
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            [ForeignKey(typeof(ProjectListDatabase))]
            public int ProjectListID { get; set; }
            public int Proiect { get; set; }
        }
    }
}
