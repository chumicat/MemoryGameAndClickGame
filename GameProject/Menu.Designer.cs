namespace GameProject
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.b_game5 = new System.Windows.Forms.Button();
            this.l_Rule = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.l_CardStyle = new System.Windows.Forms.Label();
            this.r_CardType = new System.Windows.Forms.ComboBox();
            this.l_Attribute = new System.Windows.Forms.Label();
            this.l_Level = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.r_AutoFlip = new System.Windows.Forms.CheckBox();
            this.r_CorrectDelay = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.r_Easy = new System.Windows.Forms.CheckBox();
            this.r_Medium = new System.Windows.Forms.CheckBox();
            this.r_Hard = new System.Windows.Forms.CheckBox();
            this.r_Custom = new System.Windows.Forms.CheckBox();
            this.l_Custom = new System.Windows.Forms.Label();
            this.customLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.l_Row = new System.Windows.Forms.Label();
            this.l_Col = new System.Windows.Forms.Label();
            this.r_Row = new System.Windows.Forms.NumericUpDown();
            this.r_Col = new System.Windows.Forms.NumericUpDown();
            this.message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.customLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r_Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_Col)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.message, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.b_game5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.l_Rule, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 279);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // b_game5
            // 
            this.b_game5.BackgroundImage = global::GameProject.Properties.Resources.enterButton;
            this.b_game5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_game5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_game5.Location = new System.Drawing.Point(3, 3);
            this.b_game5.Name = "b_game5";
            this.b_game5.Size = new System.Drawing.Size(380, 273);
            this.b_game5.TabIndex = 0;
            this.b_game5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_game5.UseVisualStyleBackColor = true;
            this.b_game5.Click += new System.EventHandler(this.b_game5_Click);
            // 
            // l_Rule
            // 
            this.l_Rule.AutoSize = true;
            this.l_Rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Rule.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Rule.Location = new System.Drawing.Point(389, 0);
            this.l_Rule.Name = "l_Rule";
            this.l_Rule.Size = new System.Drawing.Size(380, 279);
            this.l_Rule.TabIndex = 1;
            this.l_Rule.Text = "Rule\r\n  Match the card with less steps and as fast as you can.";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.35233F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.64767F));
            this.tableLayoutPanel3.Controls.Add(this.l_CardStyle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.r_CardType, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.l_Attribute, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_Level, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.l_Custom, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.customLayoutPanel, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 204);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // l_CardStyle
            // 
            this.l_CardStyle.AutoSize = true;
            this.l_CardStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_CardStyle.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_CardStyle.Location = new System.Drawing.Point(3, 0);
            this.l_CardStyle.Name = "l_CardStyle";
            this.l_CardStyle.Size = new System.Drawing.Size(181, 50);
            this.l_CardStyle.TabIndex = 0;
            this.l_CardStyle.Text = "Card Style";
            this.l_CardStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_CardType
            // 
            this.r_CardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_CardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.r_CardType.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_CardType.FormattingEnabled = true;
            this.r_CardType.Items.AddRange(new object[] {
            "T00. Color Heaven",
            "T01. Cat and Fish",
            "T02. Bleed Party"});
            this.r_CardType.Location = new System.Drawing.Point(190, 3);
            this.r_CardType.Name = "r_CardType";
            this.r_CardType.Size = new System.Drawing.Size(579, 41);
            this.r_CardType.TabIndex = 1;
            this.r_CardType.SelectedIndexChanged += new System.EventHandler(this.r_CardType_SelectedIndexChanged);
            // 
            // l_Attribute
            // 
            this.l_Attribute.AutoSize = true;
            this.l_Attribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Attribute.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Attribute.Location = new System.Drawing.Point(3, 50);
            this.l_Attribute.Name = "l_Attribute";
            this.l_Attribute.Size = new System.Drawing.Size(181, 50);
            this.l_Attribute.TabIndex = 2;
            this.l_Attribute.Text = "Attribute";
            this.l_Attribute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Level
            // 
            this.l_Level.AutoSize = true;
            this.l_Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Level.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Level.Location = new System.Drawing.Point(3, 100);
            this.l_Level.Name = "l_Level";
            this.l_Level.Size = new System.Drawing.Size(181, 50);
            this.l_Level.TabIndex = 4;
            this.l_Level.Text = "Level";
            this.l_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.r_AutoFlip);
            this.flowLayoutPanel1.Controls.Add(this.r_CorrectDelay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(190, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 44);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // r_AutoFlip
            // 
            this.r_AutoFlip.AutoSize = true;
            this.r_AutoFlip.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_AutoFlip.Location = new System.Drawing.Point(3, 3);
            this.r_AutoFlip.Name = "r_AutoFlip";
            this.r_AutoFlip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_AutoFlip.Size = new System.Drawing.Size(179, 37);
            this.r_AutoFlip.TabIndex = 3;
            this.r_AutoFlip.Text = "AutoFlip";
            this.r_AutoFlip.UseVisualStyleBackColor = true;
            // 
            // r_CorrectDelay
            // 
            this.r_CorrectDelay.AutoSize = true;
            this.r_CorrectDelay.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_CorrectDelay.Location = new System.Drawing.Point(188, 3);
            this.r_CorrectDelay.Name = "r_CorrectDelay";
            this.r_CorrectDelay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_CorrectDelay.Size = new System.Drawing.Size(259, 37);
            this.r_CorrectDelay.TabIndex = 1;
            this.r_CorrectDelay.Text = "Correct Delay";
            this.r_CorrectDelay.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.r_Easy);
            this.flowLayoutPanel2.Controls.Add(this.r_Medium);
            this.flowLayoutPanel2.Controls.Add(this.r_Hard);
            this.flowLayoutPanel2.Controls.Add(this.r_Custom);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(190, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(579, 44);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // r_Easy
            // 
            this.r_Easy.AutoSize = true;
            this.r_Easy.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_Easy.Location = new System.Drawing.Point(3, 3);
            this.r_Easy.Name = "r_Easy";
            this.r_Easy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_Easy.Size = new System.Drawing.Size(115, 37);
            this.r_Easy.TabIndex = 0;
            this.r_Easy.Text = "Easy";
            this.r_Easy.UseVisualStyleBackColor = true;
            // 
            // r_Medium
            // 
            this.r_Medium.AutoSize = true;
            this.r_Medium.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_Medium.Location = new System.Drawing.Point(124, 3);
            this.r_Medium.Name = "r_Medium";
            this.r_Medium.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_Medium.Size = new System.Drawing.Size(147, 37);
            this.r_Medium.TabIndex = 1;
            this.r_Medium.Text = "Medium";
            this.r_Medium.UseVisualStyleBackColor = true;
            // 
            // r_Hard
            // 
            this.r_Hard.AutoSize = true;
            this.r_Hard.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_Hard.Location = new System.Drawing.Point(277, 3);
            this.r_Hard.Name = "r_Hard";
            this.r_Hard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_Hard.Size = new System.Drawing.Size(115, 37);
            this.r_Hard.TabIndex = 2;
            this.r_Hard.Text = "Hard";
            this.r_Hard.UseVisualStyleBackColor = true;
            // 
            // r_Custom
            // 
            this.r_Custom.AutoSize = true;
            this.r_Custom.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.r_Custom.Location = new System.Drawing.Point(398, 3);
            this.r_Custom.Name = "r_Custom";
            this.r_Custom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r_Custom.Size = new System.Drawing.Size(147, 37);
            this.r_Custom.TabIndex = 3;
            this.r_Custom.Text = "Custom";
            this.r_Custom.UseVisualStyleBackColor = true;
            // 
            // l_Custom
            // 
            this.l_Custom.AutoSize = true;
            this.l_Custom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Custom.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Custom.Location = new System.Drawing.Point(3, 150);
            this.l_Custom.Name = "l_Custom";
            this.l_Custom.Size = new System.Drawing.Size(181, 54);
            this.l_Custom.TabIndex = 7;
            this.l_Custom.Text = "Custom";
            this.l_Custom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_Custom.Visible = false;
            // 
            // customLayoutPanel
            // 
            this.customLayoutPanel.ColumnCount = 4;
            this.customLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.customLayoutPanel.Controls.Add(this.l_Row, 0, 0);
            this.customLayoutPanel.Controls.Add(this.l_Col, 2, 0);
            this.customLayoutPanel.Controls.Add(this.r_Row, 1, 0);
            this.customLayoutPanel.Controls.Add(this.r_Col, 3, 0);
            this.customLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customLayoutPanel.Location = new System.Drawing.Point(190, 153);
            this.customLayoutPanel.Name = "customLayoutPanel";
            this.customLayoutPanel.RowCount = 1;
            this.customLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customLayoutPanel.Size = new System.Drawing.Size(579, 48);
            this.customLayoutPanel.TabIndex = 8;
            this.customLayoutPanel.Visible = false;
            // 
            // l_Row
            // 
            this.l_Row.AutoSize = true;
            this.l_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Row.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Row.Location = new System.Drawing.Point(3, 0);
            this.l_Row.Name = "l_Row";
            this.l_Row.Size = new System.Drawing.Size(138, 48);
            this.l_Row.TabIndex = 0;
            this.l_Row.Text = "Row";
            this.l_Row.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Col
            // 
            this.l_Col.AutoSize = true;
            this.l_Col.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Col.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_Col.Location = new System.Drawing.Point(291, 0);
            this.l_Col.Name = "l_Col";
            this.l_Col.Size = new System.Drawing.Size(138, 48);
            this.l_Col.TabIndex = 1;
            this.l_Col.Text = "Column";
            this.l_Col.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_Row
            // 
            this.r_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_Row.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_Row.Location = new System.Drawing.Point(147, 3);
            this.r_Row.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.r_Row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.r_Row.Name = "r_Row";
            this.r_Row.Size = new System.Drawing.Size(138, 46);
            this.r_Row.TabIndex = 9;
            this.r_Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // r_Col
            // 
            this.r_Col.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_Col.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.r_Col.Location = new System.Drawing.Point(435, 3);
            this.r_Col.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.r_Col.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.r_Col.Name = "r_Col";
            this.r_Col.Size = new System.Drawing.Size(141, 46);
            this.r_Col.TabIndex = 10;
            this.r_Col.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(213)))));
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message.Location = new System.Drawing.Point(3, 210);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(772, 50);
            this.message.TabIndex = 2;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memory Matching - Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.customLayoutPanel.ResumeLayout(false);
            this.customLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r_Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_Col)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_game5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l_CardStyle;
        private System.Windows.Forms.ComboBox r_CardType;
        private System.Windows.Forms.Label l_Attribute;
        private System.Windows.Forms.CheckBox r_AutoFlip;
        private System.Windows.Forms.Label l_Rule;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_Level;
        private System.Windows.Forms.CheckBox r_CorrectDelay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox r_Easy;
        private System.Windows.Forms.CheckBox r_Medium;
        private System.Windows.Forms.CheckBox r_Hard;
        private System.Windows.Forms.CheckBox r_Custom;
        private System.Windows.Forms.Label l_Custom;
        private System.Windows.Forms.TableLayoutPanel customLayoutPanel;
        private System.Windows.Forms.Label l_Row;
        private System.Windows.Forms.Label l_Col;
        private System.Windows.Forms.NumericUpDown r_Row;
        private System.Windows.Forms.NumericUpDown r_Col;
        private System.Windows.Forms.Label message;
    }
}

