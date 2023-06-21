
namespace SimiSoft
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            bManager = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            mnArchivo = new DevExpress.XtraBars.BarSubItem();
            btnSalir = new DevExpress.XtraBars.BarButtonItem();
            mnCatalogo = new DevExpress.XtraBars.BarSubItem();
            btnAsignarPermisosRol = new DevExpress.XtraBars.BarButtonItem();
            btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            btnClientes = new DevExpress.XtraBars.BarButtonItem();
            btnCotizacionesUV = new DevExpress.XtraBars.BarButtonItem();
            btnProductos = new DevExpress.XtraBars.BarButtonItem();
            btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            btnRoles = new DevExpress.XtraBars.BarButtonItem();
            btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            btnVentas = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)bManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabMdiManager).BeginInit();
            SuspendLayout();
            // 
            // bManager
            // 
            bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            bManager.DockControls.Add(barDockControlTop);
            bManager.DockControls.Add(barDockControlBottom);
            bManager.DockControls.Add(barDockControlLeft);
            bManager.DockControls.Add(barDockControlRight);
            bManager.Form = this;
            bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { mnArchivo, btnSalir, mnCatalogo, btnClientes, btnProveedores, btnProductos, btnCategorias, barButtonItem2, btnRoles, btnAsignarPermisosRol, btnUsuarios, btnVentas, btnCotizacionesUV });
            bManager.MainMenu = bar2;
            bManager.MaxItemId = 21;
            bManager.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Menú principal";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(mnArchivo), new DevExpress.XtraBars.LinkPersistInfo(mnCatalogo) });
            bar2.OptionsBar.DrawBorder = false;
            bar2.OptionsBar.DrawDragBorder = false;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Menú principal";
            // 
            // mnArchivo
            // 
            mnArchivo.Caption = "Archivo";
            mnArchivo.Id = 0;
            mnArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnSalir) });
            mnArchivo.Name = "mnArchivo";
            // 
            // btnSalir
            // 
            btnSalir.Caption = "Salir";
            btnSalir.Id = 1;
            btnSalir.Name = "btnSalir";
            btnSalir.ItemClick += btnSalir_ItemClick;
            // 
            // mnCatalogo
            // 
            mnCatalogo.Caption = "Catalogo";
            mnCatalogo.Id = 2;
            mnCatalogo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, btnAsignarPermisosRol, false), new DevExpress.XtraBars.LinkPersistInfo(btnCategorias), new DevExpress.XtraBars.LinkPersistInfo(btnClientes), new DevExpress.XtraBars.LinkPersistInfo(btnCotizacionesUV), new DevExpress.XtraBars.LinkPersistInfo(btnProductos), new DevExpress.XtraBars.LinkPersistInfo(btnProveedores), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, btnRoles, false), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, btnUsuarios, false), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, btnVentas, false) });
            mnCatalogo.Name = "mnCatalogo";
            // 
            // btnAsignarPermisosRol
            // 
            btnAsignarPermisosRol.Caption = "Asignar Permisos Rol";
            btnAsignarPermisosRol.Id = 9;
            btnAsignarPermisosRol.Name = "btnAsignarPermisosRol";
            btnAsignarPermisosRol.ItemClick += btnAsignarPermisosRol_ItemClick;
            // 
            // btnCategorias
            // 
            btnCategorias.Caption = "Categorias";
            btnCategorias.Id = 6;
            btnCategorias.Name = "btnCategorias";
            btnCategorias.ItemClick += btnCategorias_ItemClick;
            // 
            // btnClientes
            // 
            btnClientes.Caption = "Clientes";
            btnClientes.Id = 3;
            btnClientes.Name = "btnClientes";
            btnClientes.ItemClick += btnClientes_ItemClick;
            // 
            // btnCotizacionesUV
            // 
            btnCotizacionesUV.Caption = "CotizacionesUV";
            btnCotizacionesUV.Id = 13;
            btnCotizacionesUV.Name = "btnCotizacionesUV";
            btnCotizacionesUV.ItemClick += btnCotizacionesUV_ItemClick;
            // 
            // btnProductos
            // 
            btnProductos.Caption = "Productos";
            btnProductos.Id = 5;
            btnProductos.Name = "btnProductos";
            btnProductos.ItemClick += btnProductos_ItemClick;
            // 
            // btnProveedores
            // 
            btnProveedores.Caption = "Proveedores";
            btnProveedores.Id = 4;
            btnProveedores.Name = "btnProveedores";
            btnProveedores.ItemClick += btnProveedores_ItemClick;
            // 
            // btnRoles
            // 
            btnRoles.Caption = "Rol";
            btnRoles.Id = 8;
            btnRoles.Name = "btnRoles";
            btnRoles.ItemClick += btnRoles_ItemClick;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Caption = "Usuarios";
            btnUsuarios.Id = 10;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ItemClick += btnUsuarios_ItemClick;
            // 
            // btnVentas
            // 
            btnVentas.Caption = "Ventas";
            btnVentas.Id = 11;
            btnVentas.Name = "btnVentas";
            btnVentas.ItemClick += btnVentas_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Barra de estado";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = bManager;
            barDockControlTop.Size = new System.Drawing.Size(653, 25);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 362);
            barDockControlBottom.Manager = bManager;
            barDockControlBottom.Size = new System.Drawing.Size(653, 21);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            barDockControlLeft.Manager = bManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(653, 25);
            barDockControlRight.Manager = bManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Productos";
            barButtonItem2.Id = 7;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // tabMdiManager
            // 
            tabMdiManager.MdiParent = this;
            // 
            // bar1
            // 
            bar1.BarName = "Custom 4";
            bar1.DockCol = 0;
            bar1.DockRow = 1;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.Text = "Custom 4";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(653, 383);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "TecniPrint";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabMdiManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mnArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem mnCatalogo;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnRoles;
        private DevExpress.XtraBars.BarButtonItem btnAsignarPermisosRol;
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnVentas;
        private DevExpress.XtraBars.BarButtonItem btnCotizacionesUV;
        private DevExpress.XtraBars.Bar bar1;
    }
}

