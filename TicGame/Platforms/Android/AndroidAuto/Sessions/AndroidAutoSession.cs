using Android.Content;
using AndroidX.Car.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicGame.Platforms.Android.AndroidAuto.Screens;

namespace TicGame.Platforms.Android.AndroidAuto.Sessions
{
    public class AndroidAutoSession : Session
    {
        public override Screen OnCreateScreen(Intent intent)
        {
            return new AndroidAutoScreenMenu(CarContext);
        }
    }
}
