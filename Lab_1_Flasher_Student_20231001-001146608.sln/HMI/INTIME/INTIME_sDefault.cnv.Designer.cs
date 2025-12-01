/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 09/08/2022
 * Time: 10:54 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.INTIME
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OUT = new System.HMI.Symbols.Base.RoundKnob<int>();
			// 
			// OUT
			// 
			this.OUT.BeginInit();
			this.OUT.AngleIgnore = false;
			this.OUT.Brush = new NxtControl.Drawing.Brush("RoundKnobBrush");
			this.OUT.CornerRadius = 5;
			this.OUT.CurrentValue = 0;
			this.OUT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.OUT.InnerCircleColor = new NxtControl.Drawing.Color("RoundKnobInnerCircleColor");
			this.OUT.KnobColor = new NxtControl.Drawing.Color("RoundKnobKnobColor");
			this.OUT.LabelFormatString = "0.00";
			this.OUT.Maximum = 1000;
			this.OUT.MaximumTag = new NxtControl.GuiFramework.AuxHMIAccessor("MAXMS", this.OUT);
			this.OUT.Minimum = 200;
			this.OUT.MinimumTag = new NxtControl.GuiFramework.AuxHMIAccessor("MINMS", this.OUT);
			this.OUT.Name = "OUT";
			this.OUT.NeedleColor = new NxtControl.Drawing.Color("RoundKnobNeedleColor");
			this.OUT.ScaleColor = new NxtControl.Drawing.Color("RoundKnobScaleColor");
			this.OUT.ScaleDivisions = 10;
			this.OUT.ScaleSubDivisions = 0;
			this.OUT.SnapDivisions = 0;
			this.OUT.TagName = "OUT";
			this.OUT.Value = 0;
			this.OUT.ValueChange = false;
			this.OUT.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.OUT});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.RoundKnob<int> OUT;
		#endregion
	}
}
