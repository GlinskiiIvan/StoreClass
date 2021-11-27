using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreClass
{
    public partial class Form1 : Form
    {

        List<Store_Basic> all = new List<Store_Basic>();

        public abstract class Store_Basic
        {
            protected string name, adress, workSchedule;

            public virtual string Name
            {
                get { return name; }
                set { name = value; }
            }

            public virtual string Adress
            {
                get { return adress; }
                set { adress = value; }
            }

            public virtual string WorkSchedule
            {
                get { return workSchedule; }
                set { workSchedule = value; }
            }

        }

        public class Stall : Store_Basic
        {
            public Stall() { }
            public Stall(string name, string adress, string workSchedule)
            {
                this.name = name;
                this.adress = adress;
                this.workSchedule = workSchedule;
            }
        }

        public class Stall_Pavilion : Stall
        {
            public Stall_Pavilion() { }
            public Stall_Pavilion(string name, string adress, string workSchedule, int numberEmployees) : base(name, adress, workSchedule)
            {
                this.numberEmployees = numberEmployees;
            }

            protected int numberEmployees;

            public int NumberEmployees
            {
                get { return numberEmployees; }
                set { numberEmployees = value; }
            }

        }

        public class Pavilion : Stall_Pavilion
        {
            public Pavilion(string name, string adress, string workSchedule, int numberEmployees, int numberParkingSpaces, string additionalServices) :
                base(name, adress, workSchedule, numberEmployees)
            {
                this.numberParkingSpaces = numberParkingSpaces;
                this.additionalServices = additionalServices;
            }

            private string additionalServices;
            private int numberParkingSpaces;

            public string AdditionalServices
            {
                get { return additionalServices; }
                set { additionalServices = value; }
            }

            public int NumberParkingSpaces
            {
                get { return numberParkingSpaces; }
                set { numberParkingSpaces = value; }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != ""
               && textBox_NumberEmployees.Text != "" && textBox_NumberParkingSpaces.Text != "" && textBox_AdditionalServices.Text != "")
            {
                Pavilion pavilion = new Pavilion(
                    textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text,
                    Int32.Parse(textBox_NumberEmployees.Text), Int32.Parse(textBox_NumberParkingSpaces.Text),
                    textBox_AdditionalServices.Text
                );
            }
            else if (textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != ""
               && textBox_NumberEmployees.Text != "")
            {
                Stall_Pavilion stall_Pavilion = new Stall_Pavilion(textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text,
                    Int32.Parse(textBox_NumberEmployees.Text));
            }
            else if ((textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != ""))
            {
                Stall stall = new Stall(textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text);
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            foreach (var item in all)
            {
                if (item.Adress == textBoxFindAdress.Text)
                {
                    textBox_Answer.Text = "Название: " + item.Name + Environment.NewLine;
                    textBox_Answer.Text += "Адрес: " + item.Adress + Environment.NewLine;
                    textBox_Answer.Text += "График работы: " + item.WorkSchedule + Environment.NewLine;
                    if (item.GetType() == typeof(Stall_Pavilion))
                    {
                        textBox_Answer.Text += "Количество работников: " + ((Stall_Pavilion)item).NumberEmployees + Environment.NewLine;
                    }
                    if (item.GetType() == typeof(Pavilion))
                    {
                        textBox_Answer.Text += "Количество работников: " + ((Pavilion)item).NumberEmployees + Environment.NewLine;
                        textBox_Answer.Text += "Количество парковочных мест: " + ((Pavilion)item).NumberParkingSpaces + Environment.NewLine;
                        textBox_Answer.Text += "Дополнительные услуги: " + ((Pavilion)item).AdditionalServices + Environment.NewLine;

                    }
                }
            }
        }
    }
}