using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador
{
    public class PresentadorOperaciones
    {
        private readonly IVistaOperaciones _vista;
        private ModeloOperaciones _model;
        public PresentadorOperaciones(IVistaOperaciones vista)
        {
            _vista = vista;
            _model = new ModeloOperaciones();
        }

        public void IniciarVista()
        {
            _vista.n1 = 0;
            _vista.n2 = 0;
            _vista.resultado = 0;

        }

        public void ActualizarVista()
        {
          _vista.resultado= _model.Sumar(_vista.n1, _vista.n2);
        }
    }
}
