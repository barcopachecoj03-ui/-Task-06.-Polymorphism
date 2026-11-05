using System;

namespace InheritanceMinigame.Classes
{
    public class EliteWarrior : Warrior
    {
        public EliteWarrior(string name) : base($"Elite Member {name}")
        {
            AttackPower *= 2;
            ShieldBlock *= 2;
        }
        // This would be invalid:
        // public override void PerformAttack(Character target)
        // {
        //     Console.WriteLine("This warrior attacks in a different way!");
        // }

    }
}