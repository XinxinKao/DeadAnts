using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    public class DeadAnt
    {
        public int DeadAntCount(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            var antWithoutLife = ants.Replace("ant", "").Replace(".", "").Replace(" ", "");
            if (antWithoutLife.Trim().Length == 0)
            {
                return 0;
            }
            
            return GetMaxDeadAntCount(antWithoutLife);
        }

        private int GetMaxDeadAntCount(string input)
        {
            var totalAntHead = input.Count(t => t == 'a');
            var totalAntBody = input.Count(t => t == 'n');
            var totalAntLeg = input.Count(t => t == 't');

            if (totalAntHead >= totalAntBody && totalAntHead >= totalAntLeg)
            {
                return totalAntHead;
            }
            
            return totalAntBody >= totalAntLeg ? totalAntBody : totalAntLeg;
        }
    }
}
