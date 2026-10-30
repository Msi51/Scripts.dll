using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IConstructionManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeConstructions_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetConstructions_Public_Abstract_Virtual_New_IEnumerable_1_Construction_0;

	private static readonly IntPtr NativeMethodInfoPtr_CopyConstructionProperties_Public_Abstract_Virtual_New_Void_Entity_IBuildable_Entity_IBuildable_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShelterTypes_Public_Abstract_Virtual_New_IEnumerable_1_ShelterType_0;

	private static readonly IntPtr NativeMethodInfoPtr_DestroyConstruction_Public_Abstract_Virtual_New_Void_Entity_Entity_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolTypeConstructions_Public_Abstract_Virtual_New_List_1_Construction_ToolType_0;

	static IConstructionManager()
	{
		Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IConstructionManager");
		NativeMethodInfoPtr_InitializeConstructions_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675300);
		NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675301);
		NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675302);
		NativeMethodInfoPtr_GetConstructions_Public_Abstract_Virtual_New_IEnumerable_1_Construction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675303);
		NativeMethodInfoPtr_CopyConstructionProperties_Public_Abstract_Virtual_New_Void_Entity_IBuildable_Entity_IBuildable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675304);
		NativeMethodInfoPtr_GetShelterTypes_Public_Abstract_Virtual_New_IEnumerable_1_ShelterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675305);
		NativeMethodInfoPtr_DestroyConstruction_Public_Abstract_Virtual_New_Void_Entity_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675306);
		NativeMethodInfoPtr_GetToolTypeConstructions_Public_Abstract_Virtual_New_List_1_Construction_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionManager>.NativeClassPtr, 100675307);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeConstructions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeConstructions_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Construction GetConstruction(int constructionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&constructionId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Construction>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Construction GetConstruction(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetConstruction_Public_Abstract_Virtual_New_Construction_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Construction>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<Construction> GetConstructions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetConstructions_Public_Abstract_Virtual_New_IEnumerable_1_Construction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Construction>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void CopyConstructionProperties(Entity newEntity, IBuildable newBuildable, Entity otherEntity, IBuildable otherBuildable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newBuildable);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherBuildable);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CopyConstructionProperties_Public_Abstract_Virtual_New_Void_Entity_IBuildable_Entity_IBuildable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<ShelterType> GetShelterTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetShelterTypes_Public_Abstract_Virtual_New_IEnumerable_1_ShelterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<ShelterType>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void DestroyConstruction(Entity constructionEntity, Entity destroyerEntity, bool damaged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destroyerEntity);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &damaged;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DestroyConstruction_Public_Abstract_Virtual_New_Void_Entity_Entity_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<Construction> GetToolTypeConstructions(ToolType toolType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&toolType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolTypeConstructions_Public_Abstract_Virtual_New_List_1_Construction_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Construction>>(intPtr) : null;
	}

	public IConstructionManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
