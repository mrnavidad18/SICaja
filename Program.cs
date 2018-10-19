﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SICaja.Vista;
using SICaja.Vista.FormulariosMantenimiento;
using SICaja.Vista.FormulariosUsuario;

namespace SICaja
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new AccesoUsuarioCaja());
        }
    }
}
