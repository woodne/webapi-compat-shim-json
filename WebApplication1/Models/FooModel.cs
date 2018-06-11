using System.Runtime.Serialization;

namespace WebApplication1.Models
{
    public class FooModel
    {
        [DataMember]
        public string MyProperty { get; set; }
    }
}