﻿namespace BlueSheep.Interface.UCs
{
    partial class GestItemsUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.litPopup = new System.Windows.Forms.ListBox();
            this.ItemTxtBox = new System.Windows.Forms.TextBox();
            this.LVGestItems = new System.Windows.Forms.ListView();
            this.ActionChoiceCombo = new BlueSheep.Interface.SadikCombo();
            this.AddBt = new BlueSheep.Interface.SadikButton();
            this.sadikLabel1 = new BlueSheep.Interface.SadikLabel();
            this.NUDAutoDeletion = new System.Windows.Forms.NumericUpDown();
            this.AutoDeletionBox = new BlueSheep.Interface.SadikCheckbox();
            this.sadikLabel2 = new BlueSheep.Interface.SadikLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAutoDeletion)).BeginInit();
            this.SuspendLayout();
            // 
            // litPopup
            // 
            this.litPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litPopup.FormattingEnabled = true;
            this.litPopup.ItemHeight = 15;
            this.litPopup.Location = new System.Drawing.Point(148, 82);
            this.litPopup.Name = "litPopup";
            this.litPopup.Size = new System.Drawing.Size(27, 64);
            this.litPopup.TabIndex = 30;
            this.litPopup.Visible = false;
            // 
            // ItemTxtBox
            // 
            this.ItemTxtBox.Location = new System.Drawing.Point(16, 20);
            this.ItemTxtBox.Name = "ItemTxtBox";
            this.ItemTxtBox.Size = new System.Drawing.Size(292, 20);
            this.ItemTxtBox.TabIndex = 29;
            this.ItemTxtBox.Text = "Entrez le nom d\'un item...";
            this.ItemTxtBox.GotFocus += new System.EventHandler(this.ItemTxtBox_GotFocus);
            this.ItemTxtBox.LostFocus += new System.EventHandler(this.ItemTxtBox_LostFocus);
            // 
            // LVGestItems
            // 
            this.LVGestItems.Location = new System.Drawing.Point(16, 82);
            this.LVGestItems.Name = "LVGestItems";
            this.LVGestItems.Size = new System.Drawing.Size(375, 153);
            this.LVGestItems.TabIndex = 28;
            this.LVGestItems.UseCompatibleStateImageBehavior = false;
            this.LVGestItems.View = System.Windows.Forms.View.Details;
            // 
            // ActionChoiceCombo
            // 
            this.ActionChoiceCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ActionChoiceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionChoiceCombo.Font = new System.Drawing.Font("Verdana", 8F);
            this.ActionChoiceCombo.FormattingEnabled = true;
            this.ActionChoiceCombo.ItemHeight = 20;
            this.ActionChoiceCombo.Items.AddRange(new object[] {
            "Suppression automatique",
            "Retirer de la banque",
            "Ne pas déposer en banque"});
            this.ActionChoiceCombo.Location = new System.Drawing.Point(83, 46);
            this.ActionChoiceCombo.Name = "ActionChoiceCombo";
            this.ActionChoiceCombo.Size = new System.Drawing.Size(182, 26);
            this.ActionChoiceCombo.TabIndex = 31;
            // 
            // AddBt
            // 
            this.AddBt.ButtonStyle = BlueSheep.Interface.SadikButton.Style.Blue;
            this.AddBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.AddBt.Image = null;
            this.AddBt.Location = new System.Drawing.Point(271, 46);
            this.AddBt.Name = "AddBt";
            this.AddBt.RoundedCorners = false;
            this.AddBt.Size = new System.Drawing.Size(120, 26);
            this.AddBt.TabIndex = 32;
            this.AddBt.Text = "Ajouter";
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // sadikLabel1
            // 
            this.sadikLabel1.AutoSize = true;
            this.sadikLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel1.Location = new System.Drawing.Point(26, 49);
            this.sadikLabel1.Name = "sadikLabel1";
            this.sadikLabel1.Size = new System.Drawing.Size(51, 13);
            this.sadikLabel1.TabIndex = 33;
            this.sadikLabel1.Text = "Action :";
            // 
            // NUDAutoDeletion
            // 
            this.NUDAutoDeletion.Location = new System.Drawing.Point(257, 241);
            this.NUDAutoDeletion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDAutoDeletion.Name = "NUDAutoDeletion";
            this.NUDAutoDeletion.Size = new System.Drawing.Size(35, 20);
            this.NUDAutoDeletion.TabIndex = 34;
            this.NUDAutoDeletion.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDAutoDeletion.ValueChanged += new System.EventHandler(this.NUDAutoDeletion_ValueChanged);
            // 
            // AutoDeletionBox
            // 
            this.AutoDeletionBox.Checked = false;
            this.AutoDeletionBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.AutoDeletionBox.Location = new System.Drawing.Point(16, 241);
            this.AutoDeletionBox.Name = "AutoDeletionBox";
            this.AutoDeletionBox.Size = new System.Drawing.Size(235, 20);
            this.AutoDeletionBox.TabIndex = 35;
            this.AutoDeletionBox.Text = "Suppression automatique toutes les ";
            this.AutoDeletionBox.CheckedChanged += new BlueSheep.Interface.SadikCheckbox.CheckedChangedEventHandler(this.AutoDeletionBox_CheckedChanged);
            // 
            // sadikLabel2
            // 
            this.sadikLabel2.AutoSize = true;
            this.sadikLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel2.Location = new System.Drawing.Point(298, 243);
            this.sadikLabel2.Name = "sadikLabel2";
            this.sadikLabel2.Size = new System.Drawing.Size(56, 13);
            this.sadikLabel2.TabIndex = 36;
            this.sadikLabel2.Text = "minutes.";
            // 
            // GestItemsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sadikLabel2);
            this.Controls.Add(this.AutoDeletionBox);
            this.Controls.Add(this.NUDAutoDeletion);
            this.Controls.Add(this.sadikLabel1);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.ActionChoiceCombo);
            this.Controls.Add(this.litPopup);
            this.Controls.Add(this.ItemTxtBox);
            this.Controls.Add(this.LVGestItems);
            this.Name = "GestItemsUC";
            this.Size = new System.Drawing.Size(410, 283);
            ((System.ComponentModel.ISupportInitialize)(this.NUDAutoDeletion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox litPopup;
        private System.Windows.Forms.TextBox ItemTxtBox;
        private System.Windows.Forms.ListView LVGestItems;
        private SadikCombo ActionChoiceCombo;
        private SadikButton AddBt;
        private SadikLabel sadikLabel1;
        private System.Windows.Forms.NumericUpDown NUDAutoDeletion;
        private SadikCheckbox AutoDeletionBox;
        private SadikLabel sadikLabel2;
    }
}
