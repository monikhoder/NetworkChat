namespace ChatClient
{
    partial class FormChat1
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
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.txtSend = new MaterialSkin.Controls.MaterialTextBox2();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLeft = new MaterialSkin.Controls.MaterialButton();
            this.txtUserList = new System.Windows.Forms.RichTextBox();
            this.chatPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(581, 20);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(64, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = false;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSend.AnimateReadOnly = false;
            this.txtSend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSend.Depth = 0;
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSend.HideSelection = true;
            this.txtSend.LeadingIcon = null;
            this.txtSend.Location = new System.Drawing.Point(140, 14);
            this.txtSend.MaxLength = 32767;
            this.txtSend.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSend.Name = "txtSend";
            this.txtSend.PasswordChar = '\0';
            this.txtSend.PrefixSuffixText = null;
            this.txtSend.ReadOnly = false;
            this.txtSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSend.SelectedText = "";
            this.txtSend.SelectionLength = 0;
            this.txtSend.SelectionStart = 0;
            this.txtSend.ShortcutsEnabled = true;
            this.txtSend.Size = new System.Drawing.Size(395, 48);
            this.txtSend.TabIndex = 0;
            this.txtSend.TabStop = false;
            this.txtSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSend.TrailingIcon = null;
            this.txtSend.UseSystemPasswordChar = false;
            this.txtSend.Click += new System.EventHandler(this.txtSend_Click);
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.Controls.Add(this.materialCheckedListBox1);
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(143, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(534, 352);
            this.chatPanel.TabIndex = 0;
            this.chatPanel.WrapContents = false;
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(3, 3);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(6, 6);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.txtSend);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLeft.Depth = 0;
            this.btnLeft.HighEmphasis = true;
            this.btnLeft.Icon = null;
            this.btnLeft.Location = new System.Drawing.Point(15, 20);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLeft.Size = new System.Drawing.Size(97, 36);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left Chat";
            this.btnLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLeft.UseAccentColor = false;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtUserList
            // 
            this.txtUserList.Enabled = false;
            this.txtUserList.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserList.Location = new System.Drawing.Point(6, 3);
            this.txtUserList.Name = "txtUserList";
            this.txtUserList.ReadOnly = true;
            this.txtUserList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtUserList.Size = new System.Drawing.Size(136, 322);
            this.txtUserList.TabIndex = 3;
            this.txtUserList.Text = "";
            // 
            // FormChat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.txtUserList);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "FormChat1";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat1_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.chatPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSend;
        private MaterialSkin.Controls.MaterialTextBox2 txtSend;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialButton btnLeft;
        private System.Windows.Forms.RichTextBox txtUserList;
    }
}