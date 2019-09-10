using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Pet
    {
        public string petName { get; set; }
        public enum Type { organic, robotic }
        public Type PetType { get; set; }
    }
}
