/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 09/08/2022
 * Time: 11:14 am
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #INCHOICE_HMI;

namespace HMI.Main.Symbols.INCHOICE
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.UInt16? I_field = null;
    public System.UInt16? I
    {
       get { return I_field; }
       set { I_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.INCHOICE
{
  partial class sDefault
  {
    public bool FireEvent_CNF(System.UInt16 I)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {I});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.INCHOICE.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.I.HasValue) _values_[0] = ea.I.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.UInt16 I, bool ignore_I)
    {
      object[] _values_ = new object[1];
      if (!ignore_I) _values_[0] = I;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #INCHOICE_HMI;

#endregion Definitions;
