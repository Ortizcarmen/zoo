namespace zoo
{
    public class Aves:Animales
    {
        public string Avevoladora {  get; set; }
        public int PeriodoIncubacion { get; set; }


        public Aves()
        {
            Avevoladora = string.Empty;
            PeriodoIncubacion = 0;
        }
    }
}
