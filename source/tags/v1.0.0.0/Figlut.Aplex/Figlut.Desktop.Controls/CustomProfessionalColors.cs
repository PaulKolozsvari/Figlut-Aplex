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

    public class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.WhiteSmoke; } }

        public override Color ToolStripGradientMiddle
        { get { return Color.LightGray; } }

        public override Color ToolStripGradientEnd
        { get { return Color.WhiteSmoke; } }

        public override Color MenuStripGradientBegin
        { get { return Color.DarkGray; } }

        public override Color MenuStripGradientEnd
        { get { return Color.DarkGray; } }
    }
}