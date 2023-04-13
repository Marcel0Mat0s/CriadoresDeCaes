using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// descrição dos animais
    /// </summary>
    public class Animais
    {
        public Animais() { 
        
            ListaFotografias = new HashSet<Fotografias>();
        
        }

        public int Id { get; set; }

        /// <summary>
        /// Nome do animal
        /// </summary>
        public string Nome { get; set;}

        /// <summary>
        /// data de nascimento do animal
        /// </summary>
        public DateTime DataNascimento { get; set;}

        /// <summary>
        /// data da compra do animal
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// sexo do animal
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Número de LOP do animal
        /// </summary>
        public string NumLOP { get; set; }

        //*************************************************

        /// <summary>
        /// lista das fotografias associadas a um animal
        /// </summary>
        public ICollection<Fotografias> ListaFotografias { get; set; }

        /// <summary>
        /// Fk para a Raça do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Raca))] // <=> [ForeignKey("Raca")]
        public int RacaFK { get; set; }
        public Racas Raca { get; set; }

        /// <summary>
        /// FK para o Criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))] // <=> [ForeignKey("Criador")]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }
    }
}
