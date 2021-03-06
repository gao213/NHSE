﻿namespace NHSE.WinForms
{
    partial class ItemEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CB_ItemID = new System.Windows.Forms.ComboBox();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.L_Count = new System.Windows.Forms.Label();
            this.L_Uses = new System.Windows.Forms.Label();
            this.NUD_Uses = new System.Windows.Forms.NumericUpDown();
            this.L_Flag0 = new System.Windows.Forms.Label();
            this.NUD_Flag0 = new System.Windows.Forms.NumericUpDown();
            this.L_Flag1 = new System.Windows.Forms.Label();
            this.NUD_Flag1 = new System.Windows.Forms.NumericUpDown();
            this.CM_Hand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.CB_NamedItemArgument = new System.Windows.Forms.ComboBox();
            this.FLP_Controls = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Count = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Uses = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Flag0 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Flag1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Genetics = new System.Windows.Forms.FlowLayoutPanel();
            this.CHK_R2 = new System.Windows.Forms.CheckBox();
            this.CHK_R1 = new System.Windows.Forms.CheckBox();
            this.CHK_Y2 = new System.Windows.Forms.CheckBox();
            this.CHK_Y1 = new System.Windows.Forms.CheckBox();
            this.CHK_W2 = new System.Windows.Forms.CheckBox();
            this.CHK_W1 = new System.Windows.Forms.CheckBox();
            this.CHK_S2 = new System.Windows.Forms.CheckBox();
            this.CHK_S1 = new System.Windows.Forms.CheckBox();
            this.FLP_FlowerFlags = new System.Windows.Forms.FlowLayoutPanel();
            this.CHK_F2 = new System.Windows.Forms.CheckBox();
            this.CHK_F1 = new System.Windows.Forms.CheckBox();
            this.CHK_F4 = new System.Windows.Forms.CheckBox();
            this.CHK_F3 = new System.Windows.Forms.CheckBox();
            this.CHK_F6 = new System.Windows.Forms.CheckBox();
            this.CHK_F5 = new System.Windows.Forms.CheckBox();
            this.CHK_F8 = new System.Windows.Forms.CheckBox();
            this.CHK_F7 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Uses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Flag0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Flag1)).BeginInit();
            this.CM_Hand.SuspendLayout();
            this.FLP_Controls.SuspendLayout();
            this.FLP_Count.SuspendLayout();
            this.FLP_Uses.SuspendLayout();
            this.FLP_Flag0.SuspendLayout();
            this.FLP_Flag1.SuspendLayout();
            this.FLP_Genetics.SuspendLayout();
            this.FLP_FlowerFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_ItemID
            // 
            this.CB_ItemID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_ItemID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ItemID.DropDownWidth = 322;
            this.CB_ItemID.FormattingEnabled = true;
            this.CB_ItemID.Location = new System.Drawing.Point(3, 1);
            this.CB_ItemID.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.CB_ItemID.Name = "CB_ItemID";
            this.CB_ItemID.Size = new System.Drawing.Size(141, 21);
            this.CB_ItemID.TabIndex = 1;
            this.CB_ItemID.SelectedValueChanged += new System.EventHandler(this.CB_ItemID_SelectedValueChanged);
            // 
            // NUD_Count
            // 
            this.NUD_Count.Location = new System.Drawing.Point(88, 3);
            this.NUD_Count.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(56, 20);
            this.NUD_Count.TabIndex = 2;
            this.NUD_Count.ValueChanged += new System.EventHandler(this.NUD_Count_ValueChanged);
            // 
            // L_Count
            // 
            this.L_Count.AutoSize = true;
            this.L_Count.Location = new System.Drawing.Point(44, 6);
            this.L_Count.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(38, 13);
            this.L_Count.TabIndex = 7;
            this.L_Count.Text = "Count:";
            this.L_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_Uses
            // 
            this.L_Uses.AutoSize = true;
            this.L_Uses.Location = new System.Drawing.Point(48, 6);
            this.L_Uses.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.L_Uses.Name = "L_Uses";
            this.L_Uses.Size = new System.Drawing.Size(34, 13);
            this.L_Uses.TabIndex = 9;
            this.L_Uses.Text = "Uses:";
            this.L_Uses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_Uses
            // 
            this.NUD_Uses.Location = new System.Drawing.Point(88, 3);
            this.NUD_Uses.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Uses.Name = "NUD_Uses";
            this.NUD_Uses.Size = new System.Drawing.Size(56, 20);
            this.NUD_Uses.TabIndex = 8;
            // 
            // L_Flag0
            // 
            this.L_Flag0.AutoSize = true;
            this.L_Flag0.Location = new System.Drawing.Point(46, 6);
            this.L_Flag0.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.L_Flag0.Name = "L_Flag0";
            this.L_Flag0.Size = new System.Drawing.Size(36, 13);
            this.L_Flag0.TabIndex = 11;
            this.L_Flag0.Text = "Flag0:";
            this.L_Flag0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_Flag0
            // 
            this.NUD_Flag0.Hexadecimal = true;
            this.NUD_Flag0.Location = new System.Drawing.Point(88, 3);
            this.NUD_Flag0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Flag0.Name = "NUD_Flag0";
            this.NUD_Flag0.Size = new System.Drawing.Size(56, 20);
            this.NUD_Flag0.TabIndex = 10;
            // 
            // L_Flag1
            // 
            this.L_Flag1.AutoSize = true;
            this.L_Flag1.Location = new System.Drawing.Point(46, 6);
            this.L_Flag1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.L_Flag1.Name = "L_Flag1";
            this.L_Flag1.Size = new System.Drawing.Size(36, 13);
            this.L_Flag1.TabIndex = 13;
            this.L_Flag1.Text = "Flag1:";
            this.L_Flag1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NUD_Flag1
            // 
            this.NUD_Flag1.Hexadecimal = true;
            this.NUD_Flag1.Location = new System.Drawing.Point(88, 3);
            this.NUD_Flag1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_Flag1.Name = "NUD_Flag1";
            this.NUD_Flag1.Size = new System.Drawing.Size(56, 20);
            this.NUD_Flag1.TabIndex = 12;
            // 
            // CM_Hand
            // 
            this.CM_Hand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_View,
            this.Menu_Set,
            this.Menu_Delete});
            this.CM_Hand.Name = "CM_Hand";
            this.CM_Hand.Size = new System.Drawing.Size(108, 70);
            // 
            // Menu_View
            // 
            this.Menu_View.Name = "Menu_View";
            this.Menu_View.Size = new System.Drawing.Size(107, 22);
            this.Menu_View.Text = "View";
            // 
            // Menu_Set
            // 
            this.Menu_Set.Name = "Menu_Set";
            this.Menu_Set.Size = new System.Drawing.Size(107, 22);
            this.Menu_Set.Text = "Set";
            // 
            // Menu_Delete
            // 
            this.Menu_Delete.Name = "Menu_Delete";
            this.Menu_Delete.Size = new System.Drawing.Size(107, 22);
            this.Menu_Delete.Text = "Delete";
            // 
            // CB_NamedItemArgument
            // 
            this.CB_NamedItemArgument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_NamedItemArgument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_NamedItemArgument.DropDownWidth = 322;
            this.CB_NamedItemArgument.FormattingEnabled = true;
            this.CB_NamedItemArgument.Location = new System.Drawing.Point(3, 24);
            this.CB_NamedItemArgument.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.CB_NamedItemArgument.Name = "CB_NamedItemArgument";
            this.CB_NamedItemArgument.Size = new System.Drawing.Size(141, 21);
            this.CB_NamedItemArgument.TabIndex = 14;
            this.CB_NamedItemArgument.Visible = false;
            this.CB_NamedItemArgument.SelectedValueChanged += new System.EventHandler(this.CB_NamedItemArgument_SelectedValueChanged);
            // 
            // FLP_Controls
            // 
            this.FLP_Controls.Controls.Add(this.CB_ItemID);
            this.FLP_Controls.Controls.Add(this.CB_NamedItemArgument);
            this.FLP_Controls.Controls.Add(this.FLP_Count);
            this.FLP_Controls.Controls.Add(this.FLP_Uses);
            this.FLP_Controls.Controls.Add(this.FLP_Flag0);
            this.FLP_Controls.Controls.Add(this.FLP_Flag1);
            this.FLP_Controls.Controls.Add(this.FLP_Genetics);
            this.FLP_Controls.Controls.Add(this.FLP_FlowerFlags);
            this.FLP_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Controls.Location = new System.Drawing.Point(0, 0);
            this.FLP_Controls.Name = "FLP_Controls";
            this.FLP_Controls.Size = new System.Drawing.Size(252, 330);
            this.FLP_Controls.TabIndex = 15;
            // 
            // FLP_Count
            // 
            this.FLP_Count.Controls.Add(this.NUD_Count);
            this.FLP_Count.Controls.Add(this.L_Count);
            this.FLP_Count.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_Count.Location = new System.Drawing.Point(0, 46);
            this.FLP_Count.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Count.Name = "FLP_Count";
            this.FLP_Count.Size = new System.Drawing.Size(147, 26);
            this.FLP_Count.TabIndex = 16;
            // 
            // FLP_Uses
            // 
            this.FLP_Uses.Controls.Add(this.NUD_Uses);
            this.FLP_Uses.Controls.Add(this.L_Uses);
            this.FLP_Uses.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_Uses.Location = new System.Drawing.Point(0, 72);
            this.FLP_Uses.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Uses.Name = "FLP_Uses";
            this.FLP_Uses.Size = new System.Drawing.Size(147, 26);
            this.FLP_Uses.TabIndex = 17;
            // 
            // FLP_Flag0
            // 
            this.FLP_Flag0.Controls.Add(this.NUD_Flag0);
            this.FLP_Flag0.Controls.Add(this.L_Flag0);
            this.FLP_Flag0.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_Flag0.Location = new System.Drawing.Point(0, 98);
            this.FLP_Flag0.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Flag0.Name = "FLP_Flag0";
            this.FLP_Flag0.Size = new System.Drawing.Size(147, 26);
            this.FLP_Flag0.TabIndex = 17;
            // 
            // FLP_Flag1
            // 
            this.FLP_Flag1.Controls.Add(this.NUD_Flag1);
            this.FLP_Flag1.Controls.Add(this.L_Flag1);
            this.FLP_Flag1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_Flag1.Location = new System.Drawing.Point(0, 124);
            this.FLP_Flag1.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Flag1.Name = "FLP_Flag1";
            this.FLP_Flag1.Size = new System.Drawing.Size(147, 26);
            this.FLP_Flag1.TabIndex = 17;
            // 
            // FLP_Genetics
            // 
            this.FLP_Genetics.Controls.Add(this.CHK_R2);
            this.FLP_Genetics.Controls.Add(this.CHK_R1);
            this.FLP_Genetics.Controls.Add(this.CHK_Y2);
            this.FLP_Genetics.Controls.Add(this.CHK_Y1);
            this.FLP_Genetics.Controls.Add(this.CHK_W2);
            this.FLP_Genetics.Controls.Add(this.CHK_W1);
            this.FLP_Genetics.Controls.Add(this.CHK_S2);
            this.FLP_Genetics.Controls.Add(this.CHK_S1);
            this.FLP_Genetics.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_Genetics.Location = new System.Drawing.Point(0, 150);
            this.FLP_Genetics.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Genetics.Name = "FLP_Genetics";
            this.FLP_Genetics.Size = new System.Drawing.Size(106, 81);
            this.FLP_Genetics.TabIndex = 18;
            // 
            // CHK_R2
            // 
            this.CHK_R2.AutoSize = true;
            this.CHK_R2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_R2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_R2.Location = new System.Drawing.Point(66, 0);
            this.CHK_R2.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_R2.Name = "CHK_R2";
            this.CHK_R2.Size = new System.Drawing.Size(40, 18);
            this.CHK_R2.TabIndex = 0;
            this.CHK_R2.Text = "R2";
            this.CHK_R2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_R2.UseVisualStyleBackColor = true;
            // 
            // CHK_R1
            // 
            this.CHK_R1.AutoSize = true;
            this.CHK_R1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_R1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_R1.Location = new System.Drawing.Point(26, 0);
            this.CHK_R1.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_R1.Name = "CHK_R1";
            this.CHK_R1.Size = new System.Drawing.Size(40, 18);
            this.CHK_R1.TabIndex = 1;
            this.CHK_R1.Text = "R1";
            this.CHK_R1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_R1.UseVisualStyleBackColor = true;
            // 
            // CHK_Y2
            // 
            this.CHK_Y2.AutoSize = true;
            this.CHK_Y2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_Y2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Y2.Location = new System.Drawing.Point(66, 18);
            this.CHK_Y2.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_Y2.Name = "CHK_Y2";
            this.CHK_Y2.Size = new System.Drawing.Size(40, 18);
            this.CHK_Y2.TabIndex = 2;
            this.CHK_Y2.Text = "Y2";
            this.CHK_Y2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_Y2.UseVisualStyleBackColor = true;
            // 
            // CHK_Y1
            // 
            this.CHK_Y1.AutoSize = true;
            this.CHK_Y1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_Y1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Y1.Location = new System.Drawing.Point(26, 18);
            this.CHK_Y1.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_Y1.Name = "CHK_Y1";
            this.CHK_Y1.Size = new System.Drawing.Size(40, 18);
            this.CHK_Y1.TabIndex = 3;
            this.CHK_Y1.Text = "Y1";
            this.CHK_Y1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_Y1.UseVisualStyleBackColor = true;
            // 
            // CHK_W2
            // 
            this.CHK_W2.AutoSize = true;
            this.CHK_W2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_W2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_W2.Location = new System.Drawing.Point(66, 36);
            this.CHK_W2.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_W2.Name = "CHK_W2";
            this.CHK_W2.Size = new System.Drawing.Size(40, 18);
            this.CHK_W2.TabIndex = 4;
            this.CHK_W2.Text = "W2";
            this.CHK_W2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_W2.UseVisualStyleBackColor = true;
            // 
            // CHK_W1
            // 
            this.CHK_W1.AutoSize = true;
            this.CHK_W1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_W1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_W1.Location = new System.Drawing.Point(26, 36);
            this.CHK_W1.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_W1.Name = "CHK_W1";
            this.CHK_W1.Size = new System.Drawing.Size(40, 18);
            this.CHK_W1.TabIndex = 5;
            this.CHK_W1.Text = "W1";
            this.CHK_W1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_W1.UseVisualStyleBackColor = true;
            // 
            // CHK_S2
            // 
            this.CHK_S2.AutoSize = true;
            this.CHK_S2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_S2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_S2.Location = new System.Drawing.Point(66, 54);
            this.CHK_S2.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_S2.Name = "CHK_S2";
            this.CHK_S2.Size = new System.Drawing.Size(40, 18);
            this.CHK_S2.TabIndex = 6;
            this.CHK_S2.Text = "S2";
            this.CHK_S2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_S2.UseVisualStyleBackColor = true;
            // 
            // CHK_S1
            // 
            this.CHK_S1.AutoSize = true;
            this.CHK_S1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_S1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_S1.Location = new System.Drawing.Point(26, 54);
            this.CHK_S1.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_S1.Name = "CHK_S1";
            this.CHK_S1.Size = new System.Drawing.Size(40, 18);
            this.CHK_S1.TabIndex = 7;
            this.CHK_S1.Text = "S1";
            this.CHK_S1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_S1.UseVisualStyleBackColor = true;
            // 
            // FLP_FlowerFlags
            // 
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F2);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F1);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F4);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F3);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F6);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F5);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F8);
            this.FLP_FlowerFlags.Controls.Add(this.CHK_F7);
            this.FLP_FlowerFlags.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLP_FlowerFlags.Location = new System.Drawing.Point(106, 150);
            this.FLP_FlowerFlags.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_FlowerFlags.Name = "FLP_FlowerFlags";
            this.FLP_FlowerFlags.Size = new System.Drawing.Size(106, 81);
            this.FLP_FlowerFlags.TabIndex = 20;
            // 
            // CHK_F2
            // 
            this.CHK_F2.AutoSize = true;
            this.CHK_F2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F2.Location = new System.Drawing.Point(66, 0);
            this.CHK_F2.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F2.Name = "CHK_F2";
            this.CHK_F2.Size = new System.Drawing.Size(40, 18);
            this.CHK_F2.TabIndex = 0;
            this.CHK_F2.Text = "F2";
            this.CHK_F2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F2.UseVisualStyleBackColor = true;
            this.CHK_F2.Visible = false;
            // 
            // CHK_F1
            // 
            this.CHK_F1.AutoSize = true;
            this.CHK_F1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F1.Location = new System.Drawing.Point(26, 0);
            this.CHK_F1.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F1.Name = "CHK_F1";
            this.CHK_F1.Size = new System.Drawing.Size(40, 18);
            this.CHK_F1.TabIndex = 1;
            this.CHK_F1.Text = "F1";
            this.CHK_F1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F1.UseVisualStyleBackColor = true;
            this.CHK_F1.Visible = false;
            // 
            // CHK_F4
            // 
            this.CHK_F4.AutoSize = true;
            this.CHK_F4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F4.Location = new System.Drawing.Point(66, 18);
            this.CHK_F4.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F4.Name = "CHK_F4";
            this.CHK_F4.Size = new System.Drawing.Size(40, 18);
            this.CHK_F4.TabIndex = 2;
            this.CHK_F4.Text = "F4";
            this.CHK_F4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F4.UseVisualStyleBackColor = true;
            this.CHK_F4.Visible = false;
            // 
            // CHK_F3
            // 
            this.CHK_F3.AutoSize = true;
            this.CHK_F3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F3.Location = new System.Drawing.Point(26, 18);
            this.CHK_F3.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F3.Name = "CHK_F3";
            this.CHK_F3.Size = new System.Drawing.Size(40, 18);
            this.CHK_F3.TabIndex = 3;
            this.CHK_F3.Text = "F3";
            this.CHK_F3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F3.UseVisualStyleBackColor = true;
            this.CHK_F3.Visible = false;
            // 
            // CHK_F6
            // 
            this.CHK_F6.AutoSize = true;
            this.CHK_F6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F6.Location = new System.Drawing.Point(66, 36);
            this.CHK_F6.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F6.Name = "CHK_F6";
            this.CHK_F6.Size = new System.Drawing.Size(40, 18);
            this.CHK_F6.TabIndex = 4;
            this.CHK_F6.Text = "F6";
            this.CHK_F6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F6.UseVisualStyleBackColor = true;
            this.CHK_F6.Visible = false;
            // 
            // CHK_F5
            // 
            this.CHK_F5.AutoSize = true;
            this.CHK_F5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F5.Location = new System.Drawing.Point(26, 36);
            this.CHK_F5.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F5.Name = "CHK_F5";
            this.CHK_F5.Size = new System.Drawing.Size(40, 18);
            this.CHK_F5.TabIndex = 5;
            this.CHK_F5.Text = "F5";
            this.CHK_F5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F5.UseVisualStyleBackColor = true;
            this.CHK_F5.Visible = false;
            // 
            // CHK_F8
            // 
            this.CHK_F8.AutoSize = true;
            this.CHK_F8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F8.Location = new System.Drawing.Point(31, 54);
            this.CHK_F8.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F8.Name = "CHK_F8";
            this.CHK_F8.Size = new System.Drawing.Size(75, 18);
            this.CHK_F8.TabIndex = 6;
            this.CHK_F8.Text = "Watered";
            this.CHK_F8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F8.UseVisualStyleBackColor = true;
            // 
            // CHK_F7
            // 
            this.CHK_F7.AutoSize = true;
            this.CHK_F7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F7.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_F7.Location = new System.Drawing.Point(66, 72);
            this.CHK_F7.Margin = new System.Windows.Forms.Padding(0);
            this.CHK_F7.Name = "CHK_F7";
            this.CHK_F7.Size = new System.Drawing.Size(40, 18);
            this.CHK_F7.TabIndex = 7;
            this.CHK_F7.Text = "F7";
            this.CHK_F7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CHK_F7.UseVisualStyleBackColor = true;
            this.CHK_F7.Visible = false;
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLP_Controls);
            this.Name = "ItemEditor";
            this.Size = new System.Drawing.Size(252, 330);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Uses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Flag0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Flag1)).EndInit();
            this.CM_Hand.ResumeLayout(false);
            this.FLP_Controls.ResumeLayout(false);
            this.FLP_Count.ResumeLayout(false);
            this.FLP_Count.PerformLayout();
            this.FLP_Uses.ResumeLayout(false);
            this.FLP_Uses.PerformLayout();
            this.FLP_Flag0.ResumeLayout(false);
            this.FLP_Flag0.PerformLayout();
            this.FLP_Flag1.ResumeLayout(false);
            this.FLP_Flag1.PerformLayout();
            this.FLP_Genetics.ResumeLayout(false);
            this.FLP_Genetics.PerformLayout();
            this.FLP_FlowerFlags.ResumeLayout(false);
            this.FLP_FlowerFlags.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_ItemID;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.Label L_Uses;
        private System.Windows.Forms.NumericUpDown NUD_Uses;
        private System.Windows.Forms.Label L_Flag0;
        private System.Windows.Forms.NumericUpDown NUD_Flag0;
        private System.Windows.Forms.Label L_Flag1;
        private System.Windows.Forms.NumericUpDown NUD_Flag1;
        private System.Windows.Forms.ContextMenuStrip CM_Hand;
        private System.Windows.Forms.ToolStripMenuItem Menu_View;
        private System.Windows.Forms.ToolStripMenuItem Menu_Set;
        private System.Windows.Forms.ToolStripMenuItem Menu_Delete;
        private System.Windows.Forms.ComboBox CB_NamedItemArgument;
        private System.Windows.Forms.FlowLayoutPanel FLP_Controls;
        private System.Windows.Forms.FlowLayoutPanel FLP_Count;
        private System.Windows.Forms.FlowLayoutPanel FLP_Uses;
        private System.Windows.Forms.FlowLayoutPanel FLP_Flag0;
        private System.Windows.Forms.FlowLayoutPanel FLP_Flag1;
        private System.Windows.Forms.FlowLayoutPanel FLP_Genetics;
        private System.Windows.Forms.CheckBox CHK_R2;
        private System.Windows.Forms.CheckBox CHK_R1;
        private System.Windows.Forms.CheckBox CHK_Y2;
        private System.Windows.Forms.CheckBox CHK_Y1;
        private System.Windows.Forms.CheckBox CHK_W2;
        private System.Windows.Forms.CheckBox CHK_W1;
        private System.Windows.Forms.CheckBox CHK_S2;
        private System.Windows.Forms.CheckBox CHK_S1;
        private System.Windows.Forms.FlowLayoutPanel FLP_FlowerFlags;
        private System.Windows.Forms.CheckBox CHK_F2;
        private System.Windows.Forms.CheckBox CHK_F1;
        private System.Windows.Forms.CheckBox CHK_F4;
        private System.Windows.Forms.CheckBox CHK_F3;
        private System.Windows.Forms.CheckBox CHK_F6;
        private System.Windows.Forms.CheckBox CHK_F5;
        private System.Windows.Forms.CheckBox CHK_F8;
        private System.Windows.Forms.CheckBox CHK_F7;
    }
}
