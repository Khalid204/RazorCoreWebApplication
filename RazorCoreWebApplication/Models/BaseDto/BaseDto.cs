using DomainLayer.Models;

namespace RazorCoreWebApplication.Models.BaseDto
{
    public class BaseDto
    {
        public int Id { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
