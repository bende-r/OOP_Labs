using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsLibrary
{
    public class PetType
    {
        public string Name { get; }
        public string Detention { get; }
        public string Skin { get; }

        public PetType (string type, string skin, string det)
        {
            Name = type;
            Skin = skin;
            Detention = det;
        }

        public override string ToString()
        {
            return" "+ Name.ToString()+" " + Detention.ToString() +" "+ Skin.ToString();
        }
    }
}
