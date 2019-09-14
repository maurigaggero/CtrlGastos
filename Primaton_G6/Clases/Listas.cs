using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    public class Listas
    {
        Usuario[] listaUsuarios = new Usuario[10];

        public void AgregaObjeto(Usuario usuario)
        {
            listaUsuarios[1] = usuario;
        }

        public int ContarRegistros()
        {
            int conteo = 0;
            for (int i = 0; i < listaUsuarios.Length; i++)
            {
                if (listaUsuarios[i] == null)
                {
                    conteo = i;
                    i = listaUsuarios.Length;
                }
            }
            return conteo;
        }

    }
}

//        public string[] DevuelveLista()
//        {
//            string[] lista = usuario;

//            return usuario;

//        }

//        public void MuestraUsuario()
//        {
//            File.Delete(ruta);

//            StreamWriter escribir = new StreamWriter(ruta, true);

//            string mRespuesta = "Usuario,Ingresos" + "\r\n";

//            mRespuesta = mRespuesta + usuario[0] + "," + ingresos[0] + "\r\n";
//            mRespuesta = mRespuesta + usuario[1] + "," + ingresos[1] + "\r\n";
//            mRespuesta = mRespuesta + usuario[2] + "," + ingresos[2] + "\r\n";
//            mRespuesta = mRespuesta + usuario[3] + "," + ingresos[3] + "\r\n";

//            //for (int k = 0; k < usuario.Length; k++)
//            //{
//            //   mRespuesta = mRespuesta + usuario[k] + "," + ingresos[k] + "\r\n";
//            //}

//            escribir.WriteLine(mRespuesta);
//            escribir.Close();

//            if (!File.Exists(ruta))
//            {
//                File.Create(ruta).Dispose();
//            }
//        }
//    }
//}