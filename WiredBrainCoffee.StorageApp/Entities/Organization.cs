
namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization : EntityBase
    {
        
        public String? Name { get; set; }

        public override string ToString() => $"Id:{Id}, Name: {Name}";

    }
}
