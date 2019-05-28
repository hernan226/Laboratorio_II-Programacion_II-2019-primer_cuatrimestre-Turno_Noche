using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace Main
{
  public partial class FrmNuevo : Form
  {
    public Persona persona;

    public FrmNuevo()
    {
      InitializeComponent();
    }

    private void FrmNuevo_Load(object sender, EventArgs e)
    {

    }

    private void BtnAceptar_Click(object sender, EventArgs e)
    {
      try
      {
        persona = new Persona(TxtNombre.Text,
          TxtApellido.Text, TxtDni.Text, TxtTarjeta.Text);
        this.DialogResult = DialogResult.OK;
      }
      catch (NoEsNumeroException ex)
      {
        throw new NoSeCreoException("No se pudo crear a la persona", ex);
      }
      catch (NoIngresoNadaException ex)
      {
        throw new NoSeCreoException("No se pudo crear a la persona", ex);
      }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
