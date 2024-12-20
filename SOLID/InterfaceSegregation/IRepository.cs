using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();

      

    }

    public interface ISearchableRepository<T> where T : class
    {
        IEnumerable<T> Search(string keyword);
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class CustomerRepository : IRepository<Customer>, ISearchableRepository<Customer>
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("Müşteri eklendi.");
        }
        public void Delete(Customer entity)
        {
            Console.WriteLine("Müşteri silindi.");
        }
        public IEnumerable<Customer> GetAll()
        {
            Console.WriteLine("Müşteriler listelendi.");
            return new List<Customer>();
        }
        public Customer GetById(int id)
        {
            Console.WriteLine("Müşteri getirildi.");
            return new Customer();
        }

        public IEnumerable<Customer> Search(string keyword)
        {
            Console.WriteLine("Müşteriler arandı.");
            return new List<Customer>();

        }

        public void Update(Customer entity)
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public void Add(Order entity)
        {
            Console.WriteLine("Sipariş eklendi.");
        }
        public void Delete(Order entity)
        {
            Console.WriteLine("Sipariş silindi.");
        }
        public IEnumerable<Order> GetAll()
        {
            Console.WriteLine("Siparişler listelendi.");
            return new List<Order>();
        }
        public Order GetById(int id)
        {
            Console.WriteLine("Sipariş getirildi.");
            return new Order();
        }
       
        public void Update(Order entity)
        {
            Console.WriteLine("Sipariş güncellendi.");
        }
    }
}

