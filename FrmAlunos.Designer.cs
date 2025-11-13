namespace GymSystem
{
    partial class FrmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DgvAlunos = new System.Windows.Forms.DataGridView();
            this.gymSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymSystemDataSet = new GymSystem.GymSystemDataSet();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAlunos
            // 
            this.DgvAlunos.AutoGenerateColumns = false;
            this.DgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlunos.DataSource = this.gymSystemDataSetBindingSource;
            this.DgvAlunos.Location = new System.Drawing.Point(1, 99);
            this.DgvAlunos.Name = "DgvAlunos";
            this.DgvAlunos.Size = new System.Drawing.Size(800, 150);
            this.DgvAlunos.TabIndex = 0;
            // 
            // gymSystemDataSetBindingSource
            // 
            this.gymSystemDataSetBindingSource.DataSource = this.gymSystemDataSet;
            this.gymSystemDataSetBindingSource.Position = 0;
            // 
            // gymSystemDataSet
            // 
            this.gymSystemDataSet.DataSetName = "GymSystemDataSet";
            this.gymSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(82, 72);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 21);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1, -1);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.DgvAlunos);
            this.Name = "FrmAlunos";
            this.Text = "FrmAlunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.DgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlunos_CellDoubleClick);



        }

        #endregion
        private System.Windows.Forms.BindingSource gymSystemDataSetBindingSource;
        private GymSystemDataSet gymSystemDataSet;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView DgvAlunos;
    }
}