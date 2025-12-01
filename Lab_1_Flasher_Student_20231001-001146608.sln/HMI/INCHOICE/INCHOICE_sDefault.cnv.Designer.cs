/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 09/08/2022
 * Time: 11:14 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.INCHOICE
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
			this.I = new System.HMI.Symbols.Base.DropDown<ushort>();
			this.valueSetter1 = new NxtControl.GuiFramework.ValueSetter();
			this.valueSetter2 = new NxtControl.GuiFramework.ValueSetter();
			// 
			// I
			// 
			this.I.BeginInit();
			this.I.AngleIgnore = false;
			this.I.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.I.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.I.DropDownItems.AddRange(new System.HMI.Symbols.Base.DropDownItem[] {
			new System.HMI.Symbols.Base.DropDownItem("FLASH_ALL", ((long)(0))),
			new System.HMI.Symbols.Base.DropDownItem("COUNT_UP", ((long)(1))),
			new System.HMI.Symbols.Base.DropDownItem("COUNT_DOWN", ((long)(2))),
			new System.HMI.Symbols.Base.DropDownItem("CHASE_UP", ((long)(3))),
			new System.HMI.Symbols.Base.DropDownItem("CHASE_DOWN", ((long)(4)))});
			this.I.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.I.Name = "I";
			this.I.TagName = "I";
			this.I.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.I.Value = ((ushort)(0));
			this.I.EndInit();
			// 
			// valueSetter1
			// 
			this.valueSetter1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(144D)), ((float)(50D)), ((float)(50D)));
			this.valueSetter1.Name = "valueSetter1";
			this.valueSetter1.Text = "Execution Alarm";
			// 
			// valueSetter2
			// 
			this.valueSetter2.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(96D)), ((float)(50D)), ((float)(50D)));
			this.valueSetter2.Name = "valueSetter2";
			this.valueSetter2.Text = "Execution Alarm";
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.I,
			this.valueSetter1,
			this.valueSetter2});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.DropDown<ushort> I;
		private NxtControl.GuiFramework.ValueSetter valueSetter1;
		private NxtControl.GuiFramework.ValueSetter valueSetter2;
		#endregion
	}
}
