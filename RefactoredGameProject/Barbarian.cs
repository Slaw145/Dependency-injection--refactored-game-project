﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class Barbarian : ICharacter
    {
        private int _strength = 18;
        public int Strength { get => _strength; set => _strength=value; }

        private int _stamina = 17;
        public int Stamina { get => _stamina; set => _stamina = value; }
    }
}
