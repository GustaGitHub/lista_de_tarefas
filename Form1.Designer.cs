
namespace list_task
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.task_value = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.ListBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira uma nova tarefa:";
            // 
            // task_value
            // 
            this.task_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.task_value.Location = new System.Drawing.Point(44, 58);
            this.task_value.Multiline = true;
            this.task_value.Name = "task_value";
            this.task_value.Size = new System.Drawing.Size(262, 42);
            this.task_value.TabIndex = 1;
            this.task_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Add_Task);
            // 
            // create_btn
            // 
            this.create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(44, 106);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(263, 52);
            this.create_btn.TabIndex = 2;
            this.create_btn.Text = "Adicionar Tarefa";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.Create_task);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delete_btn.Location = new System.Drawing.Point(43, 197);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(266, 52);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Excluir Tarefa";
            this.delete_btn.UseMnemonic = false;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.Delete_Task);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clear_btn.Location = new System.Drawing.Point(44, 315);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(265, 47);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Limpar Lista";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.Clear_List);
            // 
            // tasks
            // 
            this.tasks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tasks.FormattingEnabled = true;
            this.tasks.ItemHeight = 25;
            this.tasks.Location = new System.Drawing.Point(349, 58);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(306, 304);
            this.tasks.TabIndex = 7;
            this.tasks.SelectedValueChanged += new System.EventHandler(this.Display_DeleteBTN);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCount.Location = new System.Drawing.Point(432, 29);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(150, 20);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Total de Tarefas: 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 392);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.task_value);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox task_value;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.ListBox tasks;
        private System.Windows.Forms.Label labelCount;
    }
}

