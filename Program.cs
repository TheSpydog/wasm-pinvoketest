using System;
using System.Runtime.InteropServices;

public enum FNA3D_ClearOptions
{
	FNA3D_CLEAROPTIONS_TARGET	= 1,
	FNA3D_CLEAROPTIONS_DEPTHBUFFER	= 2,
	FNA3D_CLEAROPTIONS_STENCIL	= 4
}

public struct Vec4
{
	public float x;
	public float y;
	public float z;
	public float w;

	public Vec4(float x, float y, float z, float w)
	{
		this.x = x;
		this.y = y;
		this.z = z;
		this.w = w;
	}
}

public class Program
{
	[DllImport("nativecode")]
	static extern void FNA3D_Clear(
		IntPtr device,
		FNA3D_ClearOptions clearOptions,
		ref Vec4 color,
		float depth,
		int stencil
	);

	public static void Main()
	{
		Vec4 c = new Vec4(0, 0, 0, 0);
		FNA3D_Clear(IntPtr.Zero, FNA3D_ClearOptions.FNA3D_CLEAROPTIONS_TARGET, ref c, 1, 0);
		Console.WriteLine("Survived!");
	}
}
