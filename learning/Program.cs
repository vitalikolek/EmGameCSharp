using System;

namespace learning { 
    internal class Program {
        static void Main(string[] args) {
            Engine engine = new Engine();
            Player player = new Player("Stepan", 100);

            engine.firstRound(player);
        }
    }
}