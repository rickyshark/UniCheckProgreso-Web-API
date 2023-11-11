using UniCheckProgreso_API.Modelos.Dto;

namespace UniCheckProgreso_API.Datos
{
    public static class CarreraStore
    {
        public static List<CarreraDto> ListaCarrera = new List<CarreraDto>
        {
            new CarreraDto {ID_carrera = 1, FechaCreacion = DateTime.Now },
            new CarreraDto {ID_carrera = 2, FechaCreacion = DateTime.Now }

        };
    }
}
