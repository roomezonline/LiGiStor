using Android.App;
using Android.OS;

namespace LigiApp
{
    [Activity(Label = "LigiApp")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var service = new LiGiStor.core.Ligidataservice();



        }
    }
}

