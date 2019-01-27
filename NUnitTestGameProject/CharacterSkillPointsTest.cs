using NUnit.Framework;
using RefactoredGameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestGameProject
{
    [TestFixture]
    public class CharacterSkillPointsTest
    {
        CharacterSkillPoints characterskillpoints;

        [SetUp]
        public void TestSetup()
        {
            characterskillpoints = new CharacterSkillPoints();

            characterskillpoints.GiveOutSkillPointsForPaladin();
            characterskillpoints.GiveOutSkillPointsForBarbarian();
            characterskillpoints.GiveOutSkillPointsForMage();
            characterskillpoints.GiveOutSkillPointsForThief();
        }

        [Test]
        public void skill_points_for_paladin_strength()
        {
            int StrengthSkillPoints = characterskillpoints.paladin.Strength;

            Assert.AreEqual(26, StrengthSkillPoints);
        }

        [Test]
        public void skill_points_for_paladin_stamina()
        {
            int StaminaSkillPoints = characterskillpoints.paladin.Stamina;

            Assert.AreEqual(22,StaminaSkillPoints);
        }

        [Test]
        public void skill_points_for_barbarian_strength()
        {
            int StrengthSkillPoints = characterskillpoints.barbarian.Strength;

            Assert.AreEqual(33, StrengthSkillPoints);
        }

        [Test]
        public void skill_points_for_barbarian_stamina()
        {
            int StaminaSkillPoints = characterskillpoints.barbarian.Stamina;

            Assert.AreEqual(26, StaminaSkillPoints);
        }

        [Test]
        public void skill_points_for_mage_strength()
        {
            int StrengthSkillPoints = characterskillpoints.mage.Strength;

            Assert.AreEqual(15, StrengthSkillPoints);
        }

        [Test]
        public void skill_points_for_mage_stamina()
        {
            int StaminaSkillPoints = characterskillpoints.mage.Stamina;

            Assert.AreEqual(12, StaminaSkillPoints);
        }

        [Test]
        public void skill_points_for_thief_strength()
        {
            int StrengthSkillPoints = characterskillpoints.thief.Strength;

            Assert.AreEqual(20, StrengthSkillPoints);
        }

        [Test]
        public void skill_points_for_thief_stamina()
        {
            int StaminaSkillPoints = characterskillpoints.thief.Stamina;

            Assert.AreEqual(22, StaminaSkillPoints);
        }
    }
}
