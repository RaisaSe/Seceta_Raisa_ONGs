using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Seceta_Raisa_ONGs.Models
{
    public class Proiect
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListProiect> Proiect.ListProiects { get; set; }
    }
}
