using System;
using System.Collections.Generic;

#nullable disable

namespace PDB.Models
{
    public partial class Informacion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public int? Puntuación { get; set; }
        public int? Rating { get; set; }
        public int? Anpub { get; set; }
    }
}
