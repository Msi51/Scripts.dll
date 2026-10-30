using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class InjuryAppliedEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuredEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_numInjuriesAppliedThisFrame;

	public unsafe string injuryIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Entity attackerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity injuredEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuredEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuredEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe InjuryLocation injuryLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocation);
			return *(InjuryLocation*)num;
		}
		set
		{
			*(InjuryLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocation)) = injuryLocation;
		}
	}

	public unsafe int numInjuriesAppliedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInjuriesAppliedThisFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInjuriesAppliedThisFrame)) = num;
		}
	}

	static InjuryAppliedEventParams()
	{
		Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InjuryAppliedEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_injuryIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr, "injuryIdentifier");
		NativeFieldInfoPtr_attackerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr, "attackerEntity");
		NativeFieldInfoPtr_injuredEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr, "injuredEntity");
		NativeFieldInfoPtr_injuryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr, "injuryLocation");
		NativeFieldInfoPtr_numInjuriesAppliedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr, "numInjuriesAppliedThisFrame");
	}

	public InjuryAppliedEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InjuryAppliedEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjuryAppliedEventParams>.NativeClassPtr))
	{
	}
}
