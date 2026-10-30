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

public class DoorCloseEffect : BaseResultInteractionEffect<DoorCloseEffect.DoorCloseEffectResult>
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DoorCloseEffectResult
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_success;

		private static readonly System.IntPtr NativeFieldInfoPtr_soundEffectType;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool success;

		[FieldOffset(4)]
		public SoundEffectType soundEffectType;

		static DoorCloseEffectResult()
		{
			Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, "DoorCloseEffectResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr);
			NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr, "success");
			NativeFieldInfoPtr_soundEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr, "soundEffectType");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr, 100671163);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoorCloseEffectResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteResult_Public_Virtual_DoorCloseEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_DoorCloseEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DoorCloseEffect()
	{
		Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DoorCloseEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr);
		NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, 100671158);
		NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, 100671159);
		NativeMethodInfoPtr_ExecuteResult_Public_Virtual_DoorCloseEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, 100671160);
		NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_DoorCloseEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, 100671161);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr, 100671162);
	}

	[CallerCount(0)]
	public unsafe override InteractionEffectType GetEffectType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool AllowClientRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125821, XrefRangeEnd = 125831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override DoorCloseEffectResult ExecuteResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteResult_Public_Virtual_DoorCloseEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DoorCloseEffectResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125831, XrefRangeEnd = 125837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnExecuted(DoorCloseEffectResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_DoorCloseEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125837, XrefRangeEnd = 125840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoorCloseEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorCloseEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoorCloseEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
