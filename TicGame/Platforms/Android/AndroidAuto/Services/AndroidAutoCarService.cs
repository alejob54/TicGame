using Android.App;
using AndroidX.Car.App;
using AndroidX.Car.App.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicGame.Platforms.Android.AndroidAuto.Sessions;

namespace TicGame.Platforms.Android.AndroidAuto.Services
{
    [Service(Exported = true)]
    [IntentFilter(new string[] { "androidx.car.app.CarAppService" }, Categories = new[] { "androidx.car.app.category.POI" })]
    public class AndroidAutoCarService : CarAppService
    {
        public override HostValidator CreateHostValidator()
        {
            return HostValidator.AllowAllHostsValidator;
        }

        public override Session OnCreateSession()
        {
            return new AndroidAutoSession();
        }
    }
}
