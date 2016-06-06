namespace Preparatoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.textsemestre = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.rBagregar = new System.Windows.Forms.RadioButton();
            this.rBeliminar = new System.Windows.Forms.RadioButton();
            this.rBcalificaciones = new System.Windows.Forms.RadioButton();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rBbuscar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(83, 30);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(134, 22);
            this.tB1.TabIndex = 3;
            // 
            // textsemestre
            // 
            this.textsemestre.Location = new System.Drawing.Point(83, 75);
            this.textsemestre.Name = "textsemestre";
            this.textsemestre.Size = new System.Drawing.Size(100, 22);
            this.textsemestre.TabIndex = 4;
            this.textsemestre.TextChanged += new System.EventHandler(this.textsemestre_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(299, 25);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(246, 22);
            this.textnombre.TabIndex = 5;
            // 
            // rBagregar
            // 
            this.rBagregar.AutoSize = true;
            this.rBagregar.Location = new System.Drawing.Point(12, 186);
            this.rBagregar.Name = "rBagregar";
            this.rBagregar.Size = new System.Drawing.Size(80, 21);
            this.rBagregar.TabIndex = 6;
            this.rBagregar.TabStop = true;
            this.rBagregar.Text = "Agregar";
            this.rBagregar.UseVisualStyleBackColor = true;
            this.rBagregar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBeliminar
            // 
            this.rBeliminar.AutoSize = true;
            this.rBeliminar.Location = new System.Drawing.Point(12, 240);
            this.rBeliminar.Name = "rBeliminar";
            this.rBeliminar.Size = new System.Drawing.Size(79, 21);
            this.rBeliminar.TabIndex = 8;
            this.rBeliminar.TabStop = true;
            this.rBeliminar.Text = "Eliminar";
            this.rBeliminar.UseVisualStyleBackColor = true;
            this.rBeliminar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rBcalificaciones
            // 
            this.rBcalificaciones.AutoSize = true;
            this.rBcalificaciones.Location = new System.Drawing.Point(12, 289);
            this.rBcalificaciones.Name = "rBcalificaciones";
            this.rBcalificaciones.Size = new System.Drawing.Size(115, 21);
            this.rBcalificaciones.TabIndex = 9;
            this.rBcalificaciones.TabStop = true;
            this.rBcalificaciones.Text = "Calificaciones";
            this.rBcalificaciones.UseVisualStyleBackColor = true;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(152, 139);
            this.dGV.Name = "dGV";
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(393, 185);
            this.dGV.TabIndex = 10;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_RowHeaderMouseDoubleClick);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(387, 75);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(98, 55);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rBbuscar
            // 
            this.rBbuscar.AutoSize = true;
            this.rBbuscar.Location = new System.Drawing.Point(15, 139);
            this.rBbuscar.Name = "rBbuscar";
            this.rBbuscar.Size = new System.Drawing.Size(73, 21);
            this.rBbuscar.TabIndex = 12;
            this.rBbuscar.TabStop = true;
            this.rBbuscar.Text = "Buscar";
            this.rBbuscar.UseVisualStyleBackColor = true;
            this.rBbuscar.CheckedChanged += new System.EventHandler(this.rBbuscar_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 345);
            this.Controls.Add(this.rBbuscar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.rBcalificaciones);
            this.Controls.Add(this.rBeliminar);
            this.Controls.Add(this.rBagregar);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textsemestre);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alumnos ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox textsemestre;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.RadioButton rBagregar;
        private System.Windows.Forms.RadioButton rBeliminar;
        private System.Windows.Forms.RadioButton rBcalificaciones;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rBbuscar;
    }
}

