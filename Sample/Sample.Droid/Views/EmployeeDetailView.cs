using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V4;
using Sample.Core.ViewModels;
using System.Collections.Generic;
using Android.Views;

namespace Sample.Droid.Views
{
    [Activity(Label = "Employee Detail", Theme = "@style/HoloTheme")]
    public class EmployeeDetailView : MvxCachingFragmentCompatActivity
    {
        private EmployeeDetailViewModel viewModel;
        public EmployeeDetailViewModel EmpViewModel
        {
            get
            {
                return viewModel ?? (viewModel = base.ViewModel as EmployeeDetailViewModel);
            }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeDetailView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.myToolbar);

            if(toolbar != null)
            {
                SetSupportActionBar(toolbar);
            }
            // View Pager
            var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                // Add tabs in view pager

                var fragments = new List<MvxFragmentStatePagerAdapter2.FragmentInfo>
                {
                    new MvxFragmentStatePagerAdapter2.FragmentInfo("EmpDetail", typeof(Tab_EmployeeDetail), typeof(EmployeeDetailViewModel)),
                    new MvxFragmentStatePagerAdapter2.FragmentInfo("Address", typeof(Tab_EmployeeAddress),typeof(EmployeeDetailViewModel))
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_LOCATION, typeof(Tab_CustomerLocation),typeof(EmployeeEditorViewModel)),
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_CONTRACT, typeof(Tab_CustomerContract),typeof(EmployeeEditorViewModel))
                };
                viewPager.Adapter = new MvxFragmentStatePagerAdapter2(this, SupportFragmentManager, fragments);
            }

            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            // return base.OnCreateOptionsMenu(menu);
            this.MenuInflater.Inflate(Resource.Menu.EmpSaveMenu, menu);
            return true;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
           // return base.OnOptionsItemSelected(item);

            if(item.ItemId == Resource.Id.menu_accept)
            {
                this.EmpViewModel.CmdEmpSave.Execute(null);
            }
            return true;

        }
    }
}