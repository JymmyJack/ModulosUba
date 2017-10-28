using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uba.Application.Commands.CodigoAgrupacion;
using Uba.Application.Commands.Parametricas;
using Uba.Application.Configuration;
using Uba.Infraestructure.Commands;
using Uba.Infraestructure.Dto;
using Uba.Presentation.Desktop.Core;

namespace Uba.Presentation.Desktop.Forms
{
    public partial class MantenimientoParametricasForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MantenimientoParametricasForm()
        {
            InitializeComponent();
        }

        private void MantenimientoParametricasForm_Load(object sender, EventArgs e)
        {
            //var list = ServiceActivator.ParametricaEntity.GetItems(1);
            //var dto = new ParametricaDto
            //{
            //    Id = 1,
            //    TipoParametrica = 1,
            //    Descripcion = "Prueba Jymmy"
            //};

            //ServiceActivator.CommandBus.Send(new CreateParametricaCommand(6, 1, "Prueba Jymmy"));
            //ServiceActivator.CommandBus.Send(new EditParametricaCommand(6, 1, "Prueba J. Mod"));
            //ServiceActivator.CommandBus.Send(new DeleteParametricaCommand(6, 1));
            //ServiceActivator.CommandBus.Send(new CreateCodigoAgrupacionCommand(1, 1, "", ""));
            //MessageBox.Show(list.Count.ToString());
        }
    }
}
