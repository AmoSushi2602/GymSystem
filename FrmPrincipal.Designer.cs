namespace GymSystem
{
    partial class FrmPrincipal
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
            this.gymSystemDataSet = new GymSystem.GymSystemDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new GymSystem.GymSystemDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new GymSystem.GymSystemDataSetTableAdapters.TableAdapterManager();
            this.alunosTableAdapter = new GymSystem.GymSystemDataSetTableAdapters.AlunosTableAdapter();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroAlunos = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gymSystemDataSet
            // 
            this.gymSystemDataSet.DataSetName = "GymSystemDataSet";
            this.gymSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.gymSystemDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GymSystem.GymSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.gymSystemDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo ao Sistema!";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastroAlunos
            // 
            this.btnCadastroAlunos.Location = new System.Drawing.Point(93, 33);
            this.btnCadastroAlunos.Name = "btnCadastroAlunos";
            this.btnCadastroAlunos.Size = new System.Drawing.Size(114, 23);
            this.btnCadastroAlunos.TabIndex = 2;
            this.btnCadastroAlunos.Text = "Cadastro de Alunos";
            this.btnCadastroAlunos.UseVisualStyleBackColor = true;
            this.btnCadastroAlunos.Click += new System.EventHandler(this.btnCadastroAlunos_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(12, 33);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 3;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnCadastroAlunos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymSystemDataSet gymSystemDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private GymSystemDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private GymSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GymSystemDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastroAlunos;
        private System.Windows.Forms.Button btnAlunos;
    }
}