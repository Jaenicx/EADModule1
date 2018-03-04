namespace Module_1_Assigment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnamebox = new System.Windows.Forms.TextBox();
            this.parish = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.spackage = new System.Windows.Forms.Label();
            this.parishcombo = new System.Windows.Forms.ComboBox();
            this.spakagebox = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.vdemand = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.vdyes = new System.Windows.Forms.RadioButton();
            this.fnamebox = new System.Windows.Forms.TextBox();
            this.vdno = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.vrent = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.vrentbox = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.streetbox = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Button();
            this.citybox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnamebox
            // 
            this.lnamebox.Location = new System.Drawing.Point(104, 109);
            this.lnamebox.Name = "lnamebox";
            this.lnamebox.Size = new System.Drawing.Size(140, 22);
            this.lnamebox.TabIndex = 17;
            this.lnamebox.TextChanged += new System.EventHandler(this.lnamebox_TextChanged);
            // 
            // parish
            // 
            this.parish.AutoSize = true;
            this.parish.BackColor = System.Drawing.Color.Transparent;
            this.parish.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parish.Location = new System.Drawing.Point(15, 220);
            this.parish.Name = "parish";
            this.parish.Size = new System.Drawing.Size(46, 17);
            this.parish.TabIndex = 26;
            this.parish.Text = "Parish";
            this.parish.Click += new System.EventHandler(this.parish_Click_1);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(6, 112);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(74, 17);
            this.lastName.TabIndex = 19;
            this.lastName.Text = "Last Name";
            this.lastName.Click += new System.EventHandler(this.lastName_Click_1);
            // 
            // spackage
            // 
            this.spackage.AutoSize = true;
            this.spackage.BackColor = System.Drawing.Color.Transparent;
            this.spackage.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spackage.Location = new System.Drawing.Point(15, 343);
            this.spackage.Name = "spackage";
            this.spackage.Size = new System.Drawing.Size(126, 17);
            this.spackage.TabIndex = 16;
            this.spackage.Text = "Subscribed Pakage";
            this.spackage.Click += new System.EventHandler(this.spackage_Click);
            // 
            // parishcombo
            // 
            this.parishcombo.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parishcombo.FormattingEnabled = true;
            this.parishcombo.Items.AddRange(new object[] {
            "BrightMarsh",
            "Stone Keep",
            "Jaguar Falls",
            "Serpent Beach"});
            this.parishcombo.Location = new System.Drawing.Point(113, 217);
            this.parishcombo.Name = "parishcombo";
            this.parishcombo.Size = new System.Drawing.Size(140, 24);
            this.parishcombo.TabIndex = 27;
            this.parishcombo.Text = "--Select a Parish--";
            this.parishcombo.SelectedIndexChanged += new System.EventHandler(this.parishcombo_SelectedIndexChanged);
            // 
            // spakagebox
            // 
            this.spakagebox.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spakagebox.FormattingEnabled = true;
            this.spakagebox.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond"});
            this.spakagebox.Location = new System.Drawing.Point(152, 340);
            this.spakagebox.Name = "spakagebox";
            this.spakagebox.Size = new System.Drawing.Size(152, 24);
            this.spakagebox.TabIndex = 17;
            this.spakagebox.Text = "--Select a Package--";
            this.spakagebox.SelectedIndexChanged += new System.EventHandler(this.spakagebox_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(6, 146);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(52, 17);
            this.gender.TabIndex = 20;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // vdemand
            // 
            this.vdemand.AutoSize = true;
            this.vdemand.BackColor = System.Drawing.Color.Transparent;
            this.vdemand.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdemand.Location = new System.Drawing.Point(15, 467);
            this.vdemand.Name = "vdemand";
            this.vdemand.Size = new System.Drawing.Size(118, 17);
            this.vdemand.TabIndex = 18;
            this.vdemand.Text = "Video on Demand";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(15, 257);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(31, 17);
            this.city.TabIndex = 25;
            this.city.Text = "City";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // vdyes
            // 
            this.vdyes.AutoSize = true;
            this.vdyes.BackColor = System.Drawing.Color.Transparent;
            this.vdyes.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdyes.Location = new System.Drawing.Point(152, 467);
            this.vdyes.Name = "vdyes";
            this.vdyes.Size = new System.Drawing.Size(52, 21);
            this.vdyes.TabIndex = 19;
            this.vdyes.TabStop = true;
            this.vdyes.Text = "Yes";
            this.vdyes.UseVisualStyleBackColor = false;
            this.vdyes.CheckedChanged += new System.EventHandler(this.vdyes_CheckedChanged);
            // 
            // fnamebox
            // 
            this.fnamebox.Location = new System.Drawing.Point(104, 68);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.Size = new System.Drawing.Size(140, 22);
            this.fnamebox.TabIndex = 16;
            this.fnamebox.TextChanged += new System.EventHandler(this.fnamebox_TextChanged);
            // 
            // vdno
            // 
            this.vdno.AutoSize = true;
            this.vdno.BackColor = System.Drawing.Color.Transparent;
            this.vdno.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdno.Location = new System.Drawing.Point(232, 467);
            this.vdno.Name = "vdno";
            this.vdno.Size = new System.Drawing.Size(47, 21);
            this.vdno.TabIndex = 20;
            this.vdno.TabStop = true;
            this.vdno.Text = "No";
            this.vdno.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.SystemColors.Info;
            this.male.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(104, 144);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 21);
            this.male.TabIndex = 21;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = false;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // vrent
            // 
            this.vrent.AutoSize = true;
            this.vrent.BackColor = System.Drawing.Color.Transparent;
            this.vrent.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrent.Location = new System.Drawing.Point(15, 509);
            this.vrent.Name = "vrent";
            this.vrent.Size = new System.Drawing.Size(123, 17);
            this.vrent.TabIndex = 21;
            this.vrent.Text = "Total Video Rented";
            this.vrent.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.Transparent;
            this.female.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(169, 144);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 21);
            this.female.TabIndex = 22;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = false;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // vrentbox
            // 
            this.vrentbox.Location = new System.Drawing.Point(152, 505);
            this.vrentbox.Name = "vrentbox";
            this.vrentbox.Size = new System.Drawing.Size(152, 22);
            this.vrentbox.TabIndex = 22;
            this.vrentbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.BackColor = System.Drawing.Color.Transparent;
            this.street.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(15, 185);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(43, 17);
            this.street.TabIndex = 23;
            this.street.Text = "Street";
            this.street.Click += new System.EventHandler(this.street_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(18, 549);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(89, 38);
            this.exitbutton.TabIndex = 23;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // streetbox
            // 
            this.streetbox.Location = new System.Drawing.Point(113, 182);
            this.streetbox.Name = "streetbox";
            this.streetbox.Size = new System.Drawing.Size(140, 22);
            this.streetbox.TabIndex = 24;
            this.streetbox.TextChanged += new System.EventHandler(this.streetbox_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(215, 549);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(89, 38);
            this.submitbutton.TabIndex = 24;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.Font = new System.Drawing.Font("HelveticaNeue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(6, 72);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(74, 17);
            this.firstName.TabIndex = 18;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.firstName_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(113, 549);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(89, 38);
            this.s.TabIndex = 25;
            this.s.Text = "Clear";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(113, 254);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(140, 22);
            this.citybox.TabIndex = 28;
            this.citybox.TextChanged += new System.EventHandler(this.citybox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.citybox);
            this.panel1.Controls.Add(this.s);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.submitbutton);
            this.panel1.Controls.Add(this.streetbox);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.street);
            this.panel1.Controls.Add(this.vrentbox);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.vrent);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.vdno);
            this.panel1.Controls.Add(this.fnamebox);
            this.panel1.Controls.Add(this.vdyes);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.vdemand);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.spakagebox);
            this.panel1.Controls.Add(this.parishcombo);
            this.panel1.Controls.Add(this.spackage);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.parish);
            this.panel1.Controls.Add(this.lnamebox);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 619);
            this.panel1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 610);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lnamebox;
        private System.Windows.Forms.Label parish;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label spackage;
        private System.Windows.Forms.ComboBox parishcombo;
        private System.Windows.Forms.ComboBox spakagebox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label vdemand;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.RadioButton vdyes;
        private System.Windows.Forms.TextBox fnamebox;
        private System.Windows.Forms.RadioButton vdno;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label vrent;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox vrentbox;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox streetbox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Panel panel1;
    }
}

