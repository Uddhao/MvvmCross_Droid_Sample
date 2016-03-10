package md58dddb99dd2ee29b3aeb18d99ad828118;


public abstract class MvxDialogFragment
	extends md550815ac19e47a0ecd4ebb2716d6a1933.MvxEventSourceDialogFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.Fragging.Fragments.MvxDialogFragment, MvvmCross.Droid.Support.V7.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxDialogFragment.class, __md_methods);
	}


	public MvxDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxDialogFragment.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.Fragging.Fragments.MvxDialogFragment, MvvmCross.Droid.Support.V7.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
