using System;

namespace SampleTestApp.Core.Domains
{
    public class Foo
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }

        protected Foo()
        {

        }

        public Foo(string name) : this(Guid.NewGuid(), name)
        {

        }

        public Foo(Guid id, string name)
        {
            Id = id;
            SetName(name);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty.");
            }

            Name = name;
        }
    }
}