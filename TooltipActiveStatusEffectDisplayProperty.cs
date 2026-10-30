using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class TooltipActiveStatusEffectDisplayProperty : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_property;

	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeStatusEffect;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_Virtual_Final_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ModelDisplayProperty property
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_property);
			return new ModelDisplayProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_property), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modelDisplayProperty)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	public unsafe ActiveStatusEffect activeStatusEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusEffect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveStatusEffect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeStatusEffect));
		}
	}

	static TooltipActiveStatusEffectDisplayProperty()
	{
		Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TooltipActiveStatusEffectDisplayProperty");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr);
		NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr, "property");
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr, "world");
		NativeFieldInfoPtr_activeStatusEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr, "activeStatusEffect");
		NativeMethodInfoPtr_GetText_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr, 100667646);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr, 100667647);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80096, XrefRangeEnd = 80097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TooltipActiveStatusEffectDisplayProperty()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipActiveStatusEffectDisplayProperty>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TooltipActiveStatusEffectDisplayProperty(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
