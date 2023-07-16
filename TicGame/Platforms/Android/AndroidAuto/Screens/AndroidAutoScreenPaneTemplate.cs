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
    public class AndroidAutoScreenPaneTemplate : Screen
    {
        public AndroidAutoScreenPaneTemplate(CarContext carContext) : base(carContext)
        {

        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var paneAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetBackgroundColor(CarColor.Blue)
                .SetTitle("< Go Back")
                .SetOnClickListener(new NavigationOnClickListener(CarContext, ScreenManager, AndroidAutoScreen.Pop))
                .Build();

            var paneBuilder = new Pane.Builder()
                .SetImage(dotnetBotCarIcon)
                .AddAction(paneAction);

            for (int i = 0; i < 10; i++)
            {
                var row = new Row.Builder()
                    .SetTitle($"Row {i} title")
                    .SetImage(dotnetBotCarIcon)
                    .AddText($"Row {i} text")
                    .Build();

                paneBuilder.AddRow(row);
            }

            var pane = paneBuilder.Build();

            var actionOne = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip item 1 was tapped"))
                .Build();

            var actionTwo = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Action strip item 2 was tapped"))
                .Build();

            var actionStrip = new ActionStrip.Builder()
                .AddAction(actionOne)
                .AddAction(actionTwo)
                .Build();

            return new PaneTemplate.Builder(pane)
                .SetTitle("PaneTemplate")
                .SetHeaderAction(Action.Back)
                .SetActionStrip(actionStrip)
                .Build();

        }
    }
}
