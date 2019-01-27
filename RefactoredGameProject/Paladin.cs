using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class Paladin : ICharacter
    {
        private int _strength = 14;
        public int Strength { get => _strength; set => _strength = value; }

        private int _stamina = 14;
        public int Stamina { get => _stamina; set => _stamina = value; }
    }
}
