using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.utils;

namespace WinFormsApp1
{
    public partial class ucProcesoNENV : UserControl
    {
        public ucProcesoNENV()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string WSKey = Utils.obtenerSoapKey();
                string WSRestKey = Utils.obtenerRestKey();

                using (var client = new HttpClient())
                {
                    var url = "http://localhost:9093/procesoNENV";

                    var contenido = new StringContent("{}", Encoding.UTF8, "application/json");

                    contenido.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    client.DefaultRequestHeaders.Add("WSKey", WSKey);
                    client.DefaultRequestHeaders.Add("WSRestKey", WSRestKey);

                    HttpResponseMessage response = await client.PostAsync(url, contenido);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    MessageBox.Show($"Código: {(int)response.StatusCode}\nRespuesta: {responseBody}",
                        "Resultado del flujo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el flujo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucProcesoNENV_Load(object sender, EventArgs e)
        {

        }
    }
}
