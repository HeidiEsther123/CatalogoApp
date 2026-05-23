namespace CatalogoApp.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ItemId { get; set; } 
        public string Usuario { get; set; }
        public int Calificacion { get; set; } 
        public string Comentario { get; set; }
    }
}