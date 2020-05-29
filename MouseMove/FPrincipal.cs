using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class FPrincipal : Form
    {
        /*
         * FUNCAO QUE IDENTIFICA UMA TECLA PRESSIONADA FORA DA GUI
         */
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetAsyncKeyState(int vKey);

        /*
         * FUNCAO QUE MOVE O CURSOR NA TELA DO WINDOWS
         * RECEBE LOCAL X E LOCAL Y
         */
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        /* FUNCAO QUE APLICA EVENTO NO MOUSE
         * RECEBE FLAGS, X, Y, BUTONS E INFOS
         */
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        /*
         * CONSTANTES QUE RETRATAM AS ACOES DO MOUSE
         */
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        /*
         * CONSTANTES QUE RETRATAM AS ACOES DO TECLADO
         */
        private const int VK_ESCAPE = 0x1B;    // ESC

        /*
         * DECLARAÇÃO DAS VARIÁVEIS DO SISTEMA
         */
        private Thread initRobo;
        private Thread listenKeyPress;

        /*
         * INICIO DA APLICAÇÃO
         */

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void InitProcess()
        {
            try
            {
                int vezes = int.Parse(TQtdeVezes.Text);
                int i = 0;

                while (i < vezes)
                {
                    SStatusLabel.Text = "Status: Rodando... " + i.ToString();

                    Thread.Sleep(1000);

                    Cursor.Position = new Point(400, 400);

                    mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);

                    Thread.Sleep(1000);

                    Cursor.Position = new Point(370, 465);

                    Thread.Sleep(1000);

                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    i++;

                }
                SStatusLabel.Text = "Status: Parado";
                initRobo.Abort();
            }
            catch (Exception ex)
            {
                SStatusLabel.Text = ex.Message;
            }

        }

        private void ListenKeyPressed()
        {
            SStatusTecla.Text = "Pressione ESC, para parar!";
            while (true)
            {
                short keyState = GetAsyncKeyState(VK_ESCAPE);
                //bool escIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;
                bool escUnProcessedPress = ((keyState >> 0) & 0x0001) == 0x0001;

                if (escUnProcessedPress || initRobo.ThreadState == ThreadState.Stopped)
                {
                    break;
                }
            }
            SStatusTecla.Text = "";
            SStatusLabel.Text = "Status: Parado";
            initRobo.Abort();
        }

        /*
         * ACTIONS
         */

        private void BExecute_Click(object sender, System.EventArgs e)
        {
            try
            {
                initRobo = new Thread(InitProcess);
                initRobo.Start();

                listenKeyPress = new Thread(ListenKeyPressed);
                listenKeyPress.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("A quantidade deve ser numérica");
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TQtdeVezes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int vezes = int.Parse(TQtdeVezes.Text);
                if(vezes <= 0)
                {
                    MessageBox.Show("O valor é menor ou igual a zero");
                    TQtdeVezes.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O valor não é numérico");
                TQtdeVezes.Text = "1";
            }


        }
    }
}
