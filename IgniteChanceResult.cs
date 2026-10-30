using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct IgniteChanceResult
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_chance;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalTinderFuel;

	private static readonly System.IntPtr NativeFieldInfoPtr_tinderFuelMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalKindlingFuel;

	private static readonly System.IntPtr NativeFieldInfoPtr_kindlingFuelMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_tinderWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_kindlingWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionSourceQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceBonus;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TinderAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KindlingAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateChance_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public float chance;

	[FieldOffset(4)]
	public float totalTinderFuel;

	[FieldOffset(8)]
	public float tinderFuelMax;

	[FieldOffset(12)]
	public float totalKindlingFuel;

	[FieldOffset(16)]
	public float kindlingFuelMax;

	[FieldOffset(20)]
	public float fuelWetness;

	[FieldOffset(24)]
	public float tinderWetness;

	[FieldOffset(28)]
	public float kindlingWetness;

	[FieldOffset(32)]
	public float ignitionSourceQuality;

	[FieldOffset(36)]
	public float chanceBonus;

	public unsafe float TinderAmount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107967, RefRangeEnd = 107970, XrefRangeStart = 107964, XrefRangeEnd = 107967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TinderAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float KindlingAmount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107973, RefRangeEnd = 107976, XrefRangeStart = 107970, XrefRangeEnd = 107973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KindlingAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static IgniteChanceResult()
	{
		Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IgniteChanceResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr);
		NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "chance");
		NativeFieldInfoPtr_totalTinderFuel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "totalTinderFuel");
		NativeFieldInfoPtr_tinderFuelMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "tinderFuelMax");
		NativeFieldInfoPtr_totalKindlingFuel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "totalKindlingFuel");
		NativeFieldInfoPtr_kindlingFuelMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "kindlingFuelMax");
		NativeFieldInfoPtr_fuelWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "fuelWetness");
		NativeFieldInfoPtr_tinderWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "tinderWetness");
		NativeFieldInfoPtr_kindlingWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "kindlingWetness");
		NativeFieldInfoPtr_ignitionSourceQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "ignitionSourceQuality");
		NativeFieldInfoPtr_chanceBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, "chanceBonus");
		NativeMethodInfoPtr_get_TinderAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, 100669883);
		NativeMethodInfoPtr_get_KindlingAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, 100669884);
		NativeMethodInfoPtr_CalculateChance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, 100669885);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, 100669886);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 107999, RefRangeEnd = 108000, XrefRangeStart = 107976, XrefRangeEnd = 107999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateChance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateChance_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108000, XrefRangeEnd = 108009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IgniteChanceResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
