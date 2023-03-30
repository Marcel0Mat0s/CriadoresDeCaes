namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// descrição dos animais
    /// </summary>
    public class Animais
    {
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
    }
}
