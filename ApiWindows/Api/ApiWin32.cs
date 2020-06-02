using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ApiWindows.Api
{
    public class ApiWin32
    {
        #region Declaracao de variaveis

        // Declaracao de constantes de teclado
        public const int VK_CONTROL = 0x11;    // Tecla Control

        // Enumerador para identificação do retangulo da tela.
        public struct RECT
        {
            public int Left;   // x posição do canto superior esquerdo
            public int Top;    // y posição do canto superior esquerdo
            public int Right;  // x posição do canto inferior direito
            public int Bottom; // posição do canto inferior direito
            public Rectangle ToRectangle()
            {
                return new Rectangle(Left, Top, Right - Left, Bottom - Top);
            }
        }

        // Enumerador de captura de tela
        public enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,  // Identifica a janela do mesmo tipo que é mais baixa na ordem Z
            GW_HWNDLAST = 1,   // Identifica a janela abaixo da janela especificada na ordem Z
            GW_HWNDNEXT = 2,   // Identifica a janela acima da janela especificada na ordem Z
            GW_HWNDPREV = 3,   // Identifica a janela do proprietário da janela especificada, se houver
            GW_OWNER = 4,      // Identifica a janela filho na parte superior da ordem Z
            GW_CHILD = 5,      // Identifica a janela pop-up ativada pertencente à janela especificada
            GW_ENABLEDPOPUP = 6 // Habilita acesso a popup
        }

        // Enumerador de captura de metricas
        public enum GetSystem_Metrics : int
        {
            SM_CXBORDER = 5,
            SM_CXFULLSCREEN = 16,
            SM_CYFULLSCREEN = 17
        }
        #endregion

        #region Importacao das funcoes da dll

        // Importação de identificação de teclas pressionadas fora da gui
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vKey);

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
         * Recupera o contexto do dispositivo (DC) para toda a janela, 
         * incluindo barra de título, menus e barras de rolagem. 
         */
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        // Recupera quantos caracteres tem a tela
        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        // Recupera o valor do texto da janela
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        //Retorna o nome da classe para o componente especificado.
        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        /* Recupera um identificador para uma janela que possui 
         * o relacionamento especificado (Z-Order ou proprietário) 
         * para a janela especificada.
         */
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        // Capturando o objeto em focus()
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr GetFocus();

        // Captura o retangulo da tela
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        // Recupera várias métricas do sistema de elementos de exibição e definições de configuração do sistema.
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int smIndex);

        // Libera um contexto de dispositivo, liberando-o para uso por outros aplicativos
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hWnd, IntPtr hdc);

        #endregion

        #region Funcoes auxiliares

        // função auxiliar retorna diretamente um objeto Rectangle
        public static Rectangle GetWindowRect(IntPtr hWnd)
        {
            Debug.Assert(hWnd != IntPtr.Zero);
            RECT rect = new RECT();
            if (GetWindowRect(hWnd, ref rect) == false)
                throw new Exception("Falha ao identificar retangulo da tela");
            return rect.ToRectangle();
        }

        // função auxiliar retorna diretamente o texto da tela
        public static string GetWindowText(IntPtr hWnd)
        {
            Debug.Assert(hWnd != IntPtr.Zero);
            StringBuilder WindowText = new StringBuilder(GetWindowTextLength(hWnd) + 1);
            GetWindowText(hWnd, WindowText, WindowText.Capacity);
            return WindowText.ToString();
        }

        // função auxiliar retorna o nome da classe
        public static string GetClassName(IntPtr hWnd)
        {
            StringBuilder ClassName = new StringBuilder(256);
            int ret = GetClassName(hWnd, ClassName, ClassName.Capacity);
            return ClassName.ToString();
        }

        // funcao que captura o objeto em foco
        public Control GetFocusedControl(IntPtr window)
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

        public ApiWin32()
        {

        }
    }
}
