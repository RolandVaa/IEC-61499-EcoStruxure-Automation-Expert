/* StartCanvas.cnv.Designer.cs */
/* =====================================================================$
 * Copyright (c) 2007-2015 nxtControl GesmbH.  All rights reserved.
 * The contents of this file is subject to confidentiality.
 *
 * =====================================================================$
 */

/*
 * Created by HMI.Main.
 * User: kovaivo
 * Date: 18.09.2008
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
  /// <summary>
  /// Summary description for StartCanvas_1.
  /// </summary>
  partial class StartCanvas_1
  {
    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartCanvas_1));         
      this.canvasTopologySeparator1 = new NxtControl.GuiFramework.CanvasTopologySeparator();      
      this.canvasTopologySeparator2 = new NxtControl.GuiFramework.CanvasTopologySeparator();      
      this.workArea = new NxtControl.GuiFramework.WorkAreaControl();
      
      this.header1 = new NxtControl.GuiFramework.Rectangle();
this.logo = new NxtControl.GuiFramework.Rectangle();
this.login1 = new NxtControl.GuiFramework.Login();
this.language1 = new NxtControl.GuiFramework.LanguageSwitcher();
this.currentUser1 = new NxtControl.GuiFramework.CurrentUser();
this.runtimeConnection1 = new NxtControl.GuiFramework.RuntimeConnection();
this.newVersionDeployment1 = new NxtControl.GuiFramework.HMIDeployment();
this.canvasTopologyNavigation = new NxtControl.GuiFramework.TopologyCurrentCanvas();
      
      // 
      // canvasTopologySeparator1
      //
      this.canvasTopologySeparator1.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.canvasTopologySeparator1.Bounds = new NxtControl.Drawing.RectF(((float)(119)), ((float)(0)), ((float)(2)), ((float)(80)));
      this.canvasTopologySeparator1.Name = "canvasTopologySeparator1";
      this.canvasTopologySeparator1.LookAndFeel = "Theme";
      this.canvasTopologySeparator1.Visible = true;
      // 
      // canvasTopologySeparator2
      //
      this.canvasTopologySeparator2.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.canvasTopologySeparator2.Bounds = new NxtControl.Drawing.RectF(((float)(1120)), ((float)(0)), ((float)(2)), ((float)(80)));
      this.canvasTopologySeparator2.Name = "canvasTopologySeparator2";
      this.canvasTopologySeparator2.LookAndFeel = "Theme";
      this.canvasTopologySeparator2.Visible = true;      
      // 
      // workArea
      // 
      this.workArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                  | System.Windows.Forms.AnchorStyles.Left) 
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.workArea.AutoScroll = true;
      this.workArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.workArea.Location = new System.Drawing.Point(0, 80);
      this.workArea.Name = "workArea";
      this.workArea.RuntimeMode = true;
      this.workArea.Size = new System.Drawing.Size(1280, 900);
      this.workArea.TabIndex = 0;
      this.workArea.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      
      // 
      // header1
      // 
      this.header1.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
      this.header1.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(1280)), ((float)(80)));
      this.header1.Name = "header1";
      this.header1.Brush = NxtControl.Drawing.Brush.FromName("CanvasTopologyHeaderBrush");
      this.header1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
      // newVersionDeployment1
      // 
      this.logo.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.logo.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(119)), ((float)(80)));
      this.logo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
      this.logo.Font = new NxtControl.Drawing.Font("HeaderFont");
      this.logo.ImageBytes = resources.GetString("logo.ImageBytes");
      this.logo.Name = "logo";
      this.logo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
      this.logo.TextColor = new NxtControl.Drawing.Color("Black");
			// 
      // login1
      // 
      this.login1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.login1.Bounds = new NxtControl.Drawing.RectF(((float)(1200)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.login1.Text = "";
      this.login1.Radius = 0;
      this.login1.LookAndFeel = "Theme";
      this.login1.Name = "login1";
			// 
      // language1
      // 
      this.language1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.language1.Bounds = new NxtControl.Drawing.RectF(((float)(1240)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.language1.LookAndFeel = "Theme";
      this.language1.Name = "language1";
			// 
      // currentUser1
      // 
      this.currentUser1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.currentUser1.AngleIgnore = true;
      this.currentUser1.Bounds = new NxtControl.Drawing.RectF(((float)(1180)), ((float)(40)), ((float)(100)), ((float)(40)));
      this.currentUser1.Brush = new NxtControl.Drawing.Brush();
      this.currentUser1.Font = new NxtControl.Drawing.Font("HeaderFont");
      this.currentUser1.LookAndFeel = "Theme";
      this.currentUser1.Name = "currentUser1";
      this.currentUser1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
      this.currentUser1.Text = "currentUser1";
      this.currentUser1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
      this.currentUser1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			// 
      // runtimeConnection1
      // 
      this.runtimeConnection1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.runtimeConnection1.Bounds = new NxtControl.Drawing.RectF(((float)(1160)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.runtimeConnection1.Text = "";
      this.runtimeConnection1.Radius = 0;     
      this.runtimeConnection1.Name = "runtimeConnection1";
      this.runtimeConnection1.Brush = new NxtControl.Drawing.Brush("CanvasTopologyButtonBrush");
      this.runtimeConnection1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
      // newVersionDeployment1
      // 
      this.newVersionDeployment1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.newVersionDeployment1.Bounds = new NxtControl.Drawing.RectF(((float)(1120)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.newVersionDeployment1.Text = "";
      this.newVersionDeployment1.Radius = 0;
      this.newVersionDeployment1.LookAndFeel = "Theme";
      this.newVersionDeployment1.Name = "newVersionDeployment1";
      this.newVersionDeployment1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    // 
      // canvasTopologyNavigation
      // 
      this.canvasTopologyNavigation.BeginInit();
      this.canvasTopologyNavigation.Bounds = new NxtControl.Drawing.RectF(((float)(119)), ((float)(0)), ((float)(119)), ((float)(40)));
      this.canvasTopologyNavigation.Name = "canvasTopologyBreadcrumb";
      this.canvasTopologyNavigation.LookAndFeel = "Theme";
      this.canvasTopologyNavigation.WorkArea = workArea;
      this.canvasTopologyNavigation.EndInit();

      // 
      // StartCanvas_1
      // 
      this.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(1280)), ((float)(980)));
      this.Name = "StartCanvas_1";
      this.ResizeBehavior = NxtControl.GuiFramework.ResizeBehavior.None;
      this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
                  this.header1,
                 
                        this.logo,
      login1,
      language1,
      currentUser1,
      runtimeConnection1,
      newVersionDeployment1,
      this.canvasTopologyNavigation,

                  this.canvasTopologySeparator1,
				  this.canvasTopologySeparator2,
				  this.workArea});
      this.Size = new System.Drawing.Size(1280, 980);
    }
    
    private NxtControl.GuiFramework.Rectangle header1;
private NxtControl.GuiFramework.Rectangle logo;
private NxtControl.GuiFramework.Login login1;
private NxtControl.GuiFramework.LanguageSwitcher language1;
private NxtControl.GuiFramework.CurrentUser currentUser1;
private NxtControl.GuiFramework.RuntimeConnection runtimeConnection1;
private NxtControl.GuiFramework.HMIDeployment newVersionDeployment1;
 private NxtControl.GuiFramework.TopologyCurrentCanvas canvasTopologyNavigation;

    private NxtControl.GuiFramework.WorkAreaControl workArea;    
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator1;
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator2; 
    #endregion
  }
}
