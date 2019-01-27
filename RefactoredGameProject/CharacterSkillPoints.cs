using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class CharacterSkillPoints
    {
        public Paladin paladin;
        public Barbarian barbarian;
        public Mage mage;
        public Thief thief;

        public CharacterSkillPoints()
        {
            paladin = new Paladin();
            barbarian = new Barbarian();
            mage = new Mage();
            thief = new Thief();
        }

        public void GiveOutSkillPointsForPaladin()
        {
            paladin.Strength += 12;
            paladin.Stamina += 8;
        }

        public void GiveOutSkillPointsForBarbarian()
        {
            barbarian.Strength += 15;
            barbarian.Stamina += 9;
        }

        public void GiveOutSkillPointsForMage()
        {
            mage.Strength += 7;
            mage.Stamina += 6;
        }

        public void GiveOutSkillPointsForThief()
        {
            thief.Strength += 10;
            thief.Stamina += 10;
        }
    }
}
