using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.State
{
    public class ClientCode
    {
        public void Main()
        {
            Player player = new Player();
            player.InitState("Hero");
            player.Build();
            player.SetState("Warrior");
            player.Build();
            player.Dispose();

            Monster monster = new Monster();
            monster.InitState("Dragon");
            monster.Build();
            monster.SetState("Demon");
            monster.Build();
            monster.Dispose();
        }
    }
}