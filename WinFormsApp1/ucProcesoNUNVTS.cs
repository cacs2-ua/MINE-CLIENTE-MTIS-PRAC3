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
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class ucProcesoNUNVTS : UserControl
    {
        public ucProcesoNUNVTS()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo del correo electrónico no puede estar vacío.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string SoapWSKey = Utils.obtenerSoapKey();
            string RestWSKey = Utils.obtenerRestKey();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://localhost:9094/procesoNUNVTS?email={Uri.EscapeDataString(email)}";

                    var content = new StringContent("{}", Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage(HttpMethod.Post, url)
                    {
                        Content = content
                    };

                    request.Headers.Add("SoapWSKey", SoapWSKey);
                    request.Headers.Add("RestWSKey", RestWSKey);

                    HttpResponseMessage response = await client.SendAsync(request);

                    string result = await response.Content.ReadAsStringAsync();

                    MessageBox.Show($"Código: {(int)response.StatusCode}\nRespuesta: El flujo se ha completado con éxito",
                        "Resultado del flujo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el flujo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
