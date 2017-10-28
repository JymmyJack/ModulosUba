using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using Uba.Application.Commands.Parametricas;
using Uba.Application.Configuration;
using Uba.Infraestructure.Commands;
using Uba.Infraestructure.Commands.Parametricas;
using Uba.Infraestructure.Dto;
using Uba.Presentation.Desktop.Resources;

namespace Uba.Presentation.Desktop.Forms
{
    public partial class MantenimientoParametricaForm : DevExpress.XtraEditors.XtraForm
    {
        public Parametrica TipoParametrica { get; set; }
        public MantenimientoParametricaForm(Parametrica tipo)
        {
            InitializeComponent();
            TipoParametrica = tipo;
            switch (tipo)
            {
                case Parametrica.Producto:
                    lblTitulo.Text = string.Format(lblTitulo.Text, AppResource.TituloProducto);

                    break;
                case Parametrica.Transaccion:
                    lblTitulo.Text = string.Format(lblTitulo.Text, AppResource.TituloTransaccion);
                    break;
                case Parametrica.ClaseAgrupacion:
                    lblTitulo.Text = string.Format(lblTitulo.Text, AppResource.TituloClaseAgru);
                    break;
            }
            Text = lblTitulo.Text;
        }

        private void MantProductoForm_Load(object sender, EventArgs e)
        {
            Populatedata();
            var mainform = this.MdiParent as MainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new MantenimientoParametricaDetailForm();
            dialog.Text = string.Format(dialog.Text, AppResource.TituloCrear);
            var dialogResult = dialog.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                ServiceActivator.CommandBus.Send(new CreateParametricaCommand(dialog.Dto.Id, (int)TipoParametrica, dialog.Dto.Descripcion));
                Populatedata();
            }
        }

        private void Populatedata()
        {
            var data = ServiceActivator.ParametricaEntity.GetItems((int)TipoParametrica);
            grdProducto.DataSource = data;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var gridView = grdProducto.MainView as GridView;
            var data = gridView.GetFocusedRow() as ParametricaDto;

            var dialog = new MantenimientoParametricaDetailForm(data, true);
            dialog.Text = string.Format(dialog.Text, AppResource.TituloEditar);

            var dialogResult = dialog.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                ServiceActivator.CommandBus.Send(new EditParametricaCommand(dialog.Dto.Id, (int)TipoParametrica, dialog.Dto.Descripcion));
                Populatedata();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var gridView = grdProducto.MainView as GridView;
            var data = gridView.GetFocusedRow() as ParametricaDto;

            var dialog = new MantenimientoParametricaDetailForm(data, true);
            dialog.Text = string.Format(dialog.Text, AppResource.TituloEliminar);

            var dialogResult = dialog.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                ServiceActivator.CommandBus.Send(new DeleteParametricaCommand(dialog.Dto.Id, (int)TipoParametrica));
                Populatedata();
            }
        }

        public enum Parametrica
        {
            Producto = 1,
            Transaccion = 2,
            ClaseAgrupacion = 3
        }
    }
}
