namespace Colour_Rain_Effect_Windows_Form_MOO_ICT
{
    public partial class Form1 : Form
    {


    // created by mooict.com 2022
    // educational purpose only

        List<string> files = new List<string>();
        List<Particles> particles = new List<Particles>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            LoadImages();   
        }

        private void LoadImages()
        {
            files = Directory.GetFiles("images", "*.png").ToList();

            for (int i = 0; i < 400; i++)
            {
                Particles new_particle = new Particles(files[random.Next(0, files.Count)]);

                particles.Add(new_particle);
            }
        }

        private void ParticleTimerEvent(object sender, EventArgs e)
        {
            foreach (Particles tempImage in particles.ToList())
            {
                tempImage.posY += tempImage.speed;

                tempImage.posX += 8;

                if (tempImage.posY > this.ClientSize.Height + 100)
                {
                    tempImage.speed = random.Next(5, 15);

                    tempImage.posY = -100;

                    tempImage.posX = random.Next(-200, 600);
                }

            }

            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            foreach (Particles tempImage in particles.ToList())
            {
                Canvas.DrawImage(tempImage.particle, tempImage.posX, tempImage.posY, tempImage.width, tempImage.height);
            }


        }
    }
}