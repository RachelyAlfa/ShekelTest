using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Firefly.Box;
using Firefly.Box.UI.Advanced;
using ENV;
using ENV.Data;
using Northwind.Shared.Theme.Controls;
using Northwind.Shared.Theme.Colors;
using Northwind.Views.Controls;
using Firefly.Box.Data.Advanced;
using Firefly.Box.UI;
using Firefly.Box.UI.Advanced;
using Northwind.Shared.Theme.Colors;
using Northwind.Shared.Theme.Controls;
using Northwind.Views.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Northwind.Products1.Views
{
    partial class ProductsFillterView : CompatibleForm
    {
        ProductsFillter _controller;
        private IContainer components;
        private DefaultHelpWindow clrDefaultHelpWindow;
        private V9CompatibleDefaultTable grd;
        private CompatibleGridColumn gclID;
        private CompatibleGridColumn gclName;
        private CompatibleGridColumn gclUnitPrice;
        private CompatibleTextBox txtProducts_ProductID;
        private CompatibleTextBox txtProducts_ProductName;
        private CompatibleTextBox txtProducts_UnitPrice;
        private OK btn;
        private Close btn_;
        public ProductsFillterView(ProductsFillter controller)
        {
            this._controller = controller;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            this.clrDefaultHelpWindow = new DefaultHelpWindow();
            this.grd = new V9CompatibleDefaultTable();
            this.gclID = new CompatibleGridColumn();
            this.txtProducts_ProductID = new CompatibleTextBox();
            this.gclName = new CompatibleGridColumn();
            this.txtProducts_ProductName = new CompatibleTextBox();
            this.gclUnitPrice = new CompatibleGridColumn();
            this.txtProducts_UnitPrice = new CompatibleTextBox();
            this.btn = new OK();
            this.btn_ = new Close();
            ((Firefly.Box.UI.Form)this).TabOrderMode = TabOrderMode.ManualIgnoringContainerHeirarchy;
            ((Control)this.grd).SuspendLayout();
            ((Control)this.gclID).SuspendLayout();
            ((Control)this.gclName).SuspendLayout();
            ((Control)this.gclUnitPrice).SuspendLayout();
            ((Control)this).SuspendLayout();
            ((ControlBase)this.grd).AdvancedAnchor = new AdvancedAnchor(0, 100, 0, 100);
            ((Firefly.Box.UI.Grid)this.grd).AllowMultiSelect = false;
            ((Control)this.grd).Controls.Add((Control)this.gclID);
            ((Control)this.grd).Controls.Add((Control)this.gclName);
            ((Control)this.grd).Controls.Add((Control)this.gclUnitPrice);
            ((Control)this.grd).Location = new Point(10, 13);
            ((Control)this.grd).Name = "grd";
            ((Firefly.Box.UI.Grid)this.grd).RowHeight = 21;
            ((Control)this.grd).Size = new Size(320, 296);
            ((Firefly.Box.UI.GridColumn)this.gclID).AllowSort = true;
            ((Control)this.gclID).Controls.Add((Control)this.txtProducts_ProductID);
            ((Control)this.gclID).Name = "gclID";
            ((Control)this.gclID).Text = "ID";
            ((Firefly.Box.UI.GridColumn)this.gclID).Width = 60;
            ((ControlBase)this.txtProducts_ProductID).AdvancedAnchor = new AdvancedAnchor(0, 100, 0, 0);
            ((TextControlBase)this.txtProducts_ProductID).Alignment = ContentAlignment.MiddleRight;
            ((Control)this.txtProducts_ProductID).Location = new Point(3, 1);
            ((Control)this.txtProducts_ProductID).Name = "txtProducts_ProductID";
            ((Control)this.txtProducts_ProductID).Size = new Size(55, 16);
            ((ControlBase)this.txtProducts_ProductID).Style = ControlStyle.Flat;
            ((ControlBase)this.txtProducts_ProductID).TabIndex = 1;
            ((ControlBase)this.txtProducts_ProductID).Tag = (object)"CustomerID";
            ((Firefly.Box.UI.TextBox)this.txtProducts_ProductID).Data = (ControlData)(ColumnBase)this._controller.Products.ProductID;
            ((Firefly.Box.UI.GridColumn)this.gclName).AllowSort = true;
            ((Control)this.gclName).Controls.Add((Control)this.txtProducts_ProductName);
            ((Control)this.gclName).Name = "gclName";
            ((Control)this.gclName).Text = "Name";
            ((Firefly.Box.UI.GridColumn)this.gclName).Width = 170;
            ((ControlBase)this.txtProducts_ProductName).AdvancedAnchor = new AdvancedAnchor(0, 100, 0, 0);
            ((Control)this.txtProducts_ProductName).Location = new Point(2, 1);
            ((Control)this.txtProducts_ProductName).Name = "txtProducts_ProductName";
            ((Control)this.txtProducts_ProductName).Size = new Size(160, 16);
            ((ControlBase)this.txtProducts_ProductName).Style = ControlStyle.Flat;
            ((ControlBase)this.txtProducts_ProductName).TabIndex = 2;
            ((ControlBase)this.txtProducts_ProductName).Tag = (object)"CompanyName";
            ((Firefly.Box.UI.TextBox)this.txtProducts_ProductName).Data = (ControlData)(ColumnBase)this._controller.Products.ProductName;
            ((Control)this.gclUnitPrice).Controls.Add((Control)this.txtProducts_UnitPrice);
            ((Control)this.gclUnitPrice).Name = "gclUnitPrice";
            ((Control)this.gclUnitPrice).Text = "Unit Price";
            ((Firefly.Box.UI.GridColumn)this.gclUnitPrice).Width = 67;
            ((ControlBase)this.txtProducts_UnitPrice).AdvancedAnchor = new AdvancedAnchor(0, 100, 0, 0);
            ((TextControlBase)this.txtProducts_UnitPrice).Alignment = ContentAlignment.MiddleRight;
            ((Firefly.Box.UI.TextBox)this.txtProducts_UnitPrice).Format = "10.2C+$;";
            ((Control)this.txtProducts_UnitPrice).Location = new Point(2, 1);
            ((Control)this.txtProducts_UnitPrice).Name = "txtProducts_UnitPrice";
            ((Control)this.txtProducts_UnitPrice).Size = new Size(60, 16);
            ((ControlBase)this.txtProducts_UnitPrice).Style = ControlStyle.Flat;
            ((ControlBase)this.txtProducts_UnitPrice).TabIndex = 3;
            ((ControlBase)this.txtProducts_UnitPrice).Tag = (object)"Address";
            ((Firefly.Box.UI.TextBox)this.txtProducts_UnitPrice).Data = (ControlData)(ColumnBase)this._controller.Products.UnitPrice;
            ((Control)this.btn).Location = new Point(195, 325);
            ((Control)this.btn).Name = "btn";
            ((Firefly.Box.UI.Button)this.btn).RaiseClickBeforeFocusChange = true;
            ((Control)this.btn).Size = new Size(60, 23);
            ((ControlBase)this.btn).TabIndex = 5;
            ((Control)this.btn_).Location = new Point(270, 325);
            ((Control)this.btn_).Name = "btn_";
            ((Firefly.Box.UI.Button)this.btn_).RaiseClickBeforeFocusChange = true;
            ((Control)this.btn_).Size = new Size(60, 23);
            ((ControlBase)this.btn_).TabIndex = 4;
            ((ContainerControl)this).AutoScaleDimensions = new SizeF(5f, 13f);
            ((ENV.UI.Form)this).AutoScaleMode = AutoScaleMode.Font;
            ((Firefly.Box.UI.Form)this).ClientSize = new Size(339, 361);
            ((Firefly.Box.UI.Form)this).ColorScheme = (ColorScheme)this.clrDefaultHelpWindow;
            ((Control)this).Controls.Add((Control)this.btn_);
            ((Control)this).Controls.Add((Control)this.btn);
            ((Control)this).Controls.Add((Control)this.grd);
            ((ENV.UI.Form)this).HorizontalExpressionFactor = 4.0;
            ((ENV.UI.Form)this).HorizontalScale = 5.0;
            ((System.Windows.Forms.Form)this).Location = new Point(133, 41);
            ((Control)this).Name = nameof(ProductsFillterView);
            ((Firefly.Box.UI.Form)this).StartPosition = WindowStartPosition.CenterMDI;
            ((Firefly.Box.UI.Form)this).Text = "Show Products";
            ((ENV.UI.Form)this).VerticalExpressionFactor = 8.0;
            ((ENV.UI.Form)this).VerticalScale = 13.0;
            ((Control)this.grd).ResumeLayout(false);
            ((Control)this.gclID).ResumeLayout(false);
            ((Control)this.gclName).ResumeLayout(false);
            ((Control)this.gclUnitPrice).ResumeLayout(false);
            ((Control)this).ResumeLayout(false);
        }


    }
}