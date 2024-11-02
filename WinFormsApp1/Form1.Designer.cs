namespace WinFormsApp1
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
            btnShowMessage = new Button();
            btnOpenNonModal = new Button();
            btnOpenModal = new Button();
            SuspendLayout();
            // 
            // btnShowMessage
            // 
            btnShowMessage.Location = new Point(29, 40);
            btnShowMessage.Name = "btnShowMessage";
            btnShowMessage.Size = new Size(171, 34);
            btnShowMessage.TabIndex = 0;
            btnShowMessage.Text = "Показать сообщение";
            btnShowMessage.UseVisualStyleBackColor = true;
            // 
            // btnOpenNonModal
            // 
            btnOpenNonModal.Location = new Point(29, 80);
            btnOpenNonModal.Name = "btnOpenNonModal";
            btnOpenNonModal.Size = new Size(171, 37);
            btnOpenNonModal.TabIndex = 1;
            btnOpenNonModal.Text = "Открыть немодальное окно";
            btnOpenNonModal.UseVisualStyleBackColor = true;
            // 
            // btnOpenModal
            // 
            btnOpenModal.Location = new Point(29, 123);
            btnOpenModal.Name = "btnOpenModal";
            btnOpenModal.Size = new Size(171, 38);
            btnOpenModal.TabIndex = 2;
            btnOpenModal.Text = "Открыть модальное окно";
            btnOpenModal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(400, 300);
            Controls.Add(btnOpenModal);
            Controls.Add(btnOpenNonModal);
            Controls.Add(btnShowMessage);
            Name = "Form1";
            Text = "My Application";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowMessage;
        private Button btnOpenNonModal;
        private Button btnOpenModal;
    }
}
