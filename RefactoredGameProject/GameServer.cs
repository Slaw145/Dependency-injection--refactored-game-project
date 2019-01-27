using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredGameProject
{
    public class GameServer
    {
        LoginValidator loginvalidator;
        PasswordValidator passwordvalidator;
        public CharacterSkillPoints characterskillpoints;

        public GameServer()
        {
            loginvalidator = new LoginValidator();
            passwordvalidator = new PasswordValidator();
            characterskillpoints = new CharacterSkillPoints();
        }

        public void RegisterUser(string login, string password)
        {
            bool ifloginvalidate = loginvalidator.LoginValidate(login);
            bool ifpasswordvalidate = passwordvalidator.PasswordValidate(password);

            if(ifloginvalidate==true && ifpasswordvalidate==true)
            {
                Console.WriteLine("Register user");
            }
            else
            {
                Console.WriteLine("Login or password are incorrect!");
            }
        }

        public void CreateCharacter(ICharacter character)
        {
            if(character is Barbarian)
            {
                characterskillpoints.GiveOutSkillPointsForBarbarian();
            }
            else if(character is Paladin)
            {
                characterskillpoints.GiveOutSkillPointsForPaladin();
            }
            else if (character is Mage)
            {
                characterskillpoints.GiveOutSkillPointsForMage();
            }
            else if (character is Thief)
            {
                characterskillpoints.GiveOutSkillPointsForThief();
            }
        }
    }
}
