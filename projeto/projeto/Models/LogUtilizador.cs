namespace projeto.Models
{
    public class LogUtilizador
    {
        public int LogId { get; set; } 
        public DateTime LogDataLogin { get; set; } = DateTime.Now;
        public Utilizador User { get; set; }
        public string LogMessage { get; set; }
    }
}
