using System.Collections.Generic;
using System.Linq;
using Couchbase.Core;
using Couchbase.Linq;
using Couchbase.Linq.Extensions;
using Couchbase.N1QL;

namespace CouchbaseAspNetExample2.Models
{
    public class PersonRepository
    {
        private readonly IBucket _bucket;
        private readonly IBucketContext _context;

        public PersonRepository(IBucket bucket, IBucketContext context)
        {
            _bucket = bucket;
            _context = context;
        }

        public List<Person> GetAll()
        {
            return _context.Query<Person>()
               .ScanConsistency(ScanConsistency.RequestPlus)   // waiting for the indexing to complete before it returns a response
               .OrderBy(p => p.Name)
               .ToList();
        }

        public Person GetPersonByKey(string key)
        {
            return _bucket.Get<Person>(key).Value;
        }
    }
}