using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class QuickMenuSubMenuDetails : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstType;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstTypeOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstTypeResultAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondType;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondTypeOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdType;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdTypeOptions;

	public unsafe RadialMenuActionType firstType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstType);
			return *(RadialMenuActionType*)num;
		}
		set
		{
			*(RadialMenuActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstType)) = radialMenuActionType;
		}
	}

	public unsafe Il2CppReferenceArray<IQuickMenuActionOption> firstTypeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTypeOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IQuickMenuActionOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTypeOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppSystem.Action<UIComponent> firstTypeResultAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTypeResultAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<UIComponent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTypeResultAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe RadialMenuActionType secondType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondType);
			return *(RadialMenuActionType*)num;
		}
		set
		{
			*(RadialMenuActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondType)) = radialMenuActionType;
		}
	}

	public unsafe Il2CppReferenceArray<IQuickMenuActionOption> secondTypeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondTypeOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IQuickMenuActionOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondTypeOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe RadialMenuActionType thirdType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdType);
			return *(RadialMenuActionType*)num;
		}
		set
		{
			*(RadialMenuActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdType)) = radialMenuActionType;
		}
	}

	public unsafe Il2CppReferenceArray<IQuickMenuActionOption> thirdTypeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdTypeOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IQuickMenuActionOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdTypeOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static QuickMenuSubMenuDetails()
	{
		Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QuickMenuSubMenuDetails");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr);
		NativeFieldInfoPtr_firstType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "firstType");
		NativeFieldInfoPtr_firstTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "firstTypeOptions");
		NativeFieldInfoPtr_firstTypeResultAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "firstTypeResultAction");
		NativeFieldInfoPtr_secondType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "secondType");
		NativeFieldInfoPtr_secondTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "secondTypeOptions");
		NativeFieldInfoPtr_thirdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "thirdType");
		NativeFieldInfoPtr_thirdTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr, "thirdTypeOptions");
	}

	public QuickMenuSubMenuDetails(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public QuickMenuSubMenuDetails()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuickMenuSubMenuDetails>.NativeClassPtr))
	{
	}
}
