using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;



        public static void Run()
        {
            Start();
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End();
        }
        private static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            curScene = sceneDic["Title"];
        }

        private static void End()
        { 
        }
    }
}
