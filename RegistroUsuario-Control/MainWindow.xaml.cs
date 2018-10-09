using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace RegistroUsuario_Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string validadorString = null;
            InitializeComponent();
        }

        private void cbTipoUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelUsuario.Children.Clear();

            switch (cbTipoUsuario.SelectedIndex)
            {
                case 0:
                    panelUsuario.Children.Add(new ControlAlumno());
                    break;
                case 1:
                    panelUsuario.Children.Add(new ControlMaestro());
                    break;
            }
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            switch (cbTipoUsuario.SelectedIndex)
            {
                case 0:
                    var controlAlumno = (ControlAlumno)panelUsuario.Children[0];

                    if (controlAlumno.txtNombreAlumno.Text == "" || controlAlumno.txtNombreAlumno.Text == " ")
                    {
                        controlAlumno.lblNombreAlumno.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlAlumno.lblNombreAlumno.Foreground = Brushes.Black;
                    }

                    if (controlAlumno.txtDireccionAlumno.Text == "" || controlAlumno.txtDireccionAlumno.Text == " ")
                    {
                        controlAlumno.lblDireccionAlumno.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlAlumno.lblDireccionAlumno.Foreground = Brushes.Black;
                    }

                    if (controlAlumno.cb_CarreraAlumno.Text == "" || controlAlumno.cb_CarreraAlumno.Text == " ")
                    {
                        controlAlumno.lblCarreraAlumno.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlAlumno.lblCarreraAlumno.Foreground = Brushes.Black;
                    }

                    if (controlAlumno.txtPreparatoriaProcedencia.Text == "" || controlAlumno.txtPreparatoriaProcedencia.Text == " ")
                    {
                        controlAlumno.lblPreparatoriaProcedencia.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlAlumno.lblPreparatoriaProcedencia.Foreground = Brushes.Black;
                    }

                    break;
                case 1:
                    var controlMaestro = (ControlMaestro)panelUsuario.Children[0];

                    if (controlMaestro.lblNombreMaestro.Text == "" || controlMaestro.lblNombreMaestro.Text == " ")
                    {
                        controlMaestro.lblNombreMaestro.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlMaestro.lblTelefonoMaestro.Foreground = Brushes.Black;
                    }

                    if (controlMaestro.txtTelefonoMaestro.Text == "" || controlMaestro.txtTelefonoMaestro.Text == " ")
                    {
                        controlMaestro.lblTelefonoMaestro.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlMaestro.lblTelefonoMaestro.Foreground = Brushes.Black;
                    }

                    if (controlMaestro.txtCedulaMaestro.Text == "" || controlMaestro.txtCedulaMaestro.Text == " ")
                    {
                        controlMaestro.lblCedulaMaestro.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlMaestro.lblCedulaMaestro.Foreground = Brushes.Black;
                    }

                    if (controlMaestro.txtCarreraMaestro.Text == "" || controlMaestro.txtCarreraMaestro.Text == " ")
                    {
                        controlMaestro.lblCarreraMaestro.Foreground = Brushes.Red;
                    }
                    else
                    {
                        controlMaestro.lblCarreraMaestro.Foreground = Brushes.Black;
                    }

                    break;
            }
        }
    }
}