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

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct DamageValues
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<DamageValues>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_slashingDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_piercingDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_bluntDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_choppingDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_miningDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_sawingDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_hammerDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirstDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_knockbackForce;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDamage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DamageValues_DamageValues_DamageValues_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_DamageValues_DamageValues_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public float slashingDamage;

	[FieldOffset(4)]
	public float piercingDamage;

	[FieldOffset(8)]
	public float bluntDamage;

	[FieldOffset(12)]
	public float choppingDamage;

	[FieldOffset(16)]
	public float miningDamage;

	[FieldOffset(20)]
	public float sawingDamage;

	[FieldOffset(24)]
	public float hammerDamage;

	[FieldOffset(28)]
	public float hungerDamage;

	[FieldOffset(32)]
	public float thirstDamage;

	[FieldOffset(36)]
	public float knockbackForce;

	public unsafe float TotalDamage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96655, RefRangeEnd = 96657, XrefRangeStart = 96655, XrefRangeEnd = 96655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalDamage_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DamageValues()
	{
		Il2CppClassPointerStore<DamageValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DamageValues");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageValues>.NativeClassPtr);
		NativeFieldInfoPtr_slashingDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "slashingDamage");
		NativeFieldInfoPtr_piercingDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "piercingDamage");
		NativeFieldInfoPtr_bluntDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "bluntDamage");
		NativeFieldInfoPtr_choppingDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "choppingDamage");
		NativeFieldInfoPtr_miningDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "miningDamage");
		NativeFieldInfoPtr_sawingDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "sawingDamage");
		NativeFieldInfoPtr_hammerDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "hammerDamage");
		NativeFieldInfoPtr_hungerDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "hungerDamage");
		NativeFieldInfoPtr_thirstDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "thirstDamage");
		NativeFieldInfoPtr_knockbackForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, "knockbackForce");
		NativeMethodInfoPtr_get_TotalDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, 100668668);
		NativeMethodInfoPtr_op_Addition_Public_Static_DamageValues_DamageValues_DamageValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, 100668669);
		NativeMethodInfoPtr_op_Multiply_Public_Static_DamageValues_DamageValues_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, 100668670);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, 100668671);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96657, RefRangeEnd = 96658, XrefRangeStart = 96657, XrefRangeEnd = 96657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DamageValues operator +(DamageValues a, DamageValues b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(DamageValues**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_DamageValues_DamageValues_DamageValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DamageValues*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 96658, RefRangeEnd = 96664, XrefRangeStart = 96658, XrefRangeEnd = 96658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DamageValues operator *(DamageValues a, float amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_DamageValues_DamageValues_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DamageValues*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96664, XrefRangeEnd = 96674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageValues>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
