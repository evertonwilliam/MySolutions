using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ApiWindows
{
    public partial class FPrincipal : Form
    {
        Thread capThread;
        IntPtr ultimaJanela = IntPtr.Zero;

        // Fica escutando a tecla CTRL
        [MTAThread]
        private void OuvirTeclaAtalho()
        {
            while (true)
            {
                short keyState = Api.ApiWin32.GetAsyncKeyState(Api.ApiWin32.VK_CONTROL);
                bool ctrlPressed = (((keyState >> 15) & 0x0001) == 0x0001);
                if (ctrlPressed)
                {
                    Point point = Cursor.Position;
                    IntPtr janela = CapturaJanela(point);

                    if (Control.FromHandle(ultimaJanela) == null)
                    {
                        if (janela != ultimaJanela)
                        {
                            // clear old window
                            MostraRetanguloJanela(ultimaJanela);
                            // set new window
                            ultimaJanela = janela;
                            // paint new window
                            MostraRetanguloJanela(ultimaJanela);
                        }
                        //DisplayWindowInfo(LastWindow);
                    }

                    TssThredInit.Text = "CTRL Pressionado " + ultimaJanela.ToString();
                }
                else
                {
                    // reset all done things from mouse_down and mouse_move ...
                    MostraRetanguloJanela(ultimaJanela);
                    ultimaJanela = IntPtr.Zero;

                    //Cursor = Cursors.Default;
                    //pictureBox.Image = imageList.Images[1];

                    TssThredInit.Text = "Ouvindo Tecla";
                }                
            }
        }

        //
        private IntPtr CapturaJanela(Point point)
        {
            //
            IntPtr janelaInteira = Api.ApiWin32.WindowFromPoint(point);
            if (janelaInteira == IntPtr.Zero)
            {
                return IntPtr.Zero;
            }

            //
            bool janelaParaCliente = Api.ApiWin32.ScreenToClient(janelaInteira, ref point);
            if (janelaParaCliente == false)
            {
                throw new Exception("Falha ao identificar ScreemClient");
            }

            //
            IntPtr janelaFilha = Api.ApiWin32.ChildWindowFromPointEx(janelaInteira, point, 0);
            if (janelaFilha == IntPtr.Zero)
            {
                return janelaInteira;
            }

            //
            bool janelaVisivel = Api.ApiWin32.ClientToScreen(janelaInteira, ref point);
            if (janelaVisivel == false)
            {
                throw new Exception("Falha ao identificar ClientToScreem");
            }

            IntPtr janelaPai = Api.ApiWin32.GetParent(janelaFilha);
            bool ehJanelaFilha = Api.ApiWin32.IsChild(janelaPai, janelaFilha);
            if (ehJanelaFilha == false)
            {
                return janelaFilha;
            }

            //
            ArrayList WindowList = new ArrayList();
            while (janelaFilha != IntPtr.Zero)
            {
                Rectangle rect = Api.ApiWin32.GetWindowRect(janelaFilha);
                if (rect.Contains(point))
                {
                    WindowList.Add(janelaFilha);
                }                   
                janelaFilha = Api.ApiWin32.GetWindow(janelaFilha, (uint)Api.ApiWin32.GetWindow_Cmd.GW_CHILD);
            }

            //
            int MinPixel = Api.ApiWin32.GetSystemMetrics((int)Api.ApiWin32.GetSystem_Metrics.SM_CYFULLSCREEN) * 
                Api.ApiWin32.GetSystemMetrics((int)Api.ApiWin32.GetSystem_Metrics.SM_CXFULLSCREEN);

            //
            for (int i = 0; i < WindowList.Count; ++i)
            {
                Rectangle rect = Api.ApiWin32.GetWindowRect((IntPtr)WindowList[i]);
                int ChildPixel = rect.Width * rect.Height;
                if (ChildPixel < MinPixel)
                {
                    MinPixel = ChildPixel;
                    janelaFilha = (IntPtr)WindowList[i];
                }
            }
            return janelaFilha;
        }

        static void MostraRetanguloJanela(IntPtr window)
        {
            if (window != IntPtr.Zero)
            {
                // 
                Rectangle WindowRect = Api.ApiWin32.GetWindowRect(window);

                // 
                IntPtr dc = Api.ApiWin32.GetWindowDC(window);

                // 
                Api.ApiGdi.SetROP2(dc, (int)Api.ApiGdi.RopMode.R2_NOT);

                //
                Color color = Color.FromArgb(255, 233, 100);
                IntPtr Pen = Api.ApiGdi.CreatePen((int)Api.ApiGdi.PenStyles.PS_INSIDEFRAME, 1 *
                    Api.ApiWin32.GetSystemMetrics((int)Api.ApiWin32.GetSystem_Metrics.SM_CYFULLSCREEN), (uint)color.ToArgb());

                //
                IntPtr OldPen = Api.ApiGdi.SelectObject(dc, Pen);
                IntPtr OldBrush = Api.ApiGdi.SelectObject(dc, Api.ApiGdi.GetStockObject((int)Api.ApiGdi.StockObjects.NULL_BRUSH));
                Api.ApiGdi.Rectangle(dc, 1, 1, WindowRect.Width, WindowRect.Height);

                // 
                Api.ApiGdi.SelectObject(dc, OldBrush);
                Api.ApiGdi.SelectObject(dc, OldPen);

                // 
                Api.ApiWin32.ReleaseDC(window, dc);
                Api.ApiGdi.DeleteObject(Pen);
            }
        }



        // Inicializa programa
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            capThread.Abort();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            capThread = new Thread(OuvirTeclaAtalho);
            capThread.Start();
        }
    }
}