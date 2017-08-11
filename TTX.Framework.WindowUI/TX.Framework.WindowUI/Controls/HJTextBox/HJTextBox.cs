using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TX.Framework.WindowUI.Controls.HJTextBox
{
    
    [ToolboxBitmap(typeof(TextBox))]
    public partial class HJTextBox : TextBox
    {
        /// <summary>
        /// 是否可拖动
        /// </summary>
        private bool _IsCanDrag = false;
        /// <summary>
        /// 是否移动
        /// </summary>
        private static bool isMouseDown = false;

        #region Properties
        /// <summary>
        /// 是否能够拖拽
        /// </summary>
        [Category("TXProperties")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool IsCanDrag
        {
            get { return this._IsCanDrag; }
            set
            {
                this._IsCanDrag = value;
            }
        }
        #endregion

     

        #region Override methods

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (IsCanDrag && e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsCanDrag && isMouseDown)
            {
                this.Location = this.FindForm().PointToClient(this.PointToScreen(e.Location));
                this.Refresh();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (IsCanDrag && e.Button == MouseButtons.Left)
            {
                if (isMouseDown)
                {
                    this.Refresh();
                    isMouseDown = false;
                }
            }
        }
        #endregion
    }
}
