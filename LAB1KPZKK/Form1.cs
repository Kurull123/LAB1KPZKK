using ZooLibrary;
namespace LAB1KPZKK
{
    public partial class Form1 : Form
    {
        AbstractZooFactory factory;
        Predator predator;
        Herbivore herbivore;
        Bird bird;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    factory = new AfricanZooFactory();
                    break;

                case 1:
                    factory = new ArcticZooFactory();
                    break;

                case 2:
                    factory = new AustralianZooFactory();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                predator = factory.createPredator();

                MessageBox.Show(predator.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                herbivore = factory.createHerbivore();

                MessageBox.Show(herbivore.GetInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (factory != null)
            {
                bird = factory.createBird();

                MessageBox.Show(bird.GetInfo());
            }
        }
    }
}
