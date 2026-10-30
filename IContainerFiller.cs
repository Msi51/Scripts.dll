using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IContainerFiller : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSubstanceFillRate_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_FillSubstance_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveSubstance_Public_Abstract_Virtual_New_Void_ActionType_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRemainingSubstanceStorage_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStoredSubstanceAmount_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStoredSubstancePercentage_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetContainerName_Public_Abstract_Virtual_New_String_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanAcceptSubstance_Public_Abstract_Virtual_New_Boolean_ActionType_SubstanceMixture_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_ActionType_0;

	static IContainerFiller()
	{
		Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IContainerFiller");
		NativeMethodInfoPtr_GetSubstanceFillRate_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681318);
		NativeMethodInfoPtr_FillSubstance_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681319);
		NativeMethodInfoPtr_RemoveSubstance_Public_Abstract_Virtual_New_Void_ActionType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681320);
		NativeMethodInfoPtr_GetRemainingSubstanceStorage_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681321);
		NativeMethodInfoPtr_GetStoredSubstanceAmount_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681322);
		NativeMethodInfoPtr_GetStoredSubstancePercentage_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681323);
		NativeMethodInfoPtr_GetContainerName_Public_Abstract_Virtual_New_String_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681324);
		NativeMethodInfoPtr_CanAcceptSubstance_Public_Abstract_Virtual_New_Boolean_ActionType_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681325);
		NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerFiller>.NativeClassPtr, 100681326);
	}

	[CallerCount(0)]
	public unsafe virtual float GetSubstanceFillRate(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstanceFillRate_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void FillSubstance(ActionType actionType, SubstanceMixture substanceMixture, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &amount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FillSubstance_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveSubstance(ActionType actionType, float resultAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &resultAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveSubstance_Public_Abstract_Virtual_New_Void_ActionType_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetRemainingSubstanceStorage(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRemainingSubstanceStorage_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetStoredSubstanceAmount(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStoredSubstanceAmount_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetStoredSubstancePercentage(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStoredSubstancePercentage_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual string GetContainerName(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetContainerName_Public_Abstract_Virtual_New_String_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool CanAcceptSubstance(ActionType actionType, SubstanceMixture mixture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mixture);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanAcceptSubstance_Public_Abstract_Virtual_New_Boolean_ActionType_SubstanceMixture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual SubstanceMixture GetSubstanceMixture(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstanceMixture_Public_Abstract_Virtual_New_SubstanceMixture_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
	}

	public IContainerFiller(IntPtr pointer)
		: base(pointer)
	{
	}
}
