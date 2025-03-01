using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private string placeholderText = "Digite aqui sua tarefa...";
        public Form1()
        {
            InitializeComponent();

            txtTask.Text = placeholderText;
            txtTask.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtTask_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                txtTask.Text = placeholderText;
                txtTask.ForeColor = Color.Gray;
            }
        }

        private void txtTask_Enter(object sender, EventArgs e)
        {
            if (txtTask.Text == placeholderText)
            {
                txtTask.Text = "";
                txtTask.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                lstTasks.Items.Add(task);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa para adicionar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
