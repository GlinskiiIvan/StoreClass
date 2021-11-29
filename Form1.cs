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

        List<BasicStore> allStore = new List<BasicStore>();

        public abstract class BasicStore
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

        public class Stall : BasicStore
        {
            public Stall() { }
            public Stall(string name, string adress, string workSchedule)
            {
                this.name = name;
                this.adress = adress;
                this.workSchedule = workSchedule;
            }
        }

        public class StallPavilion : Stall
        {
            public StallPavilion() { }
            public StallPavilion(string name, string adress, string workSchedule, string delivery) : base(name, adress, workSchedule)
            {
                this.delivery = delivery;
            }

            protected string delivery;

            public string Delivery
            {
                get { return delivery; }
                set { delivery = value; }
            }

        }

        public class Pavilion : StallPavilion
        {
            public Pavilion(string name, string adress, string workSchedule, string delivery, int numberRooms) :
                base(name, adress, workSchedule, delivery)
            {
                this.numberRooms = numberRooms;
            }

            private int numberRooms;

            public int NumberRooms
            {
                get { return numberRooms; }
                set { numberRooms = value; }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != "" && textBox_Delivery.Text != "" && textBox_NumberRooms.Text != "")
            {
                Pavilion pavilion = new Pavilion( textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text, textBox_Delivery.Text, Int32.Parse(textBox_NumberRooms.Text) );
                allStore.Add(pavilion);
            }
            else if (textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != "" && textBox_Delivery.Text != "")
            {
                StallPavilion stall_Pavilion = new StallPavilion(textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text, textBox_Delivery.Text);
                allStore.Add(stall_Pavilion);
            }
            else if ((textBox_Name.Text != "" && textBox_Adress.Text != "" && textBox_WorkSchedule.Text != ""))
            {
                Stall stall = new Stall(textBox_Name.Text, textBox_Adress.Text, textBox_WorkSchedule.Text);
                allStore.Add(stall);
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            foreach (var item in allStore)
            {
                if (item.Adress == textBoxFindAdress.Text)
                {
                    textBox_Answer.Text = "Название - " + item.Name + Environment.NewLine;
                    textBox_Answer.Text += "Адрес - " + item.Adress + Environment.NewLine;
                    textBox_Answer.Text += "График работы - " + item.WorkSchedule + Environment.NewLine;
                    if (item.GetType() == typeof(StallPavilion))
                    {
                        textBox_Answer.Text += "Доставка - " + ((StallPavilion)item).Delivery + Environment.NewLine;
                    }
                    if (item.GetType() == typeof(Pavilion))
                    {
                        textBox_Answer.Text += "Доставка - " + ((Pavilion)item).Delivery + Environment.NewLine;
                        textBox_Answer.Text += "Количество комнат - " + ((Pavilion)item).NumberRooms + Environment.NewLine;

                    }
                }
            }
        }
    }
}