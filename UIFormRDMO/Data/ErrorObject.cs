using UIFormRDMO.Data.Models;

namespace UIFormRDMO.Data
{
    public class ErrorObject : IPerson
    {
        public ErrorObject(string message = "404")
        {
            ErrorCode = message;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string? DateAttest { get; set; }
        public string? DateMed { get; set; }
        
        public string? ErrorCode { get; set; }
    }
}