using System.Media;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesdelMapa();
        }

        private void IniciarPersonajes()
        {
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        private void IniciarOpcionesdelMapa()
        {
            labelVida.Text = "Salud ->" +Player.Salud;
            labelEscudo.Text = "Escudo ->" + Player.Escudo;
            labelArma.Text = "Arma ->" + Player.Arma;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
