
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using MvvmCross.Binding.Droid.BindingContext;

namespace Sample.Droid.Views
{
    [Register("sample.droid.views.Tab_EmployeeDetail")]
    public class Tab_EmployeeDetail : MvxFragment
    {

        public override View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.tab_EmployeeDetail, null);
            
            return view;
        }
    }
}