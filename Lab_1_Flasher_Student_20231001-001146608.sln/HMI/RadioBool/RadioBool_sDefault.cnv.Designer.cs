/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 15/08/2022
 * Time: 1:19 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.RadioBool
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
			this.Out = new System.HMI.Symbols.Base.CheckButton();
			this.Label1 = new System.HMI.Symbols.Base.TextBox<string>();
			this.Label0 = new System.HMI.Symbols.Base.TextBox<string>();
			this.drawnTextBox1 = new NxtControl.GuiFramework.DrawnTextBox();
			// 
			// Out
			// 
			this.Out.BeginInit();
			this.Out.AngleIgnore = false;
			this.Out.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 88D, 8D);
			this.Out.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Out.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Out.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Out.Name = "Out";
			this.Out.TagName = "Out";
			this.Out.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Out.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Out.Value = false;
			this.Out.EndInit();
			// 
			// Label1
			// 
			this.Label1.BeginInit();
			this.Label1.AngleIgnore = false;
			this.Label1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 40D, 48D);
			this.Label1.IsOnlyInput = true;
			this.Label1.MaximumTag = null;
			this.Label1.MinimumTag = null;
			this.Label1.Name = "Label1";
			this.Label1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Label1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Label1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Label1.TagName = "Label1";
			this.Label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.Label1.Value = null;
			this.Label1.EndInit();
			// 
			// Label0
			// 
			this.Label0.BeginInit();
			this.Label0.AngleIgnore = false;
			this.Label0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 128D, 48D);
			this.Label0.IsOnlyInput = true;
			this.Label0.MaximumTag = null;
			this.Label0.MinimumTag = null;
			this.Label0.Name = "Label0";
			this.Label0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Label0.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Label0.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Label0.TagName = "Label0";
			this.Label0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.Label0.Value = null;
			this.Label0.EndInit();
			// 
			// drawnTextBox1
			// 
			this.drawnTextBox1.AngleIgnore = true;
			this.drawnTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.drawnTextBox1.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(88D)), ((float)(80D)), ((float)(25D)));
			this.drawnTextBox1.Font = new NxtControl.Drawing.Font("TextBoxFont");
			this.drawnTextBox1.FontScale = true;
			this.drawnTextBox1.Maximum = 100D;
			this.drawnTextBox1.Minimum = 0D;
			this.drawnTextBox1.Name = "drawnTextBox1";
			this.drawnTextBox1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.drawnTextBox1.Text = "Button";
			this.drawnTextBox1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.drawnTextBox1.TextAutoSizeHorizontalOffset = 10;
			this.drawnTextBox1.TextAutoSizeVerticalOffset = 2;
			this.drawnTextBox1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Out,
			this.Label1,
			this.Label0,
			this.drawnTextBox1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.CheckButton Out;
		private System.HMI.Symbols.Base.TextBox<string> Label0;
		private System.HMI.Symbols.Base.TextBox<string> Label1;
		private NxtControl.GuiFramework.DrawnTextBox drawnTextBox1;
		#endregion
	}
}
