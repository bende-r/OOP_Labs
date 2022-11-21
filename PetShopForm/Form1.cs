using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetsLibrary;
using ConsoleApp1;

namespace PetShopForm
{
    //    struct Pet
    //    {
    //        public string Name;
    //        public string Skin;
    //        public string Detention;

    //        public Pet(string name, string skin, string det)
    //        {
    //            Name = name; Skin = skin; Detention = det;  
    //        }
    //    }

    public partial class Form1 : Form
    {
        string skin, name, detention;

        string str;

        //  List<Pet> list = new List<Pet>();

        List<PetType> pets = new List<PetType>();

        public Form1()
        {
            InitializeComponent();
        }

        private void NameOfPet_TextChanged(object sender, EventArgs e)
        {

        }



        private void Add_Click(object sender, EventArgs e)
        {
            name = NameOfPet.Text;
            PetType petType = new PetType(name, skin, detention);


            pets.Add(petType);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //  name = NameOfPet.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < pets.Count; i++)
            {
                sb.Append(pets[i].ToString() + "\n");
            }

            form.txt = sb.ToString();
            form.ShowDialog();

            sb.Clear();
        }

        //по месту содержания
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            StringBuilder sb = new StringBuilder();

            sb.Append("Клетка ");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Detention == "Клетка")
                    sb.Append(pets[i].Name + "\n");
            }

            sb.Append("Аквариум");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Detention == "Аквариум")
                    sb.Append(pets[i].Name + "\n");
            }
            sb.Append("Террариум");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Detention == "Террариум")
                    sb.Append(pets[i].Name + "\n");
            }

            form.txt = sb.ToString();
            form.ShowDialog();

            sb.Clear();
        }

        //по типу покрова
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            StringBuilder sb = new StringBuilder();

            sb.Append("Шерсть ");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Skin == "Шерсть")
                    sb.Append(pets[i].Name + "\n");
            }

            sb.Append("Чешуя");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Skin == "Чешуя")
                    sb.Append(pets[i].Name + "\n");
            }
            sb.Append("Перья");

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Skin == "Перья")
                    sb.Append(pets[i].Name + "\n");
            }

            form.txt = sb.ToString();
            form.ShowDialog();

            sb.Clear();
        }

        //по наименованию
        private void button4_Click(object sender, EventArgs e)
        {
            string nametofind = NameToFind.Text;
            int count = 0;
            Form2 form = new Form2();
            StringBuilder sb = new StringBuilder();



            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Name == nametofind)
                    count++;
            }
            sb.Append(nametofind + ": " + count);

            form.txt = sb.ToString();
            form.ShowDialog();

            sb.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wool_Click(object sender, EventArgs e)
        {
            skin = "Шерсть";
        }

        private void Wool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                skin = "Шерсть";
        }

        private void Feathers_Click(object sender, EventArgs e)
        {
            skin = "Перья";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                skin = "Перья";
        }

        private void Scales_Click(object sender, EventArgs e)
        {
            skin = "Чешуя";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                skin = "Чешуя";
        }

        private void Cell_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                detention = "Клетка";
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            detention = "Клетка";
        }

        private void Aquarium_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                detention = "Аквариум";
        }

        private void Aquarium_Click(object sender, EventArgs e)
        {
            detention = "Аквариум";
        }



        private void Terrarium_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
                detention = "Террариум";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Terrarium_Click(object sender, EventArgs e)
        {
            detention = "Террариум";
        }
    }
}
