using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

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
    }
}
