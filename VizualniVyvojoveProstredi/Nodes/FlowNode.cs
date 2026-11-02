using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizualniVyvojoveProstredi
{
    // Říká, jestli blok leží v levém menu (true) nebo na plátně (false)
    //public bool JeVPalete { get; set; } = false;

    // Které slovo se má přenést při tahání (abychom měli univerzální blok)
    //public string TypBloku { get; set; } = "START";
    public partial class FlowNode : UserControl
    {
        private bool isDragging = false;
        private Point mouseGrabPoint;

        public FlowNode()
        {
            InitializeComponent();

            label1.MouseDown += HoldDown;
            label1.MouseMove += Move;
            label1.MouseUp += Release;
        }

        private void HoldDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseGrabPoint = e.Location; // Zapamatujeme si, kde přesně jsme blok chytili
                this.BringToFront();         // Dáme ho do popředí, aby při tahání překrýval ostatní
            }
        }

        private void Move(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Přepočítáme pozici bloku vůči plátnu
                this.Left = this.Left + (e.X - mouseGrabPoint.X);
                this.Top = this.Top + (e.Y - mouseGrabPoint.Y);
            }
        }

        private void Release(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        public string FlowNodeText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
