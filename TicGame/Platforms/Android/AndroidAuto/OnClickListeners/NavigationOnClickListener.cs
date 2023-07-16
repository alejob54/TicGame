using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicGame.Platforms.Android.AndroidAuto.Enums;
using TicGame.Platforms.Android.AndroidAuto.Screens;

namespace TicGame.Platforms.Android.AndroidAuto.OnClickListeners
{
    public class NavigationOnClickListener : Java.Lang.Object, IOnClickListener
    {
        private readonly CarContext _carContext;
        private readonly ScreenManager _screenManager;
        private readonly AndroidAutoScreen _screenToNavigate;
        public NavigationOnClickListener(CarContext context, ScreenManager screenManager, AndroidAutoScreen screenToNavigate)
        {
            //context = _carContext;
            _carContext = context;
            _screenManager = screenManager;
            _screenToNavigate = screenToNavigate;

            //screenManager = _screenManager;
            //screenToNavigate = _screenToNavigate;

        }

        public void OnClick()
        {
            switch (_screenToNavigate)
            {
                case AndroidAutoScreen.None:
                    return;
                case AndroidAutoScreen.Menu:
                    _screenManager.Push(new AndroidAutoScreenMenu(_carContext));
                    break;
                case AndroidAutoScreen.MessageTemplate:
                    _screenManager.Push(new AndroidAutoScreenMessageTemplate(_carContext));
                    break;
                case AndroidAutoScreen.PaneTemplate:
                    _screenManager.Push(new AndroidAutoScreenPaneTemplate(_carContext));
                    break;
                case AndroidAutoScreen.GridTemplate:
                    _screenManager.Push(new AndroidAutoScreenGridTemplate(_carContext));
                    break;
                case AndroidAutoScreen.Pop:
                    _screenManager.Pop();
                    break;
                default:
                    return;
            }
        }
    }
}
