using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// クリック時の処理です
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionButton_Click(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "クリックされました";

        }

        /// <summary>
        /// マウスが乗ったときの処理です
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionButton_MouseHover(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが乗りました";

        }

        /// <summary>
        /// マウスが外れた時の処理です
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionButton_MouseLeave(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが外れました";

        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}