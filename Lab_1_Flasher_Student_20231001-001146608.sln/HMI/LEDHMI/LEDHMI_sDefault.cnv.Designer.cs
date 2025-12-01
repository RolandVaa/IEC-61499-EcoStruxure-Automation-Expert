/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 09/08/2022
 * Time: 10:47 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.LEDHMI
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			this.LED3 = new System.HMI.Symbols.Base.Led<bool>();
			this.LED2 = new System.HMI.Symbols.Base.Led<bool>();
			this.LED1 = new System.HMI.Symbols.Base.Led<bool>();
			this.LED0 = new System.HMI.Symbols.Base.Led<bool>();
			// 
			// LED3
			// 
			this.LED3.BeginInit();
			this.LED3.AngleIgnore = false;
			this.LED3.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LED3.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.0833333333333335D, 0D, 0D, 2.0833333333333335D, 28.5D, 20.5D);
			this.LED3.FrameSize = 33F;
			this.LED3.IsOnlyInput = true;
			this.LED3.Name = "LED3";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("LedTrueColor"));
			this.LED3.Ranges.Clear();
			this.LED3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.LED3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LED3.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.LED3.TagName = "LED3";
			this.LED3.EndInit();
			// 
			// LED2
			// 
			this.LED2.BeginInit();
			this.LED2.AngleIgnore = false;
			this.LED2.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LED2.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.0833333333333335D, 0D, 0D, 2.0833333333333335D, 76.5D, 20.5D);
			this.LED2.FrameSize = 33F;
			this.LED2.IsOnlyInput = true;
			this.LED2.Name = "LED2";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("LedTrueColor"));
			this.LED2.Ranges.Clear();
			this.LED2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.LED2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LED2.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.LED2.TagName = "LED2";
			this.LED2.EndInit();
			// 
			// LED1
			// 
			this.LED1.BeginInit();
			this.LED1.AngleIgnore = false;
			this.LED1.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LED1.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.0833333333333335D, 0D, 0D, 2.0833333333333335D, 124.5D, 20.5D);
			this.LED1.FrameSize = 33F;
			this.LED1.IsOnlyInput = true;
			this.LED1.Name = "LED1";
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary9.Add("Color", new NxtControl.Drawing.Color("LedTrueColor"));
			this.LED1.Ranges.Clear();
			this.LED1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.LED1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LED1.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.LED1.TagName = "LED1";
			this.LED1.EndInit();
			// 
			// LED0
			// 
			this.LED0.BeginInit();
			this.LED0.AngleIgnore = false;
			this.LED0.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.LED0.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.0833333333333335D, 0D, 0D, 2.0833333333333335D, 172.5D, 20.5D);
			this.LED0.FrameSize = 33F;
			this.LED0.IsOnlyInput = true;
			this.LED0.Name = "LED0";
			propertyDictionary11.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary12.Add("Color", new NxtControl.Drawing.Color("LedTrueColor"));
			this.LED0.Ranges.Clear();
			this.LED0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.LED0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.LED0.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.LED0.TagName = "LED0";
			this.LED0.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.LED3,
			this.LED2,
			this.LED1,
			this.LED0});
			this.SymbolSize = new System.Drawing.Size(696, 472);

		}
		private System.HMI.Symbols.Base.Led<bool> LED3;
		private System.HMI.Symbols.Base.Led<bool> LED2;
		private System.HMI.Symbols.Base.Led<bool> LED1;
		private System.HMI.Symbols.Base.Led<bool> LED0;
		#endregion
	}
}
