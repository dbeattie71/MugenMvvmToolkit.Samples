﻿namespace Binding.WinForms.Views
{
    partial class BindingModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingModeView));
            this.label1 = new System.Windows.Forms.Label();
            this.oneTimeTb = new System.Windows.Forms.TextBox();
            this.oneWayTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oneWaySrcTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.twoWayTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.twoWayDelayTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.viewBinder = new Binding.WinForms.ViewBinder(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewBinder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "One time binding: ";
            // 
            // oneTimeTb
            // 
            this.oneTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneTimeTb.Location = new System.Drawing.Point(15, 25);
            this.oneTimeTb.Name = "oneTimeTb";
            this.oneTimeTb.Size = new System.Drawing.Size(433, 20);
            this.oneTimeTb.TabIndex = 1;
            // 
            // oneWayTb
            // 
            this.oneWayTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneWayTb.Location = new System.Drawing.Point(15, 67);
            this.oneWayTb.Name = "oneWayTb";
            this.oneWayTb.Size = new System.Drawing.Size(433, 20);
            this.oneWayTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "One way binding: ";
            // 
            // oneWaySrcTb
            // 
            this.oneWaySrcTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneWaySrcTb.Location = new System.Drawing.Point(15, 106);
            this.oneWaySrcTb.Name = "oneWaySrcTb";
            this.oneWaySrcTb.Size = new System.Drawing.Size(433, 20);
            this.oneWaySrcTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "One way to source binding: ";
            // 
            // twoWayTb
            // 
            this.twoWayTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoWayTb.Location = new System.Drawing.Point(15, 146);
            this.twoWayTb.Name = "twoWayTb";
            this.twoWayTb.Size = new System.Drawing.Size(433, 20);
            this.twoWayTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Two way binding: ";
            // 
            // twoWayDelayTb
            // 
            this.twoWayDelayTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoWayDelayTb.Location = new System.Drawing.Point(15, 185);
            this.twoWayDelayTb.Name = "twoWayDelayTb";
            this.twoWayDelayTb.Size = new System.Drawing.Size(433, 20);
            this.twoWayDelayTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Two way binding with delay 1000: ";
            // 
            // viewBinder
            // 
            this.viewBinder.Bindings = resources.GetString("viewBinder.Bindings");
            this.viewBinder.ContainerControl = this;
            this.viewBinder.IgnoreControlException = true;
            this.viewBinder.RootTagName = "Bindings";
            // 
            // BindingModeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 266);
            this.Controls.Add(this.twoWayDelayTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.twoWayTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oneWaySrcTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oneWayTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oneTimeTb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindingModeView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mugen MVVM Application";
            ((System.ComponentModel.ISupportInitialize)(this.viewBinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oneTimeTb;
        private Binding.WinForms.ViewBinder viewBinder;
        private System.Windows.Forms.TextBox twoWayDelayTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twoWayTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oneWaySrcTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oneWayTb;
        private System.Windows.Forms.Label label2;
    }
}