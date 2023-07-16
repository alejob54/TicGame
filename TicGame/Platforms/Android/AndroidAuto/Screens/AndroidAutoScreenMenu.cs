using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicGame.Platforms.Android.AndroidAuto.Enums;
using TicGame.Platforms.Android.AndroidAuto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace TicGame.Platforms.Android.AndroidAuto.Screens
{
    public class AndroidAutoScreenMenu : Screen
    {
        public AndroidAutoScreenMenu(CarContext carContext) : base(carContext)
        {

        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var messageTemplateScreen = new Row.Builder()
                .SetTitle("Message template")
                .AddText("Sample text")
                .SetImage(dotnetBotCarIcon)
                .SetBrowsable(true)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, AndroidAutoScreen.MessageTemplate))
                .Build();

            var paneTemplateScreen = new Row.Builder()
                .SetTitle("Pane template")
                .AddText("Sample text")
                .SetImage(dotnetBotCarIcon)
                .SetBrowsable(true)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, AndroidAutoScreen.PaneTemplate))
                .Build();

            var gridTemplateScreen = new Row.Builder()
                .SetTitle("Grid template")
                .AddText("Sample text")
                .SetImage(dotnetBotCarIcon)
                .SetBrowsable(true)
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, AndroidAutoScreen.GridTemplate))
                .Build();

            var itemList = new ItemList.Builder()
                .SetNoItemsMessage("Our MAUI App is running on android auto")
                .AddItem(messageTemplateScreen)
                .AddItem(paneTemplateScreen)
                .AddItem(gridTemplateScreen)
                .Build();

            return new ListTemplate.Builder()
                .SetTitle("MAUI Android Auto - Menu")
                .SetHeaderAction(Action.AppIcon)
                .SetSingleList(itemList)
                .Build();
        }
    }
}
