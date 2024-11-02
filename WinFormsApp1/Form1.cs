using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnShowMessage.Click += new EventHandler(btnShowMessage_Click);
            btnOpenNonModal.Click += new EventHandler(btnOpenNonModal_Click);
            btnOpenModal.Click += new EventHandler(btnOpenModal_Click);
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это информационное сообщение", "Информация");
        }
        private void btnOpenNonModal_Click(object sender, EventArgs e)
        {
            NonModalForm nonModalForm = new NonModalForm();
            nonModalForm.Show(); 
        }

        private void btnOpenModal_Click(object sender, EventArgs e)
        {
            ModalForm modalForm = new ModalForm();
            modalForm.ShowDialog(); 
        }
   
    }

}
