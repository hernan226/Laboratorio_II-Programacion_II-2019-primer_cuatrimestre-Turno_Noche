using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
  public partial class Form1 : Form
  {
    delegate void Callback();
    public Thread ponerHora;
    public Form1()
    {
      InitializeComponent();
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.LblHora.Text = DateTime.Now.ToString();

      ponerHora = new Thread(new ThreadStart(HoraActual));
      ponerHora.Start();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Form1_Closing(object sender, FormClosingEventArgs e)
    {
      ponerHora.Abort();
    }

    public void HoraActual()
    {
      do
      {
        Thread.Sleep(1000);
        cambiarHora();
      } while (true);
    }

    public void cambiarHora()
    {
      if (this.LblHora.InvokeRequired)
      {
        Callback call = new Callback(this.cambiarHora);
        this.Invoke(call);
      }
      else
        this.LblHora.Text = DateTime.Now.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      HoraActual();
    }
  }
}
