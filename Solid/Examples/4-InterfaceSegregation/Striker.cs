using System;
namespace Solid.Examples.InterfaceSegregation
{
    public class Striker : IPlayer, IStriker
    {
        public void ScoreGoal()
        {
            
        }

        void IPlayer.GivePass()
        {
            
        }

        void IPlayer.PutOnStrip()
        {
            
        }
    }
}
