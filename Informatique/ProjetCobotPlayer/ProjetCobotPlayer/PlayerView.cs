using EnhancedSocket.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCobotPlayer
{
    public partial class PlayerView : Form
    {

        #region ATTRIBUTES

        HomeMenu menuprincipal;
        CobotIPInfo cobotIP;

        String IPAddress = "10.2.0.3";
        //String IPAddress = "192.168.31.128";

        ushort Port = 30001;

        ETcpRoutine Routine;

        #endregion

        #region CTOR
        public PlayerView()
        {
            InitializeComponent();
            
            Routine = new ETcpRoutine(IPAddress, Port);

            Task.Run(TestConnexion);

        }
        #endregion

        #region METHODS
        private void buttonPlay_Click(object sender, EventArgs e)
                {

                    this.Visible = false;
                    menuprincipal = new HomeMenu(Routine);
                    if (menuprincipal.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Visible = true;
                    }
            
                }
        #endregion

        #region ASYNC METHODS
        private async Task TestConnexion()
        {
            Debug.WriteLine("DEBUG : Tentative de Connexion");

            labelConnection.BackColor = DefaultBackColor;
            labelConnection.ForeColor = Color.Black;
            labelConnection.Text = "Test en cours...";
            labelConnection.Enabled = false;
            buttonPlay.Enabled = false;

            try
            {
                await Routine.ConnectAsync();
                this.BeginInvoke(new Action(() =>
                {

                    labelConnection.BackColor = Color.Lime;
                    labelConnection.Text = "CONNEXION AU COBOT REUSSIE";
                    labelConnection.Enabled = true;
                    buttonPlay.Enabled = true;
                    Debug.WriteLine("DEBUG : Connexion réussie.");

                }));
                
            }
            catch (Exception ex)
            {

                this.BeginInvoke(new Action(() =>
                {
                    
                    labelConnection.BackColor = Color.DarkRed;
                    labelConnection.Text = "TEST CONNEXION NON CONCLUANT";
                    labelConnection.Enabled = true;
                    labelConnection.ForeColor = Color.White;
                    Debug.WriteLine("DEBUG : Connexion échouée.");

                }));

                Debug.WriteLine(ex.Message);

            }

        }

        private async void labelConnection_Click(object sender, EventArgs e)
        {
            if (Routine == null)
            {
                Routine.Dispose();
            }
            
            cobotIP = new CobotIPInfo(IPAddress, Port);

            if (cobotIP.ShowDialog() == DialogResult.OK)
            {
                IPAddress = cobotIP.IPAddress;
                Port = cobotIP.PORT;
                Debug.WriteLine("DEBUG : IPAdress = " + IPAddress + " | Port = " + Port);

                
                Routine = new ETcpRoutine(IPAddress, Port);

                await TestConnexion();
            }
            
        }
        #endregion

    }
}
