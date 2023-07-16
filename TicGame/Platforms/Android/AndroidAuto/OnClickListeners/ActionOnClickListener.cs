using AndroidX.Car.App;
using AndroidX.Car.App.Model;

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
