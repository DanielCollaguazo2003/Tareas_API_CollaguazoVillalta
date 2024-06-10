namespace Tareas_API.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Contenido { get; set; }
        public DateTime Time { get; set; }
        public required List<Tag> Tags { get; set; }
    }
}
