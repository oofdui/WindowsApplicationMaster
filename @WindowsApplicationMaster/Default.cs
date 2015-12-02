using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _WindowsApplicationMaster
{
    public partial class Default : Form
    {
        #region GlobalVariable
        ToolTip tt = new ToolTip();
        #endregion
        public Default()
        {
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            setDefault();
        }
        private void mnHome_Click(object sender, EventArgs e)
        {
            setMenuActive("mnHome");
            DisposeAllButThis();

            var childForm = new Child();
            childForm.MdiParent = this;
            childForm.Parent = this.pnDefault;
            childForm.Text = "Child Test";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }
        private void mnAboutUs_Click(object sender, EventArgs e)
        {
            setMenuActive("mnAboutUs");
        }
        #region Default
        private void setDefault()
        {
            #region Tooltip
            tt.SetToolTip(btClose, "ปิดโปรแกรม");
            tt.SetToolTip(btMinimize, "ย่อหน้าต่าง");
            tt.SetToolTip(btMaximize, "ขยาย/ลดขนาดหน้าต่าง");
            tt.SetToolTip(btMove, "ย้ายหน้าต่าง");
            #endregion
            setMenuActive("mnHome");
        }
        #endregion
        #region CommondEvent
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion
        #region MoveEvent
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void btMove_MouseDown(object sender, MouseEventArgs e)
        {
            eventMouseDown();
        }
        private void btMove_MouseMove(object sender, MouseEventArgs e)
        {
            eventMouseMove();
        }
        private void btMove_MouseUp(object sender, MouseEventArgs e)
        {
            eventMouseUp();
        }
        private void tbMenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            eventMouseDown();
        }
        private void tbMenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            eventMouseMove();
        }
        private void tbMenuTop_MouseUp(object sender, MouseEventArgs e)
        {
            eventMouseUp();
        }
        private void eventMouseDown()
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void eventMouseMove()
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void eventMouseUp()
        {
            dragging = false;
        }
        #endregion
        #region Function
        private Color getColorSoft(Color color,double amount)
        {
            byte r = (byte)((color.R)+(amount*3));
            byte g = (byte)((color.G)+amount);
            //byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            byte b = (byte)color.B;
            return Color.FromArgb(r, g, b);
        }
        private IEnumerable<Control> getAllControls(Control control,Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(
                ctrl => getAllControls(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }
        private void setMenuActive(string Name)
        {
            var controls = getAllControls(this, typeof(Button));
            foreach(var control in controls)
            {
                var mn = (Button)control;
                if (mn.Name.Contains("mn"))
                {
                    if (mn.Name == Name)
                    {
                        mn.BackColor = ColorTranslator.FromHtml("#FFF");
                        mn.ForeColor = ColorTranslator.FromHtml("#000");
                    }
                    else
                    {
                        mn.BackColor = getColorSoft(ColorTranslator.FromHtml("#00A2E8"), 50);
                        mn.ForeColor = ColorTranslator.FromHtml("#484848");
                    }
                }
            }
        }
        public void DisposeAllButThis()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        #endregion
    }
}
