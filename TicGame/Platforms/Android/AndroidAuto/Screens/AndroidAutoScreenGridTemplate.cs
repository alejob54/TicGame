using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicGame.Platforms.Android.AndroidAuto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace TicGame.Platforms.Android.AndroidAuto.Screens
{
    public class AndroidAutoScreenGridTemplate : Screen
    {
        public AndroidAutoScreenGridTemplate(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var gridItemListBuilder = new ItemList.Builder()
                .SetNoItemsMessage("No grid items found");

            for (int i = 0; i < 10; i++)
            {
                var gridItem = new GridItem.Builder()
                    .SetTitle($"Grid Item {i} Title")
                    .SetText($"Grid Item {i} text")
                    .SetImage(dotnetBotCarIcon)
                    .SetOnClickListener(new ActionOnClickListener(CarContext, $"Grid item {i} was tapped"))
                    .Build();

                gridItemListBuilder.AddItem(gridItem);
            }

            var gridItemList = gridItemListBuilder.Build();


            //var pane = paneBuilder.Build();

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

            return new GridTemplate.Builder()
                .SetTitle("Grid Template")
                .SetHeaderAction(Action.Back)
                .SetSingleList(gridItemList)
                .SetActionStrip(actionStrip)
                .Build();
        }
    }
}
