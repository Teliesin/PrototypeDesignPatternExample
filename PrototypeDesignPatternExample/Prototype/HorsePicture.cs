using System.Text;

namespace PrototypeDesignPatternExample.Prototype
{
    public class HorsePicture : IHorsePicture
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Coat { get; set; }
        public string Mane { get; set; }
        public string AdditionalFeatures { get; set; }

        public IHorsePicture Copy()
        {
            HorsePicture horsePicture = new HorsePicture();

            horsePicture.Name = this.Name;
            horsePicture.Race = this.Race;
            horsePicture.Coat = this.Coat;
            horsePicture.Mane = this.Mane;
            horsePicture.AdditionalFeatures = this.AdditionalFeatures;

            return horsePicture;
        }
    }
}