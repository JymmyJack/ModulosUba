using DevExpress.Skins;
using DevExpress.XtraTabbedMdi;
using System;
using System.Windows.Forms;

namespace Uba.Presentation.Desktop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            SkinManager.EnableMdiFormSkins();
        }

        private void btnMenuProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new Forms.MantenimientoParametricaForm(Forms.MantenimientoParametricaForm.Parametrica.Producto));
        }

        private void ShowChildForm(Form theForm)
        {
            theForm.MdiParent = this;
            theForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager
            {
                ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders,
                MdiParent = this
            };
        }

        private void btnMenuTipoTran_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new Forms.MantenimientoParametricaForm(Forms.MantenimientoParametricaForm.Parametrica.Transaccion));
        }

        private void btnMenuClaseAgr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowChildForm(new Forms.MantenimientoParametricaForm(Forms.MantenimientoParametricaForm.Parametrica.ClaseAgrupacion));

        }
    }
}
