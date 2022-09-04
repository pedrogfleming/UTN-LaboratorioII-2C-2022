namespace Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
