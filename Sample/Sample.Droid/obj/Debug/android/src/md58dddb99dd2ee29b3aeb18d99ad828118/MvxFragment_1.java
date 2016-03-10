package md58dddb99dd2ee29b3aeb18d99ad828118;


public abstract class MvxFragment_1
	extends md58dddb99dd2ee29b3aeb18d99ad828118.MvxFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.Fragging.Fragments.MvxFragment`1, MvvmCross.Droid.Support.V7.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxFragment_1.class, __md_methods);
	}


	public MvxFragment_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxFragment_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.Fragging.Fragments.MvxFragment`1, MvvmCross.Droid.Support.V7.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
