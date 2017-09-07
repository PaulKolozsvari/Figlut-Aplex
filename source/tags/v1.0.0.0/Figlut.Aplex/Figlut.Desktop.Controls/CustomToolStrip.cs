namespace Figlut.Desktop.Controls
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Drawing.Drawing2D;

    #endregion //Using Directives

    public partial class CustomToolStrip : ToolStrip
    {
        public CustomToolStrip()
        {
            InitializeComponent();
            this.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
        }
    }
}