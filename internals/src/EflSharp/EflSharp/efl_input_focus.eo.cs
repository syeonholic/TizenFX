#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Input { 
/// <summary>Represents a focus event.
/// 1.19</summary>
[FocusNativeInherit]
public class Focus : Efl.Object, Efl.Eo.IWrapper,Efl.Duplicate,Efl.Input.Event
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Input.FocusNativeInherit nativeInherit = new Efl.Input.FocusNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (Focus))
            return Efl.Input.FocusNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
      efl_input_focus_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   public Focus(Efl.Object parent= null
         ) :
      base(efl_input_focus_class_get(), typeof(Focus), parent)
   {
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public Focus(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected Focus(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static Focus static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new Focus(obj.NativeHandle);
   }
   ///<summary>Verifies if the given object is equal to this one.</summary>
   public override bool Equals(object obj)
   {
      var other = obj as Efl.Object;
      if (other == null)
         return false;
      return this.NativeHandle == other.NativeHandle;
   }
   ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
   public override int GetHashCode()
   {
      return this.NativeHandle.ToInt32();
   }
   ///<summary>Turns the native pointer into a string representation.</summary>
   public override String ToString()
   {
      return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
   }
   protected override void register_event_proxies()
   {
      base.register_event_proxies();
   }
   /// <summary>The focused object
   /// 1.19</summary>
   /// <returns>The focused object. In case this represents a canvas focus the object will be <c>null</c>
   /// 1.19</returns>
   virtual public Efl.Object GetObject() {
       var _ret_var = Efl.Input.FocusNativeInherit.efl_input_focus_object_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The focused object
   /// 1.19</summary>
   /// <param name="kw_object">The focused object. In case this represents a canvas focus the object will be <c>null</c>
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetObject( Efl.Object kw_object) {
                         Efl.Input.FocusNativeInherit.efl_input_focus_object_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), kw_object);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Creates a carbon copy of this object and returns it.
   /// The newly created object will have no event handlers or anything of the sort.</summary>
   /// <returns>Returned carbon copy</returns>
   virtual public Efl.Duplicate DoDuplicate() {
       var _ret_var = Efl.DuplicateNativeInherit.efl_duplicate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The time at which an event was generated.
   /// If the event is generated by a server (eg. X.org or Wayland), then the time may be set by the server. Usually this time will be based on the monotonic clock, if available, but this class can not guarantee it.
   /// 1.19</summary>
   /// <returns>Time in milliseconds when the event happened.
   /// 1.19</returns>
   virtual public double GetTimestamp() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_timestamp_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Call this when generating events manually.
   /// 1.19</summary>
   /// <param name="ms">Time in milliseconds when the event happened.
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetTimestamp( double ms) {
                         Efl.Input.EventNativeInherit.efl_input_timestamp_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), ms);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Input device that originated this event.
   /// 1.19</summary>
   /// <returns>Input device origin
   /// 1.19</returns>
   virtual public Efl.Input.Device GetDevice() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_device_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Input device that originated this event.
   /// 1.19</summary>
   /// <param name="dev">Input device origin
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetDevice( Efl.Input.Device dev) {
                         Efl.Input.EventNativeInherit.efl_input_device_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), dev);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Extra flags for this event, may be changed by the user.
   /// 1.19</summary>
   /// <returns>Input event flags
   /// 1.19</returns>
   virtual public Efl.Input.Flags GetEventFlags() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_event_flags_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Extra flags for this event, may be changed by the user.
   /// 1.19</summary>
   /// <param name="flags">Input event flags
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetEventFlags( Efl.Input.Flags flags) {
                         Efl.Input.EventNativeInherit.efl_input_event_flags_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), flags);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event is on hold.
   /// 1.19</summary>
   /// <returns><c>true</c> if the event is on hold, <c>false</c> otherwise
   /// 1.19</returns>
   virtual public bool GetProcessed() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_processed_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event is on hold.
   /// 1.19</summary>
   /// <param name="val"><c>true</c> if the event is on hold, <c>false</c> otherwise
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetProcessed( bool val) {
                         Efl.Input.EventNativeInherit.efl_input_processed_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), val);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event happened while scrolling.
   /// 1.19</summary>
   /// <returns><c>true</c> if the event happened while scrolling, <c>false</c> otherwise
   /// 1.19</returns>
   virtual public bool GetScrolling() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_scrolling_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event happened while scrolling.
   /// 1.19</summary>
   /// <param name="val"><c>true</c> if the event happened while scrolling, <c>false</c> otherwise
   /// 1.19</param>
   /// <returns></returns>
   virtual public  void SetScrolling( bool val) {
                         Efl.Input.EventNativeInherit.efl_input_scrolling_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), val);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary><c>true</c> if the event was fake, not triggered by real hardware.
   /// 1.19</summary>
   /// <returns><c>true</c> if the event was not from real hardware, <c>false</c> otherwise
   /// 1.19</returns>
   virtual public bool GetFake() {
       var _ret_var = Efl.Input.EventNativeInherit.efl_input_fake_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Resets the internal data to 0 or default values.
   /// 1.19</summary>
   /// <returns></returns>
   virtual public  void Reset() {
       Efl.Input.EventNativeInherit.efl_input_reset_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>The focused object
/// 1.19</summary>
/// <value>The focused object. In case this represents a canvas focus the object will be <c>null</c>
/// 1.19</value>
   public Efl.Object Object {
      get { return GetObject(); }
      set { SetObject( value); }
   }
   /// <summary>The time at which an event was generated.
/// If the event is generated by a server (eg. X.org or Wayland), then the time may be set by the server. Usually this time will be based on the monotonic clock, if available, but this class can not guarantee it.
/// 1.19</summary>
/// <value>Time in milliseconds when the event happened.
/// 1.19</value>
   public double Timestamp {
      get { return GetTimestamp(); }
      set { SetTimestamp( value); }
   }
   /// <summary>Input device that originated this event.
/// 1.19</summary>
/// <value>Input device origin
/// 1.19</value>
   public Efl.Input.Device Device {
      get { return GetDevice(); }
      set { SetDevice( value); }
   }
   /// <summary>Extra flags for this event, may be changed by the user.
/// 1.19</summary>
/// <value>Input event flags
/// 1.19</value>
   public Efl.Input.Flags EventFlags {
      get { return GetEventFlags(); }
      set { SetEventFlags( value); }
   }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event is on hold.
/// 1.19</summary>
/// <value><c>true</c> if the event is on hold, <c>false</c> otherwise
/// 1.19</value>
   public bool Processed {
      get { return GetProcessed(); }
      set { SetProcessed( value); }
   }
   /// <summary><c>true</c> if <see cref="Efl.Input.Event.EventFlags"/> indicates the event happened while scrolling.
/// 1.19</summary>
/// <value><c>true</c> if the event happened while scrolling, <c>false</c> otherwise
/// 1.19</value>
   public bool Scrolling {
      get { return GetScrolling(); }
      set { SetScrolling( value); }
   }
   /// <summary><c>true</c> if the event was fake, not triggered by real hardware.
/// 1.19</summary>
/// <value><c>true</c> if the event was not from real hardware, <c>false</c> otherwise
/// 1.19</value>
   public bool Fake {
      get { return GetFake(); }
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Input.Focus.efl_input_focus_class_get();
   }
}
public class FocusNativeInherit : Efl.ObjectNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Evas);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_input_focus_object_get_static_delegate == null)
      efl_input_focus_object_get_static_delegate = new efl_input_focus_object_get_delegate(object_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_focus_object_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_focus_object_get_static_delegate)});
      if (efl_input_focus_object_set_static_delegate == null)
      efl_input_focus_object_set_static_delegate = new efl_input_focus_object_set_delegate(object_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_focus_object_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_focus_object_set_static_delegate)});
      if (efl_duplicate_static_delegate == null)
      efl_duplicate_static_delegate = new efl_duplicate_delegate(duplicate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_duplicate"), func = Marshal.GetFunctionPointerForDelegate(efl_duplicate_static_delegate)});
      if (efl_input_timestamp_get_static_delegate == null)
      efl_input_timestamp_get_static_delegate = new efl_input_timestamp_get_delegate(timestamp_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_timestamp_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_timestamp_get_static_delegate)});
      if (efl_input_timestamp_set_static_delegate == null)
      efl_input_timestamp_set_static_delegate = new efl_input_timestamp_set_delegate(timestamp_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_timestamp_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_timestamp_set_static_delegate)});
      if (efl_input_device_get_static_delegate == null)
      efl_input_device_get_static_delegate = new efl_input_device_get_delegate(device_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_device_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_device_get_static_delegate)});
      if (efl_input_device_set_static_delegate == null)
      efl_input_device_set_static_delegate = new efl_input_device_set_delegate(device_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_device_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_device_set_static_delegate)});
      if (efl_input_event_flags_get_static_delegate == null)
      efl_input_event_flags_get_static_delegate = new efl_input_event_flags_get_delegate(event_flags_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_event_flags_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_event_flags_get_static_delegate)});
      if (efl_input_event_flags_set_static_delegate == null)
      efl_input_event_flags_set_static_delegate = new efl_input_event_flags_set_delegate(event_flags_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_event_flags_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_event_flags_set_static_delegate)});
      if (efl_input_processed_get_static_delegate == null)
      efl_input_processed_get_static_delegate = new efl_input_processed_get_delegate(processed_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_processed_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_processed_get_static_delegate)});
      if (efl_input_processed_set_static_delegate == null)
      efl_input_processed_set_static_delegate = new efl_input_processed_set_delegate(processed_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_processed_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_processed_set_static_delegate)});
      if (efl_input_scrolling_get_static_delegate == null)
      efl_input_scrolling_get_static_delegate = new efl_input_scrolling_get_delegate(scrolling_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_scrolling_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_scrolling_get_static_delegate)});
      if (efl_input_scrolling_set_static_delegate == null)
      efl_input_scrolling_set_static_delegate = new efl_input_scrolling_set_delegate(scrolling_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_scrolling_set"), func = Marshal.GetFunctionPointerForDelegate(efl_input_scrolling_set_static_delegate)});
      if (efl_input_fake_get_static_delegate == null)
      efl_input_fake_get_static_delegate = new efl_input_fake_get_delegate(fake_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_fake_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_fake_get_static_delegate)});
      if (efl_input_reset_static_delegate == null)
      efl_input_reset_static_delegate = new efl_input_reset_delegate(reset);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_reset"), func = Marshal.GetFunctionPointerForDelegate(efl_input_reset_static_delegate)});
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Input.Focus.efl_input_focus_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Input.Focus.efl_input_focus_class_get();
   }


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))] private delegate Efl.Object efl_input_focus_object_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))] public delegate Efl.Object efl_input_focus_object_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_focus_object_get_api_delegate> efl_input_focus_object_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_focus_object_get_api_delegate>(_Module, "efl_input_focus_object_get");
    private static Efl.Object object_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_focus_object_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Object _ret_var = default(Efl.Object);
         try {
            _ret_var = ((Focus)wrapper).GetObject();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_focus_object_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_focus_object_get_delegate efl_input_focus_object_get_static_delegate;


    private delegate  void efl_input_focus_object_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object kw_object);


    public delegate  void efl_input_focus_object_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object kw_object);
    public static Efl.Eo.FunctionWrapper<efl_input_focus_object_set_api_delegate> efl_input_focus_object_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_focus_object_set_api_delegate>(_Module, "efl_input_focus_object_set");
    private static  void object_set(System.IntPtr obj, System.IntPtr pd,  Efl.Object kw_object)
   {
      Eina.Log.Debug("function efl_input_focus_object_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetObject( kw_object);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_focus_object_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  kw_object);
      }
   }
   private static efl_input_focus_object_set_delegate efl_input_focus_object_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.DuplicateConcrete, Efl.Eo.OwnTag>))] private delegate Efl.Duplicate efl_duplicate_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.DuplicateConcrete, Efl.Eo.OwnTag>))] public delegate Efl.Duplicate efl_duplicate_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_duplicate_api_delegate> efl_duplicate_ptr = new Efl.Eo.FunctionWrapper<efl_duplicate_api_delegate>(_Module, "efl_duplicate");
    private static Efl.Duplicate duplicate(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_duplicate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Duplicate _ret_var = default(Efl.Duplicate);
         try {
            _ret_var = ((Focus)wrapper).DoDuplicate();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_duplicate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_duplicate_delegate efl_duplicate_static_delegate;


    private delegate double efl_input_timestamp_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate double efl_input_timestamp_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_timestamp_get_api_delegate> efl_input_timestamp_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_timestamp_get_api_delegate>(_Module, "efl_input_timestamp_get");
    private static double timestamp_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_timestamp_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  double _ret_var = default(double);
         try {
            _ret_var = ((Focus)wrapper).GetTimestamp();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_timestamp_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_timestamp_get_delegate efl_input_timestamp_get_static_delegate;


    private delegate  void efl_input_timestamp_set_delegate(System.IntPtr obj, System.IntPtr pd,   double ms);


    public delegate  void efl_input_timestamp_set_api_delegate(System.IntPtr obj,   double ms);
    public static Efl.Eo.FunctionWrapper<efl_input_timestamp_set_api_delegate> efl_input_timestamp_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_timestamp_set_api_delegate>(_Module, "efl_input_timestamp_set");
    private static  void timestamp_set(System.IntPtr obj, System.IntPtr pd,  double ms)
   {
      Eina.Log.Debug("function efl_input_timestamp_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetTimestamp( ms);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_timestamp_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  ms);
      }
   }
   private static efl_input_timestamp_set_delegate efl_input_timestamp_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] private delegate Efl.Input.Device efl_input_device_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] public delegate Efl.Input.Device efl_input_device_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_device_get_api_delegate> efl_input_device_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_device_get_api_delegate>(_Module, "efl_input_device_get");
    private static Efl.Input.Device device_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_device_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Input.Device _ret_var = default(Efl.Input.Device);
         try {
            _ret_var = ((Focus)wrapper).GetDevice();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_device_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_device_get_delegate efl_input_device_get_static_delegate;


    private delegate  void efl_input_device_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device dev);


    public delegate  void efl_input_device_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device dev);
    public static Efl.Eo.FunctionWrapper<efl_input_device_set_api_delegate> efl_input_device_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_device_set_api_delegate>(_Module, "efl_input_device_set");
    private static  void device_set(System.IntPtr obj, System.IntPtr pd,  Efl.Input.Device dev)
   {
      Eina.Log.Debug("function efl_input_device_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetDevice( dev);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_device_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  dev);
      }
   }
   private static efl_input_device_set_delegate efl_input_device_set_static_delegate;


    private delegate Efl.Input.Flags efl_input_event_flags_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Input.Flags efl_input_event_flags_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_event_flags_get_api_delegate> efl_input_event_flags_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_event_flags_get_api_delegate>(_Module, "efl_input_event_flags_get");
    private static Efl.Input.Flags event_flags_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_event_flags_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Input.Flags _ret_var = default(Efl.Input.Flags);
         try {
            _ret_var = ((Focus)wrapper).GetEventFlags();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_event_flags_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_event_flags_get_delegate efl_input_event_flags_get_static_delegate;


    private delegate  void efl_input_event_flags_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Input.Flags flags);


    public delegate  void efl_input_event_flags_set_api_delegate(System.IntPtr obj,   Efl.Input.Flags flags);
    public static Efl.Eo.FunctionWrapper<efl_input_event_flags_set_api_delegate> efl_input_event_flags_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_event_flags_set_api_delegate>(_Module, "efl_input_event_flags_set");
    private static  void event_flags_set(System.IntPtr obj, System.IntPtr pd,  Efl.Input.Flags flags)
   {
      Eina.Log.Debug("function efl_input_event_flags_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetEventFlags( flags);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_event_flags_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  flags);
      }
   }
   private static efl_input_event_flags_set_delegate efl_input_event_flags_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_input_processed_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_input_processed_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_processed_get_api_delegate> efl_input_processed_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_processed_get_api_delegate>(_Module, "efl_input_processed_get");
    private static bool processed_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_processed_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Focus)wrapper).GetProcessed();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_processed_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_processed_get_delegate efl_input_processed_get_static_delegate;


    private delegate  void efl_input_processed_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool val);


    public delegate  void efl_input_processed_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool val);
    public static Efl.Eo.FunctionWrapper<efl_input_processed_set_api_delegate> efl_input_processed_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_processed_set_api_delegate>(_Module, "efl_input_processed_set");
    private static  void processed_set(System.IntPtr obj, System.IntPtr pd,  bool val)
   {
      Eina.Log.Debug("function efl_input_processed_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetProcessed( val);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_processed_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  val);
      }
   }
   private static efl_input_processed_set_delegate efl_input_processed_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_input_scrolling_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_input_scrolling_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_scrolling_get_api_delegate> efl_input_scrolling_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_scrolling_get_api_delegate>(_Module, "efl_input_scrolling_get");
    private static bool scrolling_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_scrolling_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Focus)wrapper).GetScrolling();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_scrolling_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_scrolling_get_delegate efl_input_scrolling_get_static_delegate;


    private delegate  void efl_input_scrolling_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool val);


    public delegate  void efl_input_scrolling_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool val);
    public static Efl.Eo.FunctionWrapper<efl_input_scrolling_set_api_delegate> efl_input_scrolling_set_ptr = new Efl.Eo.FunctionWrapper<efl_input_scrolling_set_api_delegate>(_Module, "efl_input_scrolling_set");
    private static  void scrolling_set(System.IntPtr obj, System.IntPtr pd,  bool val)
   {
      Eina.Log.Debug("function efl_input_scrolling_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Focus)wrapper).SetScrolling( val);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_input_scrolling_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  val);
      }
   }
   private static efl_input_scrolling_set_delegate efl_input_scrolling_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_input_fake_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_input_fake_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_fake_get_api_delegate> efl_input_fake_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_fake_get_api_delegate>(_Module, "efl_input_fake_get");
    private static bool fake_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_fake_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Focus)wrapper).GetFake();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_input_fake_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_fake_get_delegate efl_input_fake_get_static_delegate;


    private delegate  void efl_input_reset_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_input_reset_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_input_reset_api_delegate> efl_input_reset_ptr = new Efl.Eo.FunctionWrapper<efl_input_reset_api_delegate>(_Module, "efl_input_reset");
    private static  void reset(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_input_reset was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Focus)wrapper).Reset();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_input_reset_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_input_reset_delegate efl_input_reset_static_delegate;
}
} } 