using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petSim
{
    public partial class Form1 : Form
    {
        private System.Drawing.Image[] images;
        public Form1()
        {
            InitializeComponent();
            LoadImages();
            DisplayImages();
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void LoadImages()
        {
            // Initialize the array with the number of images you want to load
            images = new System.Drawing.Image[7];

            // Load images from the project resources or file paths
            images[0] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\normal.png");//normal
            images[1] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\dirty.png");//dirty
            images[2] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\dirty hungry.png");//dirty&hungry
            images[3] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\hungry.png");//hungry 
            images[4] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\sad.png");//sad
            images[5] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\sad hungry (2).png");//Sad & hungry
            images[6] = System.Drawing.Image.FromFile("C:\\Users\\dlfnl\\OneDrive\\Desktop\\PetSim\\petSim\\petSim\\Resources\\sad drity hungry.png"); // sad& hungry&Dirty
        }
        private void DisplayImages()
        {
            pictureBox1.Image = images[0];
        }

       
    }
}
