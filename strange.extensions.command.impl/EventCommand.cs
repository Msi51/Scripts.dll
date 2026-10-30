using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.dispatcher.eventdispatcher.api;

namespace strange.extensions.command.impl;

public class EventCommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__dispatcher_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__evt_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_get_IEventDispatcher_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_dispatcher_Public_set_Void_IEventDispatcher_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_evt_Public_get_IEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_evt_Public_set_Void_IEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_Retain_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe IEventDispatcher _dispatcher_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dispatcher_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEventDispatcher>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dispatcher_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventDispatcher));
		}
	}

	public unsafe IEvent _evt_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evt_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__evt_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe IEventDispatcher dispatcher
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dispatcher_Public_get_IEventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEventDispatcher>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dispatcher_Public_set_Void_IEventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IEvent evt
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97543, RefRangeEnd = 97544, XrefRangeStart = 97543, XrefRangeEnd = 97544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_evt_Public_get_IEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEvent>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_evt_Public_set_Void_IEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static EventCommand()
	{
		Il2CppClassPointerStore<EventCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.command.impl", "EventCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCommand>.NativeClassPtr);
		NativeFieldInfoPtr__dispatcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, "<dispatcher>k__BackingField");
		NativeFieldInfoPtr__evt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, "<evt>k__BackingField");
		NativeMethodInfoPtr_get_dispatcher_Public_get_IEventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685215);
		NativeMethodInfoPtr_set_dispatcher_Public_set_Void_IEventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685216);
		NativeMethodInfoPtr_get_evt_Public_get_IEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685217);
		NativeMethodInfoPtr_set_evt_Public_set_Void_IEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685218);
		NativeMethodInfoPtr_Retain_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685219);
		NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685220);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommand>.NativeClassPtr, 100685221);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 281856, RefRangeEnd = 281859, XrefRangeStart = 281856, XrefRangeEnd = 281859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Retain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Retain_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(69)]
	[CachedScanResults(RefRangeStart = 281787, RefRangeEnd = 281856, XrefRangeStart = 281787, XrefRangeEnd = 281856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventCommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EventCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}
