using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class Mage : ICharacter
    {
        private int _strength = 8;
        public int Strength { get => _strength; set=>_strength = value; }

        private int _stamina = 6;
        public int Stamina { get => _stamina; set=> _stamina = value; }
    }
}
