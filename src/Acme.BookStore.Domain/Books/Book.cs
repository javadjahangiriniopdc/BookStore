using System;
using System.Numerics;
using Microsoft.VisualBasic.CompilerServices;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate  { get; set; }
        public float Price  { get; set; }
    }
}