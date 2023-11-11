namespace UniCheckProgreso_API.Modelos
{
    public class Carrera
    {
        public int ID_carrera { get; set; }
        public required string NombreCarrera { get; set; }
        public required string TipoGrado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
