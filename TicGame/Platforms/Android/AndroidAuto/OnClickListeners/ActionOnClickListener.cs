using Android.Content;
using Android.Service.Autofill;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicGame.Platforms.Android.AndroidAuto.OnClickListeners
{
    public class ActionOnClickListener : Java.Lang.Object, IOnClickListener
    {
        private readonly CarContext _carContext;
        private readonly string _message;
        public ActionOnClickListener(CarContext carContext, string message)
        {
            _carContext = carContext;
            _message = message;
        }
        public void OnClick()
        {
            CarToast.MakeText(_carContext, _message, CarToast.LengthLong).Show();
        }
    }
}
