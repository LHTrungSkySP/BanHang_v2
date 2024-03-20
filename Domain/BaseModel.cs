using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public abstract class BaseModel
    {
        [Key]
        public long Id { get; set; }
        public Guid ObjId { get; set; } = Guid.NewGuid();
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public void DeleteMe(DateTime now)
        {
            IsDeleted = true;
            UpdatedDate = now;
        }
    }
}
