using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public  class TestScene01: BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("테스트 01 씬입니다");
            Console.WriteLine();
            Console.WriteLine(" 테스트 02 씬으로 이동");
            Console.WriteLine("선택지를 입력하세요 : ");
         
        }
        public override void Input()
        { 
            input = Console.ReadKey(true).key;
        }

        public override void Update()
        { 
        }
        public override void Result()
        {
            switch (Input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Test02");
                    break;
                case ConsoleKey.D2:

            }
        }
    }
}
