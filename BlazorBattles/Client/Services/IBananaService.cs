using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IBananaService
    {
        public int Bananas { get; set; }

        public void EatBananas(int amount);
        public void AddBananas(int amount);

        event Action OnChange;
    }
}
