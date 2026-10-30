using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ITerrainMinMaxHeightFilterLayer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Abstract_Virtual_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0;

	static ITerrainMinMaxHeightFilterLayer()
	{
		Il2CppClassPointerStore<ITerrainMinMaxHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ITerrainMinMaxHeightFilterLayer");
		NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Abstract_Virtual_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITerrainMinMaxHeightFilterLayer>.NativeClassPtr, 100683879);
	}

	[CallerCount(0)]
	public unsafe virtual void ComputeMinMaxHeights(ref WorldGenerationHeightData data, out float baseMinHeight, out float baseMaxHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref baseMinHeight);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref baseMaxHeight);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Abstract_Virtual_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ITerrainMinMaxHeightFilterLayer(IntPtr pointer)
		: base(pointer)
	{
	}
}
