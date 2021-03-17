package crc64161e8fdf59da1b2d;


public class CustomRenderer_Android
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("xa006.Droid.CustomRenderer_Android, xa006.Android", CustomRenderer_Android.class, __md_methods);
	}


	public CustomRenderer_Android (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomRenderer_Android.class)
			mono.android.TypeManager.Activate ("xa006.Droid.CustomRenderer_Android, xa006.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomRenderer_Android (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomRenderer_Android.class)
			mono.android.TypeManager.Activate ("xa006.Droid.CustomRenderer_Android, xa006.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomRenderer_Android (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomRenderer_Android.class)
			mono.android.TypeManager.Activate ("xa006.Droid.CustomRenderer_Android, xa006.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
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
