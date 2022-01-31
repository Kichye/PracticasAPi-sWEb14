namespace PDB.Models.Request
{
    public class PeliculaRequest
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string director { get; set; }
        public string genero { get; set; }
        public int puntuacion { get; set; }
        public int rating { get; set; }

        public int anpub { get; set; }
    }
}
