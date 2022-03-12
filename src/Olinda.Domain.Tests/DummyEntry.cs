using System;

namespace Olinda.Domain.Tests
{
    public class DummyEntry : Entry
    {
        public DummyEntry(string description, decimal value, DateTime? date = null) : base(description, value, date)
        {
        }
    }
}