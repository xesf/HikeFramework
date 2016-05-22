using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MonoGame.Framework;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace Hike.Framework.WindowsUniversal.Platform.UniversalWindows
{
    public class HKGameUniversalWindows<T>
        where T : HKGame, new()
    {
        static public T Create(string launchParameters, CoreWindow window, SwapChainPanel swapChainPanel)
        {
            var game = new T();
            game.XnaGame = XamlGame<HKGameXna>.Create(launchParameters, window, swapChainPanel);
            return game;
        }
    }
}
