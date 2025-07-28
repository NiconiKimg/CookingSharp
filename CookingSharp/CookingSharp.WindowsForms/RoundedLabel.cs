using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CookingSharp.WindowsForms
{
    public class RoundedLabel : Label
    {
        #region -> Campos Privados

        private int borderSize = 0;
        private int borderRadius = 10;
        private Color borderColor = Color.Gainsboro;

        #endregion

        #region -> Propiedades Públicas Personalizadas

        [Category("Cooking# - Avanzado")]
        [Description("Establece o recupera el grosor del borde del control.")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate(); // Vuelve a dibujar el control para reflejar el cambio.
            }
        }

        [Category("Cooking# - Avanzado")]
        [Description("Establece o recupera el radio de las esquinas del control.")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                // Validación para asegurar que el radio no sea negativo.
                borderRadius = (value >= 0) ? value : 0;
                this.Invalidate();
            }
        }

        [Category("Cooking# - Avanzado")]
        [Description("Establece o recupera el color del borde del control.")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Cooking# - Avanzado")]
        [Description("Establece o recupera el color de fondo del control.")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        [Category("Cooking# - Avanzado")]
        [Description("Establece o recupera el color del texto del control.")]
        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;
        }

        #endregion

        #region -> Constructor

        public RoundedLabel()
        {
            // Inicialización de propiedades para un comportamiento óptimo.
            this.DoubleBuffered = true; // Reduce el parpadeo durante el redibujado.
            this.AutoSize = false; // Desactivamos AutoSize para tener control total sobre el tamaño.

            // Suscripción a eventos para un comportamiento dinámico.
            this.Resize += new EventHandler(Label_Resize);
        }

        #endregion

        #region -> Métodos de Dibujado (Overrides)

        protected override void OnPaint(PaintEventArgs e)
        {
            // Omitimos la llamada base.OnPaint(e) para tomar control total del dibujado
            // y evitar que se pinte el fondo rectangular del Label estándar.

            // Configuramos la calidad del gráfico para obtener bordes suaves.
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Definimos los rectángulos para la superficie y el borde.
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            // Dibujamos la forma redondeada.
            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2)) // Para suavizar los bordes
                using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                {
                    // Recortamos el área visible del control a nuestra forma redondeada.
                    this.Region = new Region(pathSurface);

                    // Dibujamos el fondo del control.
                    e.Graphics.FillPath(brushSurface, pathSurface);

                    // Dibujamos el borde si tiene un grosor definido.
                    if (BorderSize > 0)
                    {
                        using (Pen penBorder = new Pen(BorderColor, BorderSize))
                        {
                            e.Graphics.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }
            else // Si no hay radio, dibuja un rectángulo normal.
            {
                this.Region = new Region(rectSurface);
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            // Finalmente, dibujamos el texto sobre nuestro fondo personalizado.
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, flags);
        }

        #endregion

        #region -> Métodos Privados y Manejadores de Eventos

        /// <summary>
        /// Se dispara cuando el control cambia de tamaño. Asegura que el radio
        /// no sea más grande que las dimensiones del propio control.
        /// </summary>
        private void Label_Resize(object sender, EventArgs e)
        {
            int smallerDimension = this.Width < this.Height ? this.Width : this.Height;
            if (borderRadius > smallerDimension / 2)
            {
                BorderRadius = smallerDimension / 2;
            }
        }

        /// <summary>
        /// Crea un objeto GraphicsPath que representa la forma de un rectángulo redondeado.
        /// </summary>
        /// <param name="rect">El rectángulo base.</param>
        /// <param name="radius">El radio de las esquinas.</param>
        /// <returns>Un GraphicsPath con la forma redondeada.</returns>
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            // Evita un radio demasiado grande que cause errores gráficos.
            float curveSize = Math.Max(0, radius * 2);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        #endregion
    }
}