using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using strange.extensions.injector.api;

public class IngredientLessRequirementConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_itemIngredientIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_craftingManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe List<string> itemIngredientIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIngredientIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIngredientIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ICraftingManager craftingManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICraftingManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)craftingManager));
		}
	}

	static IngredientLessRequirementConsideration()
	{
		Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IngredientLessRequirementConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_itemIngredientIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr, "itemIngredientIdentifiers");
		NativeFieldInfoPtr_craftingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr, "craftingManager");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr, 100668312);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr, 100668313);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr, 100668314);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 89001, RefRangeEnd = 89025, XrefRangeStart = 89001, XrefRangeEnd = 89025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IngredientLessRequirementConsideration(List<string> itemIngredientIdentifiers)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientLessRequirementConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIngredientIdentifiers);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89720, XrefRangeEnd = 89725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(IInjectionBinder binder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89725, XrefRangeEnd = 89759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IngredientLessRequirementConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}
