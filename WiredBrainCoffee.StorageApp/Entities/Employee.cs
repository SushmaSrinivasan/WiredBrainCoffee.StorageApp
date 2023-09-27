
namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee : EntityBase
    {
        public String? FirstName { get; set; }

        public override string ToString() => $"Id:{Id}, FirstName: {FirstName}";

    }
}
