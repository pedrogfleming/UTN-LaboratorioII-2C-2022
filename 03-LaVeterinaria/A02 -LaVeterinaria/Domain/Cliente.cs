namespace Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Telefono { get; set; }
        public static bool operator ==(Cliente c1,Cliente c2)
        {
            return c1.Id == c2.Id ||
                (c1.Nombre == c2.Nombre &&
                c1.Apellido == c2.Apellido);
        }
        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
