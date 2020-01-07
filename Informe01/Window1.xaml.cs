using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Informe01
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
            //reportViewer.Owner = this;
            //reportViewer2.Owner = this;
            //reportViewer3.Owner = this;
            //reportViewer4.Owner = this;
            //reportViewer5.Owner = this;
            //CrystalReport1 informe = new CrystalReport1();
            //CrystalReport2 informe2 = new CrystalReport2();
            //CrystalReport3 informe3 = new CrystalReport3();
            //CrystalReport4 informe4 = new CrystalReport4();
            //CrystalReport5 informe5 = new CrystalReport5();


            //informe.SetDatabaseLogon("Administrador", "admin123.");
            //informe2.SetDatabaseLogon("Administrador", "admin123.");
            //informe3.SetDatabaseLogon("Administrador", "admin123.");
            //informe4.SetDatabaseLogon("Administrador", "admin123.");
            //informe5.SetDatabaseLogon("Administrador","admin123.");

            //reportViewer.ViewerCore.ReportSource = informe;
            //reportViewer2.ViewerCore.ReportSource = informe2;
            //reportViewer3.ViewerCore.ReportSource = informe3;
            //reportViewer4.ViewerCore.ReportSource = informe4;
            //reportViewer5.ViewerCore.ReportSource = informe5;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int tabItem = ((sender as TabControl)).SelectedIndex;
            if (e.Source is TabControl) 
            {
                switch (tabItem)
                {
                    case 0:
                        reportViewer.Owner = this;
                        CrystalReport1 informe = new CrystalReport1();
                        informe.SetDatabaseLogon("Administrador", "admin123.");
                        reportViewer.ViewerCore.ReportSource = informe;
                        break;
                    case 1:
                        reportViewer2.Owner = this;
                        CrystalReport2 informe2 = new CrystalReport2();
                        informe2.SetDatabaseLogon("Administrador", "admin123.");
                        reportViewer.ViewerCore.ReportSource = informe2;
                        break;
                    case 2:    
                        reportViewer3.Owner = this;
                        CrystalReport3 informe3 = new CrystalReport3();
                        informe3.SetDatabaseLogon("Administrador", "admin123.");
                        reportViewer.ViewerCore.ReportSource = informe3;
                        break;
                    case 3:
                        reportViewer4.Owner = this;
                        CrystalReport4 informe4 = new CrystalReport4();
                        informe4.SetDatabaseLogon("Administrador", "admin123.");
                        reportViewer.ViewerCore.ReportSource = informe4;
                        break;
                    case 4:  
                        reportViewer5.Owner = this;
                        CrystalReport5 informe5 = new CrystalReport5();
                        informe5.SetDatabaseLogon("Administrador", "admin123.");
                        reportViewer.ViewerCore.ReportSource = informe5;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
