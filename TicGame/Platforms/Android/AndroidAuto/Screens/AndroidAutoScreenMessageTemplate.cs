using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;
using TicGame.Platforms.Android.AndroidAuto.OnClickListeners;
using Action = AndroidX.Car.App.Model.Action;

namespace TicGame.Platforms.Android.AndroidAuto.Screens
{
    public class AndroidAutoScreenMessageTemplate : Screen
    {
        public AndroidAutoScreenMessageTemplate(CarContext carContext) : base(carContext)
        {
        }

        public override ITemplate OnGetTemplate()
        {
            var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
            var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

            var cancelAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetTitle("Cancel")
                .SetBackgroundColor(CarColor.Red)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Cancel was tapped"))
                .Build();

            var acceptAction = new Action.Builder()
                .SetIcon(dotnetBotCarIcon)
                .SetTitle("Accept")
                .SetBackgroundColor(CarColor.Green)
                .SetOnClickListener(new ActionOnClickListener(CarContext, "Accept was tapped"))
                .Build();

            return new MessageTemplate.Builder("This is a message template x")
                .SetTitle("MAUI Android Auto - Menu")
                .SetHeaderAction(Action.Back)
                .SetIcon(dotnetBotCarIcon)
                .AddAction(cancelAction)
                .AddAction(acceptAction)
                .Build();
        }
    }
}
