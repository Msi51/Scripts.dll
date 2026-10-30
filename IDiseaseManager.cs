using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

public class IDiseaseManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateInitialDiseaseLocations_Public_Abstract_Virtual_New_Int32_World_Coordinates_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearExtraDiseaseCenters_Public_Abstract_Virtual_New_Void_World_0;

	static IDiseaseManager()
	{
		Il2CppClassPointerStore<IDiseaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDiseaseManager");
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDiseaseManager>.NativeClassPtr, 100675361);
		NativeMethodInfoPtr_CreateInitialDiseaseLocations_Public_Abstract_Virtual_New_Int32_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDiseaseManager>.NativeClassPtr, 100675362);
		NativeMethodInfoPtr_ClearExtraDiseaseCenters_Public_Abstract_Virtual_New_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDiseaseManager>.NativeClassPtr, 100675363);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int CreateInitialDiseaseLocations(World world, Coordinates startingCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &startingCoordinates;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateInitialDiseaseLocations_Public_Abstract_Virtual_New_Int32_World_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearExtraDiseaseCenters(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearExtraDiseaseCenters_Public_Abstract_Virtual_New_Void_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IDiseaseManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
