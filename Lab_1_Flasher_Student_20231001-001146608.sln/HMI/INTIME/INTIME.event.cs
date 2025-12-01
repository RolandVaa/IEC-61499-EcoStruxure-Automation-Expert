/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 09/08/2022
 * Time: 10:54 am
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #INTIME_HMI;

namespace HMI.Main.Symbols.INTIME
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MINMS(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? MINMS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }

    public bool Get_MAXMS(ref System.Int32 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Int32) var;
      return ret;
    }

    public System.Int32? MAXMS
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Int32) var;
    }  }


  }

}

namespace HMI.Main.Symbols.INTIME
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Int32? OUT_field = null;
    public System.Int32? OUT
    {
       get { return OUT_field; }
       set { OUT_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.INTIME
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.INTIME.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.INTIME.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Int32 OUT)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {OUT});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.INTIME.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.OUT.HasValue) _values_[0] = ea.OUT.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Int32 OUT, bool ignore_OUT)
    {
      object[] _values_ = new object[1];
      if (!ignore_OUT) _values_[0] = OUT;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #INTIME_HMI;

#endregion Definitions;
