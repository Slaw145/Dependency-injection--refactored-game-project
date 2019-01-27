using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public interface ICharacter
    {
        int Strength { get; set; }
        int Stamina { get; set; }
    }
}
