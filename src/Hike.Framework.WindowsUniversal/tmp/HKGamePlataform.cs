//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Xna.Framework;

//namespace Hike.Framework.WindowsUniversal
//{
//    public class HKGamePlataform
//    {
//        public static GamePlatform PlatformCreate(HKGame game)
//        {
//#if MONOMAC
//            return new MacGamePlatform(game);
//#elif DESKTOPGL || ANGLE
//            return new OpenTKGamePlatform(game);
//#elif WINDOWS && DIRECTX
//            return new MonoGame.Framework.WinFormsGamePlatform(game);
//#elif WINDOWS_UAP
//            return new HKUAPGamePlatform(game);
//#elif WINRT
//            return new MetroGamePlatform(game);
//#endif
//        }
//    }
//}
