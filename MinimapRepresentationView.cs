using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class MinimapRepresentationView : BaseView
{
	private static readonly IntPtr NativeFieldInfoPtr_minimapIconType;

	private static readonly IntPtr NativeFieldInfoPtr_minimapIconSize;

	private static readonly IntPtr NativeFieldInfoPtr_shouldMinimapIconRotate;

	private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMinimapIconType_Public_Virtual_Final_New_MinimapIconType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMinimapIconSize_Public_Virtual_Final_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldRotate_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SerializableEnumField<MinimapIconType> minimapIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconType);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<MinimapIconType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializablePrimitiveField<float> minimapIconSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconSize);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconSize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> shouldMinimapIconRotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldMinimapIconRotate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldMinimapIconRotate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	static MinimapRepresentationView()
	{
		Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MinimapRepresentationView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr);
		NativeFieldInfoPtr_minimapIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, "minimapIconType");
		NativeFieldInfoPtr_minimapIconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, "minimapIconSize");
		NativeFieldInfoPtr_shouldMinimapIconRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, "shouldMinimapIconRotate");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682261);
		NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682262);
		NativeMethodInfoPtr_GetMinimapIconType_Public_Virtual_Final_New_MinimapIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682263);
		NativeMethodInfoPtr_GetMinimapIconSize_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682264);
		NativeMethodInfoPtr_ShouldRotate_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682265);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr, 100682266);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250010, XrefRangeEnd = 250012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetComponentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250012, XrefRangeEnd = 250027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250027, XrefRangeEnd = 250028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual MinimapIconType GetMinimapIconType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinimapIconType_Public_Virtual_Final_New_MinimapIconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(MinimapIconType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250028, XrefRangeEnd = 250029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetMinimapIconSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinimapIconSize_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250029, XrefRangeEnd = 250030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ShouldRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRotate_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MinimapRepresentationView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimapRepresentationView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MinimapRepresentationView(IntPtr pointer)
		: base(pointer)
	{
	}
}
