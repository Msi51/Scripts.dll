using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class ISubstanceMixtureHolder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Public_Abstract_Virtual_New_Int32_SubstanceMixture_0;

	static ISubstanceMixtureHolder()
	{
		Il2CppClassPointerStore<ISubstanceMixtureHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISubstanceMixtureHolder");
		NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubstanceMixtureHolder>.NativeClassPtr, 100682028);
		NativeMethodInfoPtr_GetIndex_Public_Abstract_Virtual_New_Int32_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubstanceMixtureHolder>.NativeClassPtr, 100682029);
	}

	[CallerCount(0)]
	public unsafe virtual SubstanceMixture GetSubstanceMixture(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int GetIndex(SubstanceMixture substanceMixture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetIndex_Public_Abstract_Virtual_New_Int32_SubstanceMixture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ISubstanceMixtureHolder(IntPtr pointer)
		: base(pointer)
	{
	}
}
