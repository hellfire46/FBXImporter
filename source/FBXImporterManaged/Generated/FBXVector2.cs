//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FBXVector2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FBXVector2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FBXVector2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FBXVector2() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FBXImporterUnmanagedPINVOKE.delete_FBXVector2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float x {
    set {
      FBXImporterUnmanagedPINVOKE.FBXVector2_x_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXVector2_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      FBXImporterUnmanagedPINVOKE.FBXVector2_y_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXVector2_y_get(swigCPtr);
      return ret;
    } 
  }

  public static FBXVector2 zero {
    set {
      FBXImporterUnmanagedPINVOKE.FBXVector2_zero_set(FBXVector2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXVector2_zero_get();
      FBXVector2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXVector2(cPtr, false);
      return ret;
    } 
  }

  public FBXVector2() : this(FBXImporterUnmanagedPINVOKE.new_FBXVector2__SWIG_0(), true) {
  }

  public FBXVector2(float x, float y) : this(FBXImporterUnmanagedPINVOKE.new_FBXVector2__SWIG_1(x, y), true) {
  }

  public FBXVector2(FBXVector2 other) : this(FBXImporterUnmanagedPINVOKE.new_FBXVector2__SWIG_2(FBXVector2.getCPtr(other)), true) {
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public FBXVector2(SWIGTYPE_p_FbxVector2 other) : this(FBXImporterUnmanagedPINVOKE.new_FBXVector2__SWIG_3(SWIGTYPE_p_FbxVector2.getCPtr(other)), true) {
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public FBXVector2(SWIGTYPE_p_FbxDouble2 other) : this(FBXImporterUnmanagedPINVOKE.new_FBXVector2__SWIG_4(SWIGTYPE_p_FbxDouble2.getCPtr(other)), true) {
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

}