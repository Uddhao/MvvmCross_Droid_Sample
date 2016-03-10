using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Sample.Core.ViewModels;

namespace Sample.Droid.Views
{
    [Activity(Label = "Employee List", Theme = "@style/HoloTheme")]
    public class EmployeeView : MvxAppCompatActivity<EmployeeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.myToolbar);

            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            // return base.OnCreateOptionsMenu(menu);
            this.MenuInflater.Inflate(Resource.Menu.EmpAddMenu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            //return base.OnOptionsItemSelected(item);
            this.ViewModel.CmdEmpAdd.Execute(null);
            return true;
        }
    }

}