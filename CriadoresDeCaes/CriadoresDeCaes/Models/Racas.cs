using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models
{

    /// <summary>
    /// Descrição das Raças
    /// </summary>
    public class Racas
    {

        public Racas()
        {
            ListaAnimais = new HashSet<Animais>();
            ListaCriadores = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Designação da Raça
        /// </summary>
        public string Nome { get; set;}

        //*****************************************

        /// <summary>
        /// Lista de Animais pertencentes a uma Raça
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// M-N
        /// Lista de Criadores associados a uma Raça
        /// </summary>
        public ICollection<Criadores> ListaCriadores { get; set; }
    }
}
