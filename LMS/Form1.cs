using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmPrincipal : Form
    {
        int m, mx, my;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, // Coordenada x de la esquina superior izquierda
           int nTopRect, // Coordenada y de la esquina superior izquierda
           int nRightRect, // Coordenada x de la esquina inferior derecha
           int nBottomRect, // Coordenada y de la esquina inferior derecha
           int nWidthEllipse, // Altura de la elipse
           int nHeightEllipse // Ancho de la elipse
       );


        public frmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txb1.Focus();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {

                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {
            btnTru();
            

            switch (txb1.Text)
            {
                case "A":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.A;
                    ptb1.Visible = true;
                    break;
                case "B":
                    this.ptb1.Image = Properties.Resources.B;
                    ptb1.Visible = true;
                    break;
                case "C":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.C;
                    ptb1.Visible = true;
                    break;
                case "D":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.D;
                    ptb1.Visible = true;
                    break;
                case "E":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.E;
                    ptb1.Visible = true;
                    break;
                case "F":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.F;
                    ptb1.Visible = true;
                    break;
                case "G":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.G;
                    ptb1.Visible = true;
                    break;
                case "H":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.H;
                    ptb1.Visible = true;
                    break;
                case "I":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.I;
                    ptb1.Visible = true;
                    break;
                case "J":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.J;
                    ptb1.Visible = true;
                    break;
                case "K":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.K;
                    ptb1.Visible = true;
                    break;
                case "L":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.L;
                    ptb1.Visible = true;
                    break;
                case "M":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.M;
                    ptb1.Visible = true;
                    break;
                case "N":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.N;
                    ptb1.Visible = true;
                    break;
                case "Ñ":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.Ñ;
                    ptb1.Visible = true;
                    break;
                case "O":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.O;
                    ptb1.Visible = true;
                    break;
                case "P":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.P;
                    ptb1.Visible = true;
                    break;
                case "Q":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.Q;
                    ptb1.Visible = true;
                    break;
                case "R":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.R;
                    ptb1.Visible = true;
                    break;
                case "S":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.S;
                    ptb1.Visible = true;
                    break;
                case "T":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.T;
                    ptb1.Visible = true;
                    break;
                case "U":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.U;
                    ptb1.Visible = true;
                    break;
                case "V":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.V;
                    ptb1.Visible = true;
                    break;
                case "W":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.W;
                    ptb1.Visible = true;
                    break;
                case "X":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.X;
                    ptb1.Visible = true;
                    break;
                case "Y":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.Y;
                    ptb1.Visible = true;
                    break;
                case "Z":
                    btnTru();
                    this.ptb1.Image = Properties.Resources.Z;
                    ptb1.Visible = true;
                    break;
                default:
                    ptb1.Visible = false;
                    break;
            }

        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {
            btnTru();
            switch (txb2.Text)
            {
                case "A":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.A;
                    ptb2.Visible = true;
                    break;
                case "B":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.B;
                    ptb2.Visible = true;
                    break;
                case "C":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.C;
                    ptb2.Visible = true;
                    break;
                case "D":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.D;
                    ptb2.Visible = true;
                    break;
                case "E":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.E;
                    ptb2.Visible = true;
                    break;
                case "F":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.F;
                    ptb2.Visible = true;
                    break;
                case "G":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.G;
                    ptb2.Visible = true;
                    break;
                case "H":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.H;
                    ptb2.Visible = true;
                    break;
                case "I":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.I;
                    ptb2.Visible = true;
                    break;
                case "J":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.J;
                    ptb2.Visible = true;
                    break;
                case "K":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.K;
                    ptb2.Visible = true;
                    break;
                case "L":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.L;
                    ptb2.Visible = true;
                    break;
                case "M":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.M;
                    ptb2.Visible = true;
                    break;
                case "N":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.N;
                    ptb2.Visible = true;
                    break;
                case "Ñ":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.Ñ;
                    ptb2.Visible = true;
                    break;
                case "O":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.O;
                    ptb2.Visible = true;
                    break;
                case "P":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.P;
                    ptb2.Visible = true;
                    break;
                case "Q":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.Q;
                    ptb2.Visible = true;
                    break;
                case "R":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.R;
                    ptb2.Visible = true;
                    break;
                case "S":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.S;
                    ptb2.Visible = true;
                    break;
                case "T":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.T;
                    ptb2.Visible = true;
                    break;
                case "U":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.U;
                    ptb2.Visible = true;
                    break;
                case "V":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.V;
                    ptb2.Visible = true;
                    break;
                case "W":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.W;
                    ptb2.Visible = true;
                    break;
                case "X":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.X;
                    ptb2.Visible = true;
                    break;
                case "Y":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.Y;
                    ptb2.Visible = true;
                    break;
                case "Z":
                    btnTru();
                    this.ptb2.Image = Properties.Resources.Z;
                    ptb2.Visible = true;
                    break;
                default:
                    ptb2.Visible = false;
                    break;
            }

        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {
            btnTru();
            switch (txb3.Text)
            {
                case "A":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.A;
                    ptb3.Visible = true;
                    break;
                case "B":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.B;
                    ptb3.Visible = true;
                    break;
                case "C":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.C;
                    ptb3.Visible = true;
                    break;
                case "D":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.D;
                    ptb3.Visible = true;
                    break;
                case "E":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.E;
                    ptb3.Visible = true;
                    break;
                case "F":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.F;
                    ptb3.Visible = true;
                    break;
                case "G":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.G;
                    ptb3.Visible = true;
                    break;
                case "H":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.H;
                    ptb3.Visible = true;
                    break;
                case "I":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.I;
                    ptb3.Visible = true;
                    break;
                case "J":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.J;
                    ptb3.Visible = true;
                    break;
                case "K":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.K;
                    ptb3.Visible = true;
                    break;
                case "L":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.L;
                    ptb3.Visible = true;
                    break;
                case "M":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.M;
                    ptb3.Visible = true;
                    break;
                case "N":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.N;
                    ptb3.Visible = true;
                    break;
                case "Ñ":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.Ñ;
                    ptb3.Visible = true;
                    break;
                case "O":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.O;
                    ptb3.Visible = true;
                    break;
                case "P":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.P;
                    ptb3.Visible = true;
                    break;
                case "Q":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.Q;
                    ptb3.Visible = true;
                    break;
                case "R":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.R;
                    ptb3.Visible = true;
                    break;
                case "S":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.S;
                    ptb3.Visible = true;
                    break;
                case "T":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.T;
                    ptb3.Visible = true;
                    break;
                case "U":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.U;
                    ptb3.Visible = true;
                    break;
                case "V":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.V;
                    ptb3.Visible = true;
                    break;
                case "W":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.W;
                    ptb3.Visible = true;
                    break;
                case "X":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.X;
                    ptb3.Visible = true;
                    break;
                case "Y":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.Y;
                    ptb3.Visible = true;
                    break;
                case "Z":
                    btnTru();
                    this.ptb3.Image = Properties.Resources.Z;
                    ptb3.Visible = true;
                    break;
                default:
                    ptb3.Visible = false;
                    break;
            }

        }

        private void txb4_TextChanged(object sender, EventArgs e)
        {
            btnTru();
            switch (txb4.Text)
            {
                case "A":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.A;
                    ptb4.Visible = true;
                    break;
                case "B":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.B;
                    ptb4.Visible = true;
                    break;
                case "C":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.C;
                    ptb4.Visible = true;
                    break;
                case "D":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.D;
                    ptb4.Visible = true;
                    break;
                case "E":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.E;
                    ptb4.Visible = true;
                    break;
                case "F":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.F;
                    ptb4.Visible = true;
                    break;
                case "G":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.G;
                    ptb4.Visible = true;
                    break;
                case "H":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.H;
                    ptb4.Visible = true;
                    break;
                case "I":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.I;
                    ptb4.Visible = true;
                    break;
                case "J":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.J;
                    ptb4.Visible = true;
                    break;
                case "K":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.K;
                    ptb4.Visible = true;
                    break;
                case "L":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.L;
                    ptb4.Visible = true;
                    break;
                case "M":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.M;
                    ptb4.Visible = true;
                    break;
                case "N":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.N;
                    ptb4.Visible = true;
                    break;
                case "Ñ":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.Ñ;
                    ptb4.Visible = true;
                    break;
                case "O":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.O;
                    ptb4.Visible = true;
                    break;
                case "P":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.P;
                    ptb4.Visible = true;
                    break;
                case "Q":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.Q;
                    ptb4.Visible = true;
                    break;
                case "R":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.R;
                    ptb4.Visible = true;
                    break;
                case "S":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.S;
                    ptb4.Visible = true;
                    break;
                case "T":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.T;
                    ptb4.Visible = true;
                    break;
                case "U":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.U;
                    ptb4.Visible = true;
                    break;
                case "V":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.V;
                    ptb4.Visible = true;
                    break;
                case "W":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.W;
                    ptb4.Visible = true;
                    break;
                case "X":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.X;
                    ptb4.Visible = true;
                    break;
                case "Y":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.Y;
                    ptb4.Visible = true;
                    break;
                case "Z":
                    btnTru();
                    this.ptb4.Image = Properties.Resources.Z;
                    ptb4.Visible = true;
                    break;

                default:
                    ptb4.Visible = false;
                    break;
            }


        }

        private void txb5_TextChanged(object sender, EventArgs e)
        {
            btnTru();
            switch (txb5.Text)
            {
                case "A":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.A;
                    ptb5.Visible = true;
                    break;
                case "B":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.B;
                    ptb5.Visible = true;
                    break;
                case "C":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.C;
                    ptb5.Visible = true;
                    break;
                case "D":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.D;
                    ptb5.Visible = true;
                    break;
                case "E":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.E;
                    ptb5.Visible = true;
                    break;
                case "F":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.F;
                    ptb5.Visible = true;
                    break;
                case "G":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.G;
                    ptb5.Visible = true;
                    break;
                case "H":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.H;
                    ptb5.Visible = true;
                    break;
                case "I":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.I;
                    ptb5.Visible = true;
                    break;
                case "J":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.J;
                    ptb5.Visible = true;
                    break;
                case "K":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.K;
                    ptb5.Visible = true;
                    break;
                case "L":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.L;
                    ptb5.Visible = true;
                    break;
                case "M":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.M;
                    ptb5.Visible = true;
                    break;
                case "N":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.N;
                    ptb5.Visible = true;
                    break;
                case "Ñ":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.Ñ;
                    ptb5.Visible = true;
                    break;
                case "O":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.O;
                    ptb5.Visible = true;
                    break;
                case "P":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.P;
                    ptb5.Visible = true;
                    break;
                case "Q":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.Q;
                    ptb5.Visible = true;
                    break;
                case "R":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.R;
                    ptb5.Visible = true;
                    break;
                case "S":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.S;
                    ptb5.Visible = true;
                    break;
                case "T":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.T;
                    ptb5.Visible = true;
                    break;
                case "U":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.U;
                    ptb5.Visible = true;
                    break;
                case "V":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.V;
                    ptb5.Visible = true;
                    break;
                case "W":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.W;
                    ptb5.Visible = true;
                    break;
                case "X":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.X;
                    ptb5.Visible = true;
                    break;
                case "Y":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.Y;
                    ptb5.Visible = true;
                    break;
                case "Z":
                    btnTru();
                    this.ptb5.Image = Properties.Resources.Z;
                    ptb5.Visible = true;
                    break;
                default:
                    ptb5.Visible = false;
                    break;
            }

        }

        public void OcultarImganes()
        {

            ptb1.Visible = false;
            ptb2.Visible = false;
            ptb3.Visible = false;
            ptb4.Visible = false;
            ptb5.Visible = false;
            ptbPalabras.Visible = false;

        }

        private void txb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { txb2.Focus(); }

        }

        private void txb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { txb3.Focus(); }
        }

        private void txb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { txb4.Focus(); }
        }

        private void txb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { txb5.Focus(); }
        }

        private void txb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) { btnResetear.Focus(); }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\nAVENA\nATOLE\nCAFÉ\nCARNE\nCALDO\nCENA\nCREMA\nDONA\nFIDEO\nHUEVO\nLECHE\nLICOR\nMIEL\nPAN\nPAY\nPIZZA\nPOLVO\nQUESO\nRICO\nSALSA", "Diccionario de palabras", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txb1.Focus();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String todos;

            todos = txb1.Text + txb2.Text + txb3.Text + txb4.Text + txb5.Text;
            btnResetear.Focus();

            try
            {

                switch (todos)
                {
                    case "AVENA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.AVENA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con una mano se hace una a y se coloca en la boca, tocándola con el pulgar.";
                        break;
                    case "ATOLE":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.ATOLE;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una letra a con ambas manos, y se mueven alternadas subiendo y rotando la muñeca hacia abajo.";
                        break;
                    case "CAFE":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.CAFÉ;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una c, que se coloca en el puño de\n la otra mano, con un movimiento circular en su lugar.";
                        break;
                    case "CARNE":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.CARNE;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con los dedos índice y pulgar de una mano se pellizca el dorso de la otra.";
                        break;
                    case "CALDO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.CALDO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una c con los dedos ligeramente separados, y se coloca sobre el dorso del puño, tocándolo con la punta de los dedos.";
                        break;
                    case "CENA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.CENA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una c, y se coloca a la altura de la boca, señalándola con la punta de los dedos índice, medio, anular y meñique, con movimiento al frente y de regreso varias veces.";
                        break;
                    case "CREMA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.CREMA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se imita la acción de servir crema.";
                        break;
                    case "DONA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.DONA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una o con las palmas hacia abajo, tocándose por la parte lateral de los dedos índices.Se hace un movimiento circular hacia usted, y se voltean las manos.";
                        break;
                    case "FIDEO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.FIDEO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se unen los índices y pulgares por las yemas, y se realiza un movimiento corto en línea recta a los lados.";
                        break;
                    case "HUEVO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.HUEVO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se colocan el índice, el medio y el pulgar en posición de garra, y con el dorso del pulgar se golpea varias veces el dedo índice estirado de la otra mano.";
                        break;
                    case "LECHE":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.LECHE;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una letra g con ambas manos y se realizan movimientos alternados hacia arriba y abajo.";
                        break;
                    case "LICOR":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.LICOR;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una l sobre la mejilla y se realiza un movimiento circular.";
                        break;
                    case "MIEL":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.MIEL;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se hace una letra m, se coloca sobre los labios, y se realiza un movimiento hacia abajo.";
                        break;
                    case "PAN":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.PAN;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con las manos cerradas y unidas por los dorsos de los dedos, se hace un movimiento al frente, girando las muñecas y separándolas.";
                        break;
                    case "PAY":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.PAY;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se colocan las puntas de los dedos índice y medio estirados en la parte lateral del dedo índice de la otra mano.";
                        break;
                    case "PIZZA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.PIZZA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "El índice y el medio se colocan en posición de garra y se realiza un movimiento en zigzag.";
                        break;
                    case "POLVO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.POLVO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Se abre la mano y con la punta de los dedos se toca la palma de la otra mano. Se hace un movimiento hacia arriba, hasta cerrar la mano en punta.";
                        break;
                    case "QUESO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.QUESO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con la yema del dedo medio se toca el dorso de la otra mano, y se realiza un movimiento corto hacia abajo.";
                        break;
                    case "RICO":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.RICO;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con la yema de los dedos se rozan los labios.";
                        break;
                    case "SALSA":
                        OcultarImganes();
                        reset();
                        this.ptbPalabras.Image = Properties.Resources.SALSA;
                        ptbPalabras.Visible = true;
                        lblInfo.Visible = true;
                        lblInfo.Text = "Con la palma de una mano abierta se golpea el puño de la otra.";
                        break;
                    default:
                        btnBuscar.Enabled = false;
                        btnResetear.Enabled = false;
                        DialogResult msj = MessageBox.Show("Esa palabra está mal escrita o no está en el diccionario de palabras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (msj == DialogResult.OK)
                        {
                            btnBuscar.Enabled = false;
                            btnResetear.Enabled = false;
                            OcultarImganes();
                            txb1.Enabled = true;
                            txb2.Enabled = true;
                            txb3.Enabled = true;
                            txb4.Enabled = true;
                            txb5.Enabled = true;
                            txb1.Text = "";
                            txb2.Text = "";
                            txb3.Text = "";
                            txb4.Text = "";
                            txb5.Text = "";
                            txb1.Focus();
                        }
                        break;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }


        }

        public void reset() {
            txb1.Enabled = false;
            txb2.Enabled = false;
            txb3.Enabled = false;
            txb4.Enabled = false;
            txb5.Enabled = false;
            btnBuscar.Enabled = false;
        }
        public void btnTru()
        {
            ptbPalabras.Visible = false;
            lblInfo.Visible = false;
            btnBuscar.Enabled = true;
            btnResetear.Enabled = true;
        }

       
        private void btnResetear_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarImganes();
                txb1.Enabled = true;
                txb2.Enabled = true;
                txb3.Enabled = true;
                txb4.Enabled = true;
                txb5.Enabled = true;
                txb1.Text = "";
                txb2.Text = "";
                txb3.Text = "";
                txb4.Text = "";
                txb5.Text = "";
                lblInfo.Text = "";
                lblInfo.Visible = false;
                btnResetear.Enabled = false;
                btnBuscar.Enabled = false;
                txb1.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }


    }
}
