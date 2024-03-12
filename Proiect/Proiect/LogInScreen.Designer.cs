namespace Proiect
{
    partial class LogInScreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnVizCam = new System.Windows.Forms.Button();
            this.btnLogIn1 = new System.Windows.Forms.Button();
            this.btnStepBackHome = new System.Windows.Forms.Button();
            this.btnEdCam = new System.Windows.Forms.Button();
            this.btnEdClient = new System.Windows.Forms.Button();
            this.btnEdRez = new System.Windows.Forms.Button();
            this.btnEdConRez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(201, 217);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Log In";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(167, 138);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 13;
            this.txtParola.Visible = false;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(167, 88);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(100, 20);
            this.txtUtilizator.TabIndex = 12;
            this.txtUtilizator.Visible = false;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(23, 136);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 11;
            this.lblParola.Text = "Parola";
            this.lblParola.Visible = false;
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(20, 88);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(47, 13);
            this.lblUtilizator.TabIndex = 10;
            this.lblUtilizator.Text = "Utilizator";
            this.lblUtilizator.Visible = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(175, 58);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(117, 13);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor SC UnivSoft SRL";
            this.lblAutor.Visible = false;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(175, 22);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(137, 13);
            this.lblTitlu.TabIndex = 8;
            this.lblTitlu.Text = "APLICATIE de PERSONAL";
            this.lblTitlu.Visible = false;
            // 
            // btnVizCam
            // 
            this.btnVizCam.Location = new System.Drawing.Point(38, 74);
            this.btnVizCam.Name = "btnVizCam";
            this.btnVizCam.Size = new System.Drawing.Size(167, 104);
            this.btnVizCam.TabIndex = 15;
            this.btnVizCam.Text = "Vizualizare camere";
            this.btnVizCam.UseVisualStyleBackColor = true;
            this.btnVizCam.Click += new System.EventHandler(this.btnVizCam_Click);
            // 
            // btnLogIn1
            // 
            this.btnLogIn1.Location = new System.Drawing.Point(273, 74);
            this.btnLogIn1.Name = "btnLogIn1";
            this.btnLogIn1.Size = new System.Drawing.Size(167, 104);
            this.btnLogIn1.TabIndex = 16;
            this.btnLogIn1.Text = "Log In";
            this.btnLogIn1.UseVisualStyleBackColor = true;
            this.btnLogIn1.Click += new System.EventHandler(this.btnLogIn1_Click);
            // 
            // btnStepBackHome
            // 
            this.btnStepBackHome.Location = new System.Drawing.Point(13, 13);
            this.btnStepBackHome.Name = "btnStepBackHome";
            this.btnStepBackHome.Size = new System.Drawing.Size(29, 22);
            this.btnStepBackHome.TabIndex = 17;
            this.btnStepBackHome.Text = "<-";
            this.btnStepBackHome.UseVisualStyleBackColor = true;
            this.btnStepBackHome.Visible = false;
            this.btnStepBackHome.Click += new System.EventHandler(this.btnStepBackHome_Click);
            // 
            // btnEdCam
            // 
            this.btnEdCam.Location = new System.Drawing.Point(50, 97);
            this.btnEdCam.Name = "btnEdCam";
            this.btnEdCam.Size = new System.Drawing.Size(122, 104);
            this.btnEdCam.TabIndex = 18;
            this.btnEdCam.Text = "Editare lista Camere";
            this.btnEdCam.UseVisualStyleBackColor = true;
            this.btnEdCam.Visible = false;
            this.btnEdCam.Click += new System.EventHandler(this.btnEdCam_Click);
            // 
            // btnEdClient
            // 
            this.btnEdClient.Location = new System.Drawing.Point(178, 98);
            this.btnEdClient.Name = "btnEdClient";
            this.btnEdClient.Size = new System.Drawing.Size(122, 103);
            this.btnEdClient.TabIndex = 19;
            this.btnEdClient.Text = "Editare date Clienti";
            this.btnEdClient.UseVisualStyleBackColor = true;
            this.btnEdClient.Visible = false;
            this.btnEdClient.Click += new System.EventHandler(this.btnEdClient_Click);
            // 
            // btnEdRez
            // 
            this.btnEdRez.Location = new System.Drawing.Point(306, 98);
            this.btnEdRez.Name = "btnEdRez";
            this.btnEdRez.Size = new System.Drawing.Size(122, 48);
            this.btnEdRez.TabIndex = 20;
            this.btnEdRez.Text = "Editare Rezervari";
            this.btnEdRez.UseVisualStyleBackColor = true;
            this.btnEdRez.Visible = false;
            this.btnEdRez.Click += new System.EventHandler(this.btnEdRez_Click);
            // 
            // btnEdConRez
            // 
            this.btnEdConRez.Location = new System.Drawing.Point(306, 153);
            this.btnEdConRez.Name = "btnEdConRez";
            this.btnEdConRez.Size = new System.Drawing.Size(122, 48);
            this.btnEdConRez.TabIndex = 21;
            this.btnEdConRez.Text = "Editare Continut Rezervari";
            this.btnEdConRez.UseVisualStyleBackColor = true;
            this.btnEdConRez.Visible = false;
            this.btnEdConRez.Click += new System.EventHandler(this.btnEdConRez_Click);
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 276);
            this.Controls.Add(this.btnEdConRez);
            this.Controls.Add(this.btnEdRez);
            this.Controls.Add(this.btnEdClient);
            this.Controls.Add(this.btnEdCam);
            this.Controls.Add(this.btnStepBackHome);
            this.Controls.Add(this.btnLogIn1);
            this.Controls.Add(this.btnVizCam);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "LogInScreen";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnVizCam;
        private System.Windows.Forms.Button btnLogIn1;
        private System.Windows.Forms.Button btnStepBackHome;
        private System.Windows.Forms.Button btnEdCam;
        private System.Windows.Forms.Button btnEdClient;
        private System.Windows.Forms.Button btnEdRez;
        private System.Windows.Forms.Button btnEdConRez;
    }
}

