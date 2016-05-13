using Couchbase.Linq.Filters;

namespace CouchbaseAspNetExample2.Models
{
    [DocumentTypeFilter("Person")]
    public class Person
    {
        public Person()
        {
            Type = "Person";
        }
        public string Type { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; }
    }
}