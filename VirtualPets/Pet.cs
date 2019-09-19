using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class Pet : Shelter
    {

        public string PetName { get; set; }
        public string PetSpecies { get; set; }


        public virtual void Ticking()
        {

        }

        public virtual void CreatePet(Pet myPet)
        {
            

        }

        public virtual void Feed()
        {
        }

        
        public virtual void Play()
        {

        }
        public virtual void Health()
        {

        }
        public virtual void PetInfo()
        {
        }
        public virtual void PetStatus()
        {
        }


    }
    


}
