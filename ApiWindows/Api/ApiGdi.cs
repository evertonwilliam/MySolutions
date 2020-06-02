using System;
using System.Runtime.InteropServices;

namespace ApiWindows.Api
{
    public class ApiGdi
    {
        #region Declaracao de constantes
        public enum RopMode : int
        {
            R2_BLACK = 1,
            R2_NOTMERGEPEN = 2,
            R2_MASKNOTPEN = 3,
            R2_NOTCOPYPEN = 4,
            R2_MASKPENNOT = 5,
            R2_NOT = 6,
            R2_XORPEN = 7,
            R2_NOTMASKPEN = 8,
            R2_MASKPEN = 9,
            R2_NOTXORPEN = 10,
            R2_NOP = 11,
            R2_MERGENOTPEN = 12,
            R2_COPYPEN = 13,
            R2_MERGEPENNOT = 14,
            R2_MERGEPEN = 15,
            R2_WHITE = 16
        }

        // identificador da caneta (pen)
        public enum StockObjects : int
        {
            WHITE_BRUSH = 0,
            LTGRAY_BRUSH = 1,
            GRAY_BRUSH = 2,
            DKGRAY_BRUSH = 3,
            BLACK_BRUSH = 4,
            NULL_BRUSH = 5,
            HOLLOW_BRUSH = NULL_BRUSH,
            WHITE_PEN = 6,
            BLACK_PEN = 7,
            NULL_PEN = 8,
            OEM_FIXED_FONT = 10,
            ANSI_FIXED_FONT = 11,
            ANSI_VAR_FONT = 12,
            SYSTEM_FONT = 13,
            DEVICE_DEFAULT_FONT = 14,
            DEFAULT_PALETTE = 15,
            SYSTEM_FIXED_FONT = 16,
            DEFAULT_GUI_FONT = 17,
            DC_BRUSH = 18,
            DC_PEN = 19
        }

        // Defini o estilo da caneta a ser utilizada
        public enum PenStyles : int
        {
            SW_SHOW = 5,
            PS_INSIDEFRAME = 6 //Minimize            
        }
        #endregion

        #region Importacao da biblioteca GDI32
        /*
        * A função SetROP2 define o modo atual de mixagem em primeiro plano. 
        * A GDI usa o modo de mistura em primeiro plano para combinar canetas 
        * e interiores de objetos preenchidos com as cores já exibidas na tela. 
        * O modo de mistura em primeiro plano define como as cores do pincel ou 
        * da caneta e as cores na imagem existente devem ser combinadas.        
        */
        [DllImport("gdi32.dll")]
        public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

        /*
        * A função CreatePen cria uma caneta lógica que possui o estilo, largura e cor especificados. 
        * A caneta pode ser selecionada posteriormente no contexto do dispositivo e usada para desenhar linhas e curvas.
        */
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, uint crColor);

        /*
         *  Seleciona um objeto no contexto de dispositivo especificado (DC). 
         *  O novo objeto substitui o objeto anterior do mesmo tipo
         */
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        // A função GetStockObject recupera um identificador para uma das canetas, pincéis, fontes ou paletas de ações.
        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(int fnObject);

        // A função Retângulo desenha um retângulo. O retângulo é destacado usando a caneta atual e preenchido usando o pincel atual.
        [DllImport("gdi32.dll")]
        public static extern uint Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        /* A função DeleteObject exclui uma caneta, pincel, fonte, bitmap, região ou paleta lógica, 
         * liberando todos os recursos do sistema associados ao objeto. Depois que o objeto é excluído, 
         * o identificador especificado não é mais válido.
         */
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        #endregion

        public ApiGdi()
        {

        }
    }
}
