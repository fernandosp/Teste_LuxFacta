
namespace Luxfacta.Enquete.Domain.Entities
{
    public class Option
    {
        public int option_id { get; set; }
        public string option_description { get; set; }
        //public int poll_id { get; set; }
        public virtual Poll pool { get; set; }
    }
}
