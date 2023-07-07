using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormConHilos
{
    static class Program
    {
        private static void RunForm()
        {
            Application.Run(new WindowsFormConHilos.FormPrincipal());
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Crear y ejecutar el formulario en un hilo separado
            Task.Run(new Action(RunForm));

            // Ejecutar otro hilo que interactúa con el formulario y la variable compartida
            //Task.Run(new Action(UpdateSharedVariable));

            // Mantener el hilo principal en espera
            Application.Run();
        }
    }
}
