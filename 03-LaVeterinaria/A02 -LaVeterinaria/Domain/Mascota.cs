namespace Domain
{
    public class Mascota
    {
        public Guid Id { get; set; }
        public string Especie { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Vacuna[] historialDeVacunacion;

        public Mascota(Guid id, string especie, string nombre, DateTime fechaNacimiento, Vacuna[] historialDeVacunacion)
        {
            Id = id;
            Especie = especie;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            HistorialDeVacunacion = historialDeVacunacion;
        }

        /// <summary>
        /// Arrancará vacío y se podrá ir agregando vacunas
        /// </summary>
        public Vacuna[] HistorialDeVacunacion 
        {
            get { return HistorialDeVacunacion; }
            set
            {
                //Remplazo el array de Vacunas con el que nuevo array
                historialDeVacunacion = value;
            }
        }
    }
}