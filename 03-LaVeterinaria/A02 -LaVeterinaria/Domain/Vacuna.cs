namespace Domain
{
    /// <summary>
    /// La clase vacuna posee un identificador global unico
    /// </summary>
    public class Vacuna
    {
        /// <summary>
        /// El Guid es mas seguro para manejar Ids que un Int
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nombre de la vacuna
        /// </summary>
        public string Descripcion { get; set; }
    }
}
