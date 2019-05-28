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
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Main
{
  public partial class Lista : Form
  {
    const string path = //  el @ es para que el \ no de error
      @"C:\Users\alumno\Desktop\Clase19\Archivos\Personas.xml";
    public List<Persona> personas;

    public Lista()
    {
      InitializeComponent();

    }

    private void Lista_Load(object sender, EventArgs e)
    {
      this.personas = new List<Persona>();
      //this.cargar();
    }

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      FrmNuevo frmNuevo = new FrmNuevo();
      try
      {
        frmNuevo.ShowDialog();
        if (frmNuevo.DialogResult == DialogResult.OK)
        {
          this.personas.Add(frmNuevo.persona);
          this.LstbLista.Items.Add(frmNuevo.persona.ToString());
        }

      }
      catch (Exception ex)
      {
        if (ex.InnerException != null)
        {
          MessageBox.Show(ex.Message + ". "
            + ex.InnerException.Message);
        }
        else
        {
          MessageBox.Show(ex.Message);
        }
      }

    }

    private void BtnRefrescar_Click(object sender, EventArgs e)
    {
      this.LstbLista.Items.Clear();
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {

    }
    private void cargar()
    {

    }


    /*      GUARDAR CON XML
    private void BtnGuardar_Click(object sender, EventArgs e)
    {
      XmlTextWriter xtw = new XmlTextWriter(path, Encoding.UTF8);
      XmlSerializer xs = new XmlSerializer(typeof(List<Persona>));

        xs.Serialize(xtw, personas);
        MessageBox.Show("Se guardo correctamente");
      xtw.Close();
    }
    */
    /* LEER CON XML
    private void cargar()
    {
      List<Persona> aux;
      XmlTextReader xtr = new XmlTextReader(path);
      XmlSerializer xs = new XmlSerializer(typeof(List<Persona>));
      aux = (List<Persona>)xs.Deserialize(xtr);

      this.personas.AddRange(aux);
      foreach (Persona item in this.personas)
      {
        this.LstbLista.Items.Add(item.ToString());
      }

      xtr.Close();
    }
    */
  }
}
