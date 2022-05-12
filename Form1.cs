using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_task
{
    public partial class Main : Form
    {
        public int countTasks = 0;
        public Main()
        {
            InitializeComponent();
            labelCount.Text = $"Total de Tarefas: {countTasks}";
        }

        //  Helpers //
        public void Add_Task(string taskValue)
        {
            if (taskValue.Length == 0)
            {
                MessageBox.Show("Digite uma tarefa");
            }
            else
            {
                tasks.Items.Add($"- {taskValue}");
                task_value.Text = "";
                labelCount.Text = $"Total de Tarefas: {++countTasks}";
            }
        }

        //  Events Functions //
        private void Create_task(object sender, EventArgs e)
        {
            Add_Task(task_value.Text);
        }

        private void Enter_Add_Task(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_Task(task_value.Text);
            }
        }

        private void Delete_Task(object sender, EventArgs e)
        {
            if (tasks.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma tarefa para excluir");
            }
            else
            {
                tasks.Items.Remove(tasks.SelectedItem);
                labelCount.Text = $"Total de Tarefas: {--countTasks}";
            }
        }

        private void Display_DeleteBTN(object sender, EventArgs e)
        {
            if(tasks.SelectedItem != null)
            {
                delete_btn.Visible = true;
            }
            else if(tasks.Items.Count == 0)
            {
                delete_btn.Visible = false;
            }
        }

        private void Clear_List(object sender, EventArgs e)
        {
            tasks.Items.Clear();
            delete_btn.Visible = false;
            countTasks = 0;
            labelCount.Text = $"Total de Tarefas: {countTasks}";
        }

    }
}
