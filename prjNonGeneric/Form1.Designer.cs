
namespace prjNonGeneric
{
    partial class frmNonGeneric
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstDictionary = new System.Windows.Forms.ListBox();
            this.lstHashset = new System.Windows.Forms.ListBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(47, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lstDictionary
            // 
            this.lstDictionary.FormattingEnabled = true;
            this.lstDictionary.ItemHeight = 15;
            this.lstDictionary.Location = new System.Drawing.Point(13, 57);
            this.lstDictionary.Name = "lstDictionary";
            this.lstDictionary.Size = new System.Drawing.Size(164, 124);
            this.lstDictionary.TabIndex = 1;
            // 
            // lstHashset
            // 
            this.lstHashset.FormattingEnabled = true;
            this.lstHashset.ItemHeight = 15;
            this.lstHashset.Location = new System.Drawing.Point(183, 57);
            this.lstHashset.Name = "lstHashset";
            this.lstHashset.Size = new System.Drawing.Size(164, 124);
            this.lstHashset.TabIndex = 2;
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.ItemHeight = 15;
            this.lstQueue.Location = new System.Drawing.Point(353, 57);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(164, 124);
            this.lstQueue.TabIndex = 3;
            // 
            // frmNonGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 201);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.lstHashset);
            this.Controls.Add(this.lstDictionary);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmNonGeneric";
            this.Text = "Non Generic";
            this.Load += new System.EventHandler(this.frmNonGeneric_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lstDictionary;
        private System.Windows.Forms.ListBox lstHashset;
        private System.Windows.Forms.ListBox lstQueue;
    }
}

