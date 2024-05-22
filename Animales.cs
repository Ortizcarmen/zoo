namespace zoo
{
    public class Animales
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int TiempoAlimentacion { get; set; }
        public int TiempoVida {  get; set; }

        public Animales()
        {
            Nombre = string.Empty;
            Especie = string.Empty;
            TiempoAlimentacion = 0;
            TiempoVida = 0;
        }
            
    }
}
