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
            var rutaArchivo = nombreArchivo.Value;
            if (!String.IsNullOrEmpty(rutaArchivo))
                ProcesaArchivo();
            else
                PnlError.Visible = true;
        }

        private void ProcesaArchivo()
        {
            //Stream myStream;
            //Int32 fileLen;
            StringBuilder displayString = new StringBuilder();
            string line = "";

            System.IO.StreamReader file = new System.IO.StreamReader(@""+ nombreArchivo.Value+ "");
            while ((line = file.ReadLine()) != null)
            {
                displayString.Append(line);
            }
            //// Get the length of the file.
            //fileLen = FileLoad.PostedFile.ContentLength;

            //// Create a byte array to hold the contents of the file.
            //Byte[] Input = new Byte[fileLen];

            //// Initialize the stream to read the uploaded file.
            //myStream = FileLoad.FileContent;
            //// Read the file into the byte array.
            //myStream.Read(Input, 0, fileLen);

            // Copy the byte array to a string.
            //for (int loop1 = 0; loop1 < fileLen; loop1++)
            //{
            //    displayString.Append(Input[loop1].ToString());
            //}

            // Display the contents of the file in a 
            // textbox on the page.
            Resultados.Text = displayString.ToString();
        }

        protected void BtnCerrar_Click(object sender, EventArgs e)
        {
            InicializaControles();
        }
    }
}