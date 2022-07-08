using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        //private readonly IEngine engine;
        //private readonly IBrowser browser;

        public MainWindow()
        {
            InitializeComponent();
            ////Create and initialize the IEngine
            //engine = EngineFactory.Create();

            ////Create the IBrowser
            //browser = engine.CreateBrowser();
            //browser.Navigation.LoadUrl("https://www.google.com/");

            ////Initialize the WPF BrowserView control
            //browserView.InitializeFrom(browser);

        }

        void Cerrar(object sender, RoutedEventArgs e)
        {
          
            this.Close();
        }
        void Minimize(object sender, RoutedEventArgs e)
        {
            ventana.WindowState = WindowState.Minimized;
        }
        

        //Comprabar si los campos estan vacios
        private Boolean comprobarCampos()
        {
            Boolean check = true;
            String IDcuenta = IDCuenta.Text;
            String IDproducto = IDProducto.Text;
            String IDproyecto = IDProyecto.Text;
            String IDaplicacion = IDAplicacion.Text;
            String correodestino = CorreoDestino.Text;
            String asunto = Asunto.Text;
            String cuerpoMensaje = Mensaje.Text;

            //Llenar Lista Con los Datos
            List<string> lista = new List<string>();
            lista.Add(IDcuenta);
            lista.Add(IDproducto);
            lista.Add(IDproyecto);
            lista.Add(IDaplicacion);
            lista.Add(correodestino);
            lista.Add(asunto);
            lista.Add(cuerpoMensaje);
            //Recorremos la lista en busca de algun valor nulo o vacio para cambiar el mensaje de alerta
            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] == null || lista[i] == "")
                {

                    check = false;
                    break;
                }
            }
            return check;

        }
        void Enviar(object sender, RoutedEventArgs e)
        {
            //Exportamos el booleano de la verificación de los campos
            Boolean check;
            check = comprobarCampos();


            if (check)
            {
                //Se envia el correo y se muestra el mensaje de exito
                enviarCorreo();
                System.Windows.MessageBox.Show("Mensaje enviado correctamente", "Proceso Exitoso!", MessageBoxButton.OKCancel);
            }
            else
            {
                //Se muestra mensaje de error
                System.Windows.MessageBox.Show("Debes llenar todos los campos para poder enviar el correo...", "Proceso Fallido!", MessageBoxButton.OKCancel);
            }


        }
        private void enviarCorreo()
        {
            BPMMail.BPMMailServiceClient BPMMailClient = new BPMMail.BPMMailServiceClient();
            
            try
            {
                //Datos de los TextBox
                int idUsuarioBPM = int.Parse(IDCuenta.Text);
                int idProductoBPM = int.Parse(IDProducto.Text);
                int idProyectoBPM = int.Parse(IDProyecto.Text);
                int idAplicacionBPM = int.Parse(IDAplicacion.Text);
                String asunto = Asunto.Text;
                String mensaje = Mensaje.Text;
                String correodestino = CorreoDestino.Text;
                var respuestaBPMMail = BPMMailClient.EnviarCorreoAsync(idUsuarioBPM, idProductoBPM, idProyectoBPM, idAplicacionBPM, 2, asunto, mensaje, "", null, null, null, 0, "172.19.175.41", correodestino, 0, null);
                //Datos de Quemados
                //int idUsuarioBPM = Convert.ToInt32(701);
                //int idProductoBPM = Convert.ToInt32(9);
                //int idAplicacionBPM = Convert.ToInt32(22);
                //var respuesta = BPMMailClient.EnviarCorreo(484, 8, 11, 2903, 2, "Asunto prueba BPM MAIL", mensajeCorreo, "restaurar_clave_"+fechaActual+".pdf", pdfbytes, null, null, 0, "ipOrigen::1", "dpuentes@syc.com.co", 0, null);  
                
            }
            catch (Exception)
            {
                //Mensaje de error por si fallan los datos
                System.Windows.MessageBox.Show("Ha ocurrido un error, intentalo de nuevo...", "Proceso Fallido!", MessageBoxButton.OKCancel);
                throw;
            }
        }
       

        void VistaPrevia(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
