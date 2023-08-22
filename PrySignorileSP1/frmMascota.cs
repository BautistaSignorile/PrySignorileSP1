using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySignorileSP1
{
    public partial class frmMascota : Form
    {
        public frmMascota()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PictureBox Akita = new PictureBox();
            PictureBox Boxer = new PictureBox();
            PictureBox Gato = new PictureBox();

            Akita.Image = Properties.Resources.akita;
            Akita.SizeMode = PictureBoxSizeMode.StretchImage;
            Akita.Location = new Point(100,160);

            Boxer.Image = Properties.Resources.boxer;
            Boxer.SizeMode = PictureBoxSizeMode.StretchImage;
            Boxer.Location = new Point(0, 160);

            Gato.Image = Properties.Resources.gato;
            Gato.SizeMode = PictureBoxSizeMode.StretchImage;
            Gato.Location = new Point(200, 160);

            Controls.Add(Akita);
            Controls.Add(Gato);
            Controls.Add(Boxer);
        }
    }
}
