using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IInputCoordinateLayer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ComputeInputCoordinates_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0;

	static IInputCoordinateLayer()
	{
		Il2CppClassPointerStore<IInputCoordinateLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInputCoordinateLayer");
		NativeMethodInfoPtr_ComputeInputCoordinates_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputCoordinateLayer>.NativeClassPtr, 100683875);
	}

	[CallerCount(0)]
	public unsafe virtual void ComputeInputCoordinates(ref float xCoord, ref float yCoord)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeInputCoordinates_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInputCoordinateLayer(IntPtr pointer)
		: base(pointer)
	{
	}
}
