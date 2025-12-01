/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 28/10/2022
 * Time: 2:52 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FREQ = new HMI.Main.Symbols.INTIME.sDefault();
			this.LED_PANEL = new HMI.Main.Symbols.LEDHMI.sDefault();
			this.MODE = new HMI.Main.Symbols.INCHOICE.sDefault();
			this.RadioBool = new HMI.Main.Symbols.RadioBool.sDefault();
			// 
			// FREQ
			// 
			this.FREQ.BeginInit();
			this.FREQ.AngleIgnore = false;
			this.FREQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 312D, 56D);
			this.FREQ.Name = "FREQ";
			this.FREQ.SecurityToken = ((uint)(4294967295u));
			this.FREQ.TagName = "780F66FCC9A369C5";
			this.FREQ.EndInit();
			// 
			// LED_PANEL
			// 
			this.LED_PANEL.BeginInit();
			this.LED_PANEL.AngleIgnore = false;
			this.LED_PANEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 328D, 232D);
			this.LED_PANEL.Name = "LED_PANEL";
			this.LED_PANEL.SecurityToken = ((uint)(4294967295u));
			this.LED_PANEL.TagName = "76FF8B51D488C834";
			this.LED_PANEL.EndInit();
			// 
			// MODE
			// 
			this.MODE.BeginInit();
			this.MODE.AngleIgnore = false;
			this.MODE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 576D, 144D);
			this.MODE.Name = "MODE";
			this.MODE.SecurityToken = ((uint)(4294967295u));
			this.MODE.TagName = "1BC91B6EDD198A0D";
			this.MODE.EndInit();
			// 
			// RadioBool
			// 
			this.RadioBool.BeginInit();
			this.RadioBool.AngleIgnore = false;
			this.RadioBool.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 120D);
			this.RadioBool.Name = "RadioBool";
			this.RadioBool.SecurityToken = ((uint)(4294967295u));
			this.RadioBool.TagName = "222030AB9D50EDC7";
			this.RadioBool.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1280D)), ((float)(900D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FREQ,
			this.LED_PANEL,
			this.MODE,
			this.RadioBool});
			this.Size = new System.Drawing.Size(1280, 900);

		}
		private HMI.Main.Symbols.INTIME.sDefault FREQ;
		private HMI.Main.Symbols.LEDHMI.sDefault LED_PANEL;
		private HMI.Main.Symbols.INCHOICE.sDefault MODE;
		private HMI.Main.Symbols.RadioBool.sDefault RadioBool;
		#endregion
	}
}
