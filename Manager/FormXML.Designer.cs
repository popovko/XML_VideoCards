namespace XMLlab3
{
    partial class FormXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXML));
            this.rbDOM = new System.Windows.Forms.RadioButton();
            this.rbSAX = new System.Windows.Forms.RadioButton();
            this.rbLinq = new System.Windows.Forms.RadioButton();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbСhip = new System.Windows.Forms.CheckBox();
            this.cbMemory = new System.Windows.Forms.CheckBox();
            this.cbType = new System.Windows.Forms.CheckBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbPhoto = new System.Windows.Forms.CheckBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxChip = new System.Windows.Forms.ComboBox();
            this.cbxMemory = new System.Windows.Forms.ComboBox();
            this.cbxPrice = new System.Windows.Forms.ComboBox();
            this.cbxPhoto = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnToHTML = new System.Windows.Forms.Button();
            this.lvw = new System.Windows.Forms.ListView();
            this.imageListFXML = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // rbDOM
            // 
            this.rbDOM.AutoSize = true;
            this.rbDOM.Location = new System.Drawing.Point(12, 274);
            this.rbDOM.Name = "rbDOM";
            this.rbDOM.Size = new System.Drawing.Size(50, 17);
            this.rbDOM.TabIndex = 0;
            this.rbDOM.TabStop = true;
            this.rbDOM.Text = "DOM";
            this.rbDOM.UseVisualStyleBackColor = true;
            // 
            // rbSAX
            // 
            this.rbSAX.AutoSize = true;
            this.rbSAX.Location = new System.Drawing.Point(84, 274);
            this.rbSAX.Name = "rbSAX";
            this.rbSAX.Size = new System.Drawing.Size(46, 17);
            this.rbSAX.TabIndex = 1;
            this.rbSAX.TabStop = true;
            this.rbSAX.Text = "SAX";
            this.rbSAX.UseVisualStyleBackColor = true;
            // 
            // rbLinq
            // 
            this.rbLinq.AutoSize = true;
            this.rbLinq.Location = new System.Drawing.Point(148, 274);
            this.rbLinq.Name = "rbLinq";
            this.rbLinq.Size = new System.Drawing.Size(82, 17);
            this.rbLinq.TabIndex = 2;
            this.rbLinq.TabStop = true;
            this.rbLinq.Text = "Linq to XML";
            this.rbLinq.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.BackColor = System.Drawing.SystemColors.Info;
            this.cbName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbName.Location = new System.Drawing.Point(4, 28);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(54, 17);
            this.cbName.TabIndex = 3;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = false;
            // 
            // cbСhip
            // 
            this.cbСhip.AutoSize = true;
            this.cbСhip.BackColor = System.Drawing.SystemColors.Info;
            this.cbСhip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbСhip.Location = new System.Drawing.Point(4, 68);
            this.cbСhip.Name = "cbСhip";
            this.cbСhip.Size = new System.Drawing.Size(47, 17);
            this.cbСhip.TabIndex = 4;
            this.cbСhip.Text = "Chip";
            this.cbСhip.UseVisualStyleBackColor = false;
            // 
            // cbMemory
            // 
            this.cbMemory.AutoSize = true;
            this.cbMemory.BackColor = System.Drawing.SystemColors.Info;
            this.cbMemory.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbMemory.Location = new System.Drawing.Point(4, 101);
            this.cbMemory.Name = "cbMemory";
            this.cbMemory.Size = new System.Drawing.Size(63, 17);
            this.cbMemory.TabIndex = 5;
            this.cbMemory.Text = "Memory";
            this.cbMemory.UseVisualStyleBackColor = false;
            // 
            // cbType
            // 
            this.cbType.AutoSize = true;
            this.cbType.BackColor = System.Drawing.SystemColors.Info;
            this.cbType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbType.Location = new System.Drawing.Point(4, 136);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(50, 17);
            this.cbType.TabIndex = 6;
            this.cbType.Text = "Type";
            this.cbType.UseVisualStyleBackColor = false;
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.BackColor = System.Drawing.SystemColors.Info;
            this.cbPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbPrice.Location = new System.Drawing.Point(4, 171);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(50, 17);
            this.cbPrice.TabIndex = 7;
            this.cbPrice.Text = "Price";
            this.cbPrice.UseVisualStyleBackColor = false;
            // 
            // cbPhoto
            // 
            this.cbPhoto.AutoSize = true;
            this.cbPhoto.BackColor = System.Drawing.SystemColors.Info;
            this.cbPhoto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbPhoto.Location = new System.Drawing.Point(4, 207);
            this.cbPhoto.Name = "cbPhoto";
            this.cbPhoto.Size = new System.Drawing.Size(54, 17);
            this.cbPhoto.TabIndex = 8;
            this.cbPhoto.Text = "Photo";
            this.cbPhoto.UseVisualStyleBackColor = false;
            // 
            // cbxName
            // 
            this.cbxName.BackColor = System.Drawing.SystemColors.Info;
            this.cbxName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(136, 28);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(121, 21);
            this.cbxName.TabIndex = 9;
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.SystemColors.Info;
            this.cbxType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(136, 136);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 10;
            // 
            // cbxChip
            // 
            this.cbxChip.BackColor = System.Drawing.SystemColors.Info;
            this.cbxChip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxChip.FormattingEnabled = true;
            this.cbxChip.Location = new System.Drawing.Point(136, 64);
            this.cbxChip.Name = "cbxChip";
            this.cbxChip.Size = new System.Drawing.Size(121, 21);
            this.cbxChip.TabIndex = 11;
            // 
            // cbxMemory
            // 
            this.cbxMemory.BackColor = System.Drawing.SystemColors.Info;
            this.cbxMemory.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxMemory.FormattingEnabled = true;
            this.cbxMemory.Location = new System.Drawing.Point(136, 101);
            this.cbxMemory.Name = "cbxMemory";
            this.cbxMemory.Size = new System.Drawing.Size(121, 21);
            this.cbxMemory.TabIndex = 12;
            // 
            // cbxPrice
            // 
            this.cbxPrice.BackColor = System.Drawing.SystemColors.Info;
            this.cbxPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.Location = new System.Drawing.Point(136, 171);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(121, 21);
            this.cbxPrice.TabIndex = 13;
            // 
            // cbxPhoto
            // 
            this.cbxPhoto.BackColor = System.Drawing.SystemColors.Info;
            this.cbxPhoto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxPhoto.FormattingEnabled = true;
            this.cbxPhoto.Location = new System.Drawing.Point(136, 207);
            this.cbxPhoto.Name = "cbxPhoto";
            this.cbxPhoto.Size = new System.Drawing.Size(121, 21);
            this.cbxPhoto.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnToHTML
            // 
            this.btnToHTML.Location = new System.Drawing.Point(85, 319);
            this.btnToHTML.Name = "btnToHTML";
            this.btnToHTML.Size = new System.Drawing.Size(75, 23);
            this.btnToHTML.TabIndex = 17;
            this.btnToHTML.Text = "To HTML";
            this.btnToHTML.UseVisualStyleBackColor = true;
            this.btnToHTML.Click += new System.EventHandler(this.btnToHTML_Click);
            // 
            // lvw
            // 
            this.lvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw.BackColor = System.Drawing.SystemColors.Info;
            this.lvw.LargeImageList = this.imageListFXML;
            this.lvw.Location = new System.Drawing.Point(296, 28);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(421, 470);
            this.lvw.SmallImageList = this.imageListFXML;
            this.lvw.TabIndex = 18;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            // 
            // imageListFXML
            // 
            this.imageListFXML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFXML.ImageStream")));
            this.imageListFXML.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFXML.Images.SetKeyName(0, "dll.png");
            // 
            // FormXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(729, 510);
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.btnToHTML);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxPhoto);
            this.Controls.Add(this.cbxPrice);
            this.Controls.Add(this.cbxMemory);
            this.Controls.Add(this.cbxChip);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.cbPhoto);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbMemory);
            this.Controls.Add(this.cbСhip);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.rbLinq);
            this.Controls.Add(this.rbSAX);
            this.Controls.Add(this.rbDOM);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormXML";
            this.Text = "FormXML";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormXML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDOM;
        private System.Windows.Forms.RadioButton rbSAX;
        private System.Windows.Forms.RadioButton rbLinq;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbСhip;
        private System.Windows.Forms.CheckBox cbMemory;
        private System.Windows.Forms.CheckBox cbType;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbPhoto;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxChip;
        private System.Windows.Forms.ComboBox cbxMemory;
        private System.Windows.Forms.ComboBox cbxPrice;
        private System.Windows.Forms.ComboBox cbxPhoto;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnToHTML;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.ImageList imageListFXML;
    }
}