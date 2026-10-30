using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class ITrader : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetProposedTrade_Public_Abstract_Virtual_New_Void_ProposedTrade_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProposedTrade_Public_Abstract_Virtual_New_ProposedTrade_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetTradeMargin_Public_Abstract_Virtual_New_Single_0;

	static ITrader()
	{
		Il2CppClassPointerStore<ITrader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ITrader");
		NativeMethodInfoPtr_SetProposedTrade_Public_Abstract_Virtual_New_Void_ProposedTrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrader>.NativeClassPtr, 100682067);
		NativeMethodInfoPtr_GetProposedTrade_Public_Abstract_Virtual_New_ProposedTrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrader>.NativeClassPtr, 100682068);
		NativeMethodInfoPtr_GetTradeMargin_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrader>.NativeClassPtr, 100682069);
	}

	[CallerCount(0)]
	public unsafe virtual void SetProposedTrade(ProposedTrade proposedTrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proposedTrade);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetProposedTrade_Public_Abstract_Virtual_New_Void_ProposedTrade_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ProposedTrade GetProposedTrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProposedTrade_Public_Abstract_Virtual_New_ProposedTrade_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ProposedTrade>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual float GetTradeMargin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTradeMargin_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ITrader(IntPtr pointer)
		: base(pointer)
	{
	}
}
