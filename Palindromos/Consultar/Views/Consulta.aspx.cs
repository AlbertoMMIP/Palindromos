using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultar.Views
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InicializaControles();
        }
        protected void InicializaControles()
        {
            PnlError.Visible = false;
        }
        protected void lnkComprobar_Click(object sender, EventArgs e)
        {
            if(FileLoad.HasFile)
                ProcesaArchivo();
            else
                PnlError.Visible = true;
        }

        private void ProcesaArchivo()
        {
            StringBuilder texto = new StringBuilder();
            string doc = String.Empty;
            using (StreamReader sr = new StreamReader(FileLoad.FileContent))
            {
                doc = sr.ReadToEnd();
            }
            string[] lineas = doc.Split('\n');
            foreach(string linea in lineas)
            {
                texto.Append("<li>"+linea+" -> " + esPalindromo(linea.Trim().Replace(" ","").ToUpper())+ "</li>");
            }


            Resultados.Text = texto.ToString();
        }

        private string esPalindromo(string linea)
        {
            string resultado = "False", cadInv = String.Empty;
            int longCad = linea.Length;

            for(int i=longCad-1;i>=0;i--)
            {
                cadInv = cadInv + linea.Substring(i, 1);
            }
            if(linea.Equals(cadInv))
                resultado = "True";
            return resultado;
        }

        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            InicializaControles();
        }
    }
}