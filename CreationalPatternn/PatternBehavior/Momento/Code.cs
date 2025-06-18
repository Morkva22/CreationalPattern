using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Momento
{
    public class ClientCode
    {
        public void Main()
        {
            Game game = new Game(1, 100, "Forest");
            Console.WriteLine(game);
            Console.WriteLine();
            History history = new History();
            history.AddState(new GameMomento(game));
            Console.WriteLine();
            game.SetState(2, 150, "Cave");
            Console.WriteLine(game);
            Console.WriteLine();
            history.AddState(new GameMomento(game));
            game.SetState(3, 200, "Castle");
            Console.WriteLine(game);
            Console.WriteLine();
            game.RestoreState((GameMomento)history.GetState());
            Console.WriteLine(game);
            Console.WriteLine();
            game.RestoreState((GameMomento)history.GetState());
            Console.WriteLine(game);
            Console.WriteLine();
        }
    }
}