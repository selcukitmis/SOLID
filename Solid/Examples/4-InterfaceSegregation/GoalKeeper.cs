using System;
namespace Solid.Examples.InterfaceSegregation
{
    public class GoalKeeper : IPlayer, IGoalKeeper
    {
        public void GivePass()
        {
        }

        public void PutOnStrip()
        {
        }

        public void Save()
        {
        }
    }
}
