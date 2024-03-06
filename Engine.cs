using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMove
{
    internal class Engine
    {
        private Player player = new Player();
        private Stage stage = new Stage();
        ConsoleKeyInfo keyInfo;

        private void Input()
        {
            keyInfo = Console.ReadKey();
        }

        private void Update()
        {           
            player.Move(keyInfo, stage.Map);
        }

        public void Render()
        {           
            stage.Render();
            player.Render();
        }

        public void Init()
        {
            new Player();
        }

        public void Run()
        {
            while (true)
            {
                Input();
                Update();
                Render();
            }
        }       
    }
}
