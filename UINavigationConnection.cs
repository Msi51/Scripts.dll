using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

public sealed class UINavigationConnection : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentScrollRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	public unsafe ISelectableWrapperUI currentUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISelectableWrapperUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectableWrapperUI));
		}
	}

	public unsafe ISelectableWrapperUI previousUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISelectableWrapperUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectableWrapperUI));
		}
	}

	public unsafe ScrollRect parentScrollRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentScrollRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentScrollRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollRect));
		}
	}

	public unsafe UINavigationDirection direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(UINavigationDirection*)num;
		}
		set
		{
			*(UINavigationDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = uINavigationDirection;
		}
	}

	static UINavigationConnection()
	{
		Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "UINavigationConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr);
		NativeFieldInfoPtr_currentUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr, "currentUI");
		NativeFieldInfoPtr_previousUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr, "previousUI");
		NativeFieldInfoPtr_parentScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr, "parentScrollRect");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr, "direction");
	}

	public UINavigationConnection(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UINavigationConnection()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationConnection>.NativeClassPtr))
	{
	}
}
