using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FrbaCommerce
{
    public static class commons
    {
        public static string hash(string input)
        {

            SHA256 hash = SHA256.Create();

            // Convertir la cadena en un array de bytes y calcular hash
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Copiar cada elemento del array a un
            // StringBuilder en formato hexadecimal
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static DateTime getDate()
        {
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\fecha.config"))
                {
                    String line = sr.ReadToEnd();
                    return Convert.ToDateTime(line);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo leer el archivo de configuracion.\nSe devolvera la fecha del sistema");
                return DateTime.Now;
            }
        }

        public static bool algunoVacio(params ComboBox[] campos)
        {
            bool vacio = false;

            for (int i = 0; i < campos.Count(); i++)
                if (campos[i].Text.Length == 0)
                {
                    vacio = true;
                    campos[i].BackColor = Color.LightPink;
                }
                else
                    campos[i].BackColor = Color.White;

            return vacio;
        }

        public static void selectAll(NumericUpDown numeric)
        {
            numeric.Select(0,numeric.Value.ToString().Length);
        }
        public static void selectAll(TextBox texto)
        {
            texto.Select(0, texto.Text.Length);
        }

        public static bool algunoVacio(params TextBox[] campos)
        {
            bool vacio = false;

            for (int i = 0; i < campos.Count(); i++)
                if (campos[i].Text.Length == 0)
                {
                    vacio = true;
                    campos[i].BackColor = Color.LightPink;
                }
                else
                    campos[i].BackColor = Color.White;

            return vacio;
        }

        public static bool algunoVacio(params ListBox[] campos)
        {
            bool vacio = false;

            for (int i = 0; i < campos.Count(); i++)
                if (campos[i].SelectedIndex == -1)
                {
                    vacio = true;
                    campos[i].BackColor = Color.LightPink;
                }
                else
                    campos[i].BackColor = Color.White;

            return vacio;
        }

        public static bool algunoVacio(params NumericUpDown[] campos)
        {
            bool vacio = false;

            for (int i = 0; i < campos.Count(); i++)
                if (campos[i].Value == 0)
                {
                    vacio = true;
                    campos[i].BackColor = Color.LightPink;
                }
                else
                    campos[i].BackColor = Color.White;

            return vacio;
        }

        public static void bloquearCampos(params TextBox[] campos)
        {
            foreach (TextBox campo in campos)
                campo.Enabled = false;
        }

        public static void bloquearCampos(params Button[] botones)
        {
            foreach (Button boton in botones)
                boton.Enabled=  false;
        }
    }
}
