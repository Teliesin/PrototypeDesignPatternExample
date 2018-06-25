namespace PrototypeDesignPatternExample.Prototype
{
    public interface IHorsePicture : IPrototype
    {
        string Name { get; set; }
        string Race { get; set; }
        string Coat { get; set; }
        string Mane { get; set; }
        string AdditionalFeatures { get; set; }
    }
}