namespace Sistema_de_control_de_inventario
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventarioDataSet = new Sistema_de_control_de_inventario.InventarioDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Sistema_de_control_de_inventario.InventarioDataSetTableAdapters.InventarioTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Sistema_de_control_de_inventario.InventarioDataSetTableAdapters.ProductosTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource9.Name = "DataSetLab1";
            reportDataSource9.Value = this.inventarioBindingSource;
            reportDataSource10.Name = "DataSetLab12";
            reportDataSource10.Value = this.productosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_control_de_inventario.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "InventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.inventarioDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporte";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InventarioDataSet inventarioDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private InventarioDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private InventarioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}