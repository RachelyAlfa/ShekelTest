using ENV;
using Firefly.Box;
using Firefly.Box.Data;
using Firefly.Box.Data.Advanced;
using Firefly.Box.UI;
using Northwind.Products;
using Northwind.Products1;
using Northwind.Products1.Views;
using Northwind.Types;
using System;


namespace Northwind.Products1
{
    public class ProductsFillter : UIControllerBase, IProductsFillter
    {
        internal readonly Northwind.Models.Products Products;
        private readonly ProdID pi_ProdID;

        public ProductsFillter()
        {
            Northwind.Models.Products products = new Northwind.Models.Products();
            products.AllowRowLocking = true;
            this.Products = products;
            this.pi_ProdID = new ProdID("pi.Prod ID");
            this.Title = "Show fillter Products";
            this.InitializeDataView();
        }

        private void InitializeDataView()
        {
            this.From = (Entity)this.Products;
            this.OrderBy = (Sort)this.Products.SortByPK_Products;
            this.Columns.Add<Firefly.Box.Number>((TypedColumnBase<Firefly.Box.Number>)this.pi_ProdID);
            this.Columns.Add<Firefly.Box.Number>((TypedColumnBase<Firefly.Box.Number>)this.Products.ProductID);
            this.Columns.Add<Text>((TypedColumnBase<Text>)this.Products.ProductName);
            this.Columns.Add<Firefly.Box.Number>((TypedColumnBase<Firefly.Box.Number>)this.Products.UnitPrice);
            this.Columns.Add<Text>((TypedColumnBase<Text>)this.Products.QuantityPerUnit);
            Where.Add(Products.ProductName.StartsWith("C"));
            this.MarkParameterColumns((ColumnBase)this.pi_ProdID);
        }

        public void Run(NumberParameter ppi_ProdID = null)
        {
            this.BindParameter((NumberColumn)this.pi_ProdID, ppi_ProdID);
            this.Execute();
        }

        protected override void OnLoad()
        {
            this.RowLocking = LockingStrategy.OnRowSaving;
            this.TransactionScope = TransactionScopes.SaveToDatabase;
            this.Activity = Activities.Browse;
            this.SwitchToInsertWhenNoRows = true;
            this.AllowSelect = true;
            this.View = (Func<Form>)(() => (Form)new ProductsFillterView(this));
            //View = () => new Views.ProductsFillterView(this);
        }
    }
}