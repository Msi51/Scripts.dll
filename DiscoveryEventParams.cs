using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class DiscoveryEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_discoveryData;

	public unsafe DiscoveryData discoveryData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryData);
			return new DiscoveryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscoveryData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)discoveryData)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DiscoveryData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static DiscoveryEventParams()
	{
		Il2CppClassPointerStore<DiscoveryEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DiscoveryEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveryEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_discoveryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryEventParams>.NativeClassPtr, "discoveryData");
	}

	public DiscoveryEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DiscoveryEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscoveryEventParams>.NativeClassPtr))
	{
	}
}
