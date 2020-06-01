using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ApiWindows
{
    public partial class FPrincipal : Form
    {
        #region INIT PROGRAM
        public FPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region IMPORTACAO WIN32 WINDOWS API

        /*
        * FUNCAO QUE IDENTIFICA UMA TECLA PRESSIONADA FORA DA GUI
        */
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetAsyncKeyState(int vKey);
        
        private const int VK_CONTROL = 0x11;    // ESC
        
        // Recupera uma alça na janela que contém o ponto especificado.
        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point point);

        // A função ScreenToClient converte as coordenadas de tela 
        // de um ponto especificado na tela para coordenadas da área do cliente
        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref Point point);

        // Determina qual, se houver, das janelas da criança pertencentes à janela pai especificada
        [DllImport("user32.dll")]
        public static extern IntPtr ChildWindowFromPointEx(IntPtr hWndParent, Point pt, uint uFlags);

        // A função ClientToScreen converte as coordenadas da área do cliente de um ponto especificado 
        // para coordenadas de tela
        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hwnd, ref Point lpPoint);

        // Retorna o objeto pai do objeto especificado processando a árvore lógica
        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        // Determina se uma janela é uma janela filho ou uma janela descendente de uma janela de pai especificada.
        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        /*
         * GW_HWNDFIRST = 0 - identificador recuperado identifica a janela do mesmo tipo que é mais baixa na ordem Z
         * GW_HWNDLAST = 1 - O identificador recuperado identifica a janela abaixo da janela especificada na ordem Z
         * GW_HWNDNEXT = 2 - O identificador recuperado identifica a janela acima da janela especificada na ordem Z
         * GW_HWNDPREV = 3 - O identificador recuperado identifica a janela do proprietário da janela especificada, se houver
         * GW_OWNER = 4 - O identificador recuperado identifica a janela filho na parte superior da ordem Z
         * GW_CHILD = 5 - O identificador recuperado identifica a janela pop-up ativada pertencente à janela especificada 
         * GW_ENABLEDPOPUP = 6 - Habilita acesso a popup
         */
        public enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }
        /* Recupera um identificador para uma janela que possui o relacionamento especificado (Z-Order ou proprietário) 
         *para a janela especificada.
         */
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        /*
         * public int Left; // x posição do canto superior esquerdo
         * public int Top; // y posição do canto superior esquerdo
         * public int Right; // x posição do canto inferior direito
         * public int Bottom; // posição do canto inferior direito
         */
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public Rectangle ToRectangle()
            {
                return new Rectangle(Left, Top, Right - Left, Bottom - Top);
            }
        }
        // Captura o retangulo da tela
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        // função auxiliar retorna diretamente um objeto Rectangle
        public static Rectangle GetWindowRect(IntPtr hWnd)
        {
            Debug.Assert(hWnd != IntPtr.Zero);
            RECT rect = new RECT();
            if (GetWindowRect(hWnd, ref rect) == false)
                throw new Exception("Falha ao Acessar Tela");
            return rect.ToRectangle();
        }

        /*
         * A função GetWindowDC recupera o contexto do dispositivo (DC) para toda a janela, 
         * incluindo barra de título, menus e barras de rolagem. 
         * Um contexto de dispositivo de janela permite pintar em qualquer lugar de uma janela, 
         * porque a origem do contexto do dispositivo é o canto superior esquerdo da janela 
         * em vez da área do cliente. GetWindowDC atribui atributos padrão ao contexto 
         * do dispositivo de janela cada vez que recupera o contexto do dispositivo. 
         * Atributos anteriores são perdidos.
         */
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        /*
         * recupera quantos caracteres tem a tela
         */
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        /*
         * recupera o valor do texto da janela
         */
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        // função auxiliar retorna diretamente o texto da tela
        public static string GetWindowText(IntPtr hWnd)
        {
            Debug.Assert(hWnd != IntPtr.Zero);
            StringBuilder WindowText = new StringBuilder(GetWindowTextLength(hWnd) + 1);
            GetWindowText(hWnd, WindowText, WindowText.Capacity);
            return WindowText.ToString();
        }

        /*
         * Retorna o nome da classe para o componente especificado.
         */
        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        // função auxiliar retorna o nome da classe
        public static string GetClassName(IntPtr hWnd)
        {
            StringBuilder ClassName = new StringBuilder(256);
            int ret = GetClassName(hWnd, ClassName, ClassName.Capacity);
            return ClassName.ToString();
        }

        /*
         * Libera um contexto de dispositivo, liberando-o para uso por outros aplicativos
         */
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hWnd, IntPtr hdc);

        /*
         * Capturando o objeto em focus()
         */
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr GetFocus();

        private Control GetFocusedControl(IntPtr window)
        {
            Control focusedControl;
            window = GetFocus();
            focusedControl = null;

            if (window != IntPtr.Zero)
            {
                focusedControl = Control.FromHandle(window);
                return focusedControl;
            }
            return focusedControl;
        }

        #endregion

        #region IMPORTACAO GDI WINDOWS API
        // IMPLEMENTATION
        #endregion

        #region EVENTOS DA TELA

        public void Screen()
        {
            #region utilizando as funcoes win32

            Point point = Cursor.Position;
            IntPtr windowPoint = WindowFromPoint(point); // Posição da tela.
            bool screemToClient = ScreenToClient(windowPoint, ref point); // Tela para Cliente?
            IntPtr window = ChildWindowFromPointEx(windowPoint, point, 0);
            bool clientToScreem = ClientToScreen(windowPoint, ref point);
            IntPtr parentWindow = GetParent(window);
            bool isChild = IsChild(parentWindow, window);
            IntPtr newWindow = GetWindow(window, (uint)GetWindow_Cmd.GW_HWNDNEXT);
            var rectangle = GetWindowRect(window);
            IntPtr dc = GetWindowDC(window);
            int length = GetWindowTextLength(window);
            string textWindow = GetWindowText(window);
            string className = GetClassName(window);
            Control focus = GetFocusedControl(newWindow);


            // AMBIENTE VISUAL
            TxtMousePosition.Text = point.ToString();
            TxtWindowPoint.Text = windowPoint.ToString();
            TxtScreemToClient.Text = screemToClient.ToString();
            TxtWindow.Text = window.ToString();
            TxtClientToScreem.Text = clientToScreem.ToString();
            TxtParentWindow.Text = parentWindow.ToString();
            TxtIsChild.Text = isChild.ToString();
            TxtGetWindow.Text = newWindow.ToString();
            TxtRectangle.Text = rectangle.ToString();
            TxtContextoDC.Text = dc.ToString();
            TxtLenght.Text = length.ToString();
            txtTextWindow.Text = textWindow;
            TxtClassName.Text = className;
            TxtControlFocus.Text = focus.Name;

            #endregion



            // libere o contexto do dispositivo e destrua a caneta
            ReleaseDC(window, dc);

        }

        // CLICAR EM SAIR
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // AO PRESSIONAR A TELA CTRL
        private void FPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                Screen();
            }*/
        }

        // Ao soltar a tecla CTRL
        private void FPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            // libere o contexto do dispositivo e destrua a caneta
            //ReleaseDC(window, dc);
        }

        private void TListemKey_Tick(object sender, EventArgs e)
        {
            short keyState = GetAsyncKeyState(VK_CONTROL);
            bool ctrlIsPressed = ((keyState >> 15) & 0x0001) == 0x0001;
            //bool escUnProcessedPress = ((keyState >> 0) & 0x0001) == 0x0001;

            if (ctrlIsPressed)
            {
                Screen();
            }
        }

        #endregion


    }
}
