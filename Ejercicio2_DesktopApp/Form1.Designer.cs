namespace Ejercicio2_DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportarPaquetesPedidos = new Button();
            groupBox1 = new GroupBox();
            listBz3 = new ListBox();
            listBz2 = new ListBox();
            listBz1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cBoxCamiones = new ComboBox();
            tBkg = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            listBcargas = new ListBox();
            btnRetirar = new Button();
            btnAgregar = new Button();
            btnEnviar = new Button();
            btnIniciar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnImportarPaquetesPedidos
            // 
            btnImportarPaquetesPedidos.Location = new Point(393, 58);
            btnImportarPaquetesPedidos.Name = "btnImportarPaquetesPedidos";
            btnImportarPaquetesPedidos.Size = new Size(104, 94);
            btnImportarPaquetesPedidos.TabIndex = 0;
            btnImportarPaquetesPedidos.Text = "Importar Paquetes Pedidos";
            btnImportarPaquetesPedidos.UseVisualStyleBackColor = true;
            btnImportarPaquetesPedidos.Click += btnImportarPaquetesPedidos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBz3);
            groupBox1.Controls.Add(listBz2);
            groupBox1.Controls.Add(listBz1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnImportarPaquetesPedidos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despositos";
            // 
            // listBz3
            // 
            listBz3.FormattingEnabled = true;
            listBz3.ItemHeight = 15;
            listBz3.Location = new Point(267, 58);
            listBz3.Name = "listBz3";
            listBz3.Size = new Size(120, 94);
            listBz3.TabIndex = 6;
            // 
            // listBz2
            // 
            listBz2.FormattingEnabled = true;
            listBz2.ItemHeight = 15;
            listBz2.Location = new Point(141, 58);
            listBz2.Name = "listBz2";
            listBz2.Size = new Size(120, 94);
            listBz2.TabIndex = 5;
            // 
            // listBz1
            // 
            listBz1.FormattingEnabled = true;
            listBz1.ItemHeight = 15;
            listBz1.Location = new Point(15, 58);
            listBz1.Name = "listBz1";
            listBz1.Size = new Size(120, 94);
            listBz1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 40);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Zona 3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 40);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Zona 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Zona 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cBoxCamiones);
            groupBox2.Controls.Add(tBkg);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listBcargas);
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnIniciar);
            groupBox2.Location = new Point(12, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(514, 207);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preparar Reparto";
            // 
            // cBoxCamiones
            // 
            cBoxCamiones.FormattingEnabled = true;
            cBoxCamiones.Location = new Point(15, 73);
            cBoxCamiones.Name = "cBoxCamiones";
            cBoxCamiones.Size = new Size(164, 23);
            cBoxCamiones.TabIndex = 11;
            // 
            // tBkg
            // 
            tBkg.Location = new Point(79, 174);
            tBkg.Name = "tBkg";
            tBkg.Size = new Size(100, 23);
            tBkg.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 156);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 9;
            label6.Text = "Peso Acumulado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 44);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "Lista de Camiones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // listBcargas
            // 
            listBcargas.FormattingEnabled = true;
            listBcargas.ItemHeight = 15;
            listBcargas.Location = new Point(195, 44);
            listBcargas.Name = "listBcargas";
            listBcargas.Size = new Size(192, 154);
            listBcargas.TabIndex = 7;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(393, 73);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(104, 23);
            btnRetirar.TabIndex = 3;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(393, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(104, 115);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(15, 115);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarPaquetesPedidos;
        private GroupBox groupBox1;
        private ListBox listBz3;
        private ListBox listBz2;
        private ListBox listBz1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnRetirar;
        private Button btnAgregar;
        private Button btnEnviar;
        private Button btnIniciar;
        private ComboBox cBoxCamiones;
        private TextBox tBkg;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListBox listBcargas;
    }
}
