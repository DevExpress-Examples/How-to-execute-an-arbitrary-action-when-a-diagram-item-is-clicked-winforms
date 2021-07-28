using DevExpress.XtraDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DXSample
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void diagramControl1_Click(object sender, EventArgs e) {
            var clickedItem = diagramControl1.CalcHitItem(((MouseEventArgs)e).Location);
            if (clickedItem is DiagramItem item) {
                MessageBox.Show(owner: this,
                                caption: "An item was clicked",
                                text: $"Item: {item.GetType()}{Environment.NewLine}Position: {item.Position}",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information);
            }
        }
    }
}
