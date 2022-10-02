namespace Grafos1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.insertarVertButton = new System.Windows.Forms.Button();
            this.textBoxVerNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comborigen = new System.Windows.Forms.ComboBox();
            this.combostino = new System.Windows.Forms.ComboBox();
            this.insertarArcButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.borrarArcButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.recorridosCombo = new System.Windows.Forms.ComboBox();
            this.resultadolabel = new System.Windows.Forms.Label();
            this.nomVertice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arcos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertarVertButton
            // 
            this.insertarVertButton.Location = new System.Drawing.Point(12, 53);
            this.insertarVertButton.Name = "insertarVertButton";
            this.insertarVertButton.Size = new System.Drawing.Size(100, 23);
            this.insertarVertButton.TabIndex = 3;
            this.insertarVertButton.Text = "Insertar nodo";
            this.insertarVertButton.UseVisualStyleBackColor = true;
            this.insertarVertButton.Click += new System.EventHandler(this.insertarVertButton_Click);
            // 
            // textBoxVerNom
            // 
            this.textBoxVerNom.Location = new System.Drawing.Point(12, 26);
            this.textBoxVerNom.Name = "textBoxVerNom";
            this.textBoxVerNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerNom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomVertice,
            this.arcos});
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destino";
            // 
            // comborigen
            // 
            this.comborigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborigen.FormattingEnabled = true;
            this.comborigen.Location = new System.Drawing.Point(170, 26);
            this.comborigen.Name = "comborigen";
            this.comborigen.Size = new System.Drawing.Size(64, 21);
            this.comborigen.TabIndex = 2;
            // 
            // combostino
            // 
            this.combostino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostino.FormattingEnabled = true;
            this.combostino.Location = new System.Drawing.Point(240, 25);
            this.combostino.Name = "combostino";
            this.combostino.Size = new System.Drawing.Size(64, 21);
            this.combostino.TabIndex = 3;
            // 
            // insertarArcButton
            // 
            this.insertarArcButton.Location = new System.Drawing.Point(170, 53);
            this.insertarArcButton.Name = "insertarArcButton";
            this.insertarArcButton.Size = new System.Drawing.Size(100, 23);
            this.insertarArcButton.TabIndex = 4;
            this.insertarArcButton.Text = "Enlazar";
            this.insertarArcButton.UseVisualStyleBackColor = true;
            this.insertarArcButton.Click += new System.EventHandler(this.insertarArcButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 262);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(47, 38);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // borrarArcButton
            // 
            this.borrarArcButton.Location = new System.Drawing.Point(170, 82);
            this.borrarArcButton.Name = "borrarArcButton";
            this.borrarArcButton.Size = new System.Drawing.Size(100, 23);
            this.borrarArcButton.TabIndex = 6;
            this.borrarArcButton.Text = "Borrar enlace";
            this.borrarArcButton.UseVisualStyleBackColor = true;
            this.borrarArcButton.Click += new System.EventHandler(this.borrarArcButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recorrer:";
            // 
            // recorridosCombo
            // 
            this.recorridosCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recorridosCombo.FormattingEnabled = true;
            this.recorridosCombo.Items.AddRange(new object[] {
            "Por profundidad",
            "Por anchura"});
            this.recorridosCombo.Location = new System.Drawing.Point(170, 128);
            this.recorridosCombo.Name = "recorridosCombo";
            this.recorridosCombo.Size = new System.Drawing.Size(100, 21);
            this.recorridosCombo.TabIndex = 8;
            this.recorridosCombo.SelectedIndexChanged += new System.EventHandler(this.recorridosCombo_SelectedIndexChanged);
            // 
            // resultadolabel
            // 
            this.resultadolabel.AutoSize = true;
            this.resultadolabel.Location = new System.Drawing.Point(170, 156);
            this.resultadolabel.Name = "resultadolabel";
            this.resultadolabel.Size = new System.Drawing.Size(0, 13);
            this.resultadolabel.TabIndex = 9;
            // 
            // nomVertice
            // 
            this.nomVertice.HeaderText = "Vértice:";
            this.nomVertice.Name = "nomVertice";
            this.nomVertice.ReadOnly = true;
            // 
            // arcos
            // 
            this.arcos.HeaderText = "Enlazado a:";
            this.arcos.Name = "arcos";
            this.arcos.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.resultadolabel);
            this.Controls.Add(this.recorridosCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.borrarArcButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.insertarArcButton);
            this.Controls.Add(this.insertarVertButton);
            this.Controls.Add(this.combostino);
            this.Controls.Add(this.textBoxVerNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comborigen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Super Grafos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertarVertButton;
        private System.Windows.Forms.TextBox textBoxVerNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comborigen;
        private System.Windows.Forms.ComboBox combostino;
        private System.Windows.Forms.Button insertarArcButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button borrarArcButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox recorridosCombo;
        private System.Windows.Forms.Label resultadolabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVertice;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcos;

    }
}

