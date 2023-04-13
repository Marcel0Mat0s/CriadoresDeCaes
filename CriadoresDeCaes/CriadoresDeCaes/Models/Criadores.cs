using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models
{

    /// <summary>
    /// descrição dos criadores dos cães
    /// </summary>
    public class Criadores
    {

        public Criadores() { 
        
            ListaRacas = new HashSet<Racas>();
            ListaAnimais = new HashSet<Animais>();
        
        }

        public int Id { get; set; }

        /// <summary>
        /// /Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome comercial do criador de cães
        /// </summary>
        public string NomeCriador { get; set; }

        /// <summary>
        /// Morada do criador de cães
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Telemovel
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Código postal
        /// </summary>
        public string CodPostal { get; set; }

        //**********************************************

        /// <summary>
        /// M-N
        /// Lista de Raças associadas a um Criador
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }

        /// <summary>
        /// Lista de Animais associados a um Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
