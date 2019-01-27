using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class Thief : ICharacter
    {
        private int _strength = 10;
        public int Strength { get => _strength; set => _strength = value; }

        private int _stamina = 12;
        public int Stamina { get => _stamina; set => _stamina = value; }
    }
}
