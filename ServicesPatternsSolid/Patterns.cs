using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid
{

    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual void UpdateTimestamps()
        {
            if (Id == 0) CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public class SampleDiClass
    {
        private readonly IOrderService _orderService;

        public SampleDiClass(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // Methods that utilize _orderService
    }
}
