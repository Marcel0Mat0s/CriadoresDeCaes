namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Fotografias associadas aos cães
    /// </summary>
    public class Fotografias
    {
        public int Id { get; set; }

        /// <summary>
        /// Nome do documento com a fotografia
        /// </summary>
        public string NomeFicheiro { get; set; }

        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime Data { get; set;}

        /// <summary>
        /// Local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set;}
    }
    
}
