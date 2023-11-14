namespace com.system.payment.Presentation.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._selectPaymentSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _selectPaymentSystemButton
            // 
            this._selectPaymentSystemButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._selectPaymentSystemButton.Location = new System.Drawing.Point(12, 168);
            this._selectPaymentSystemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._selectPaymentSystemButton.Name = "_selectPaymentSystemButton";
            this._selectPaymentSystemButton.Size = new System.Drawing.Size(360, 61);
            this._selectPaymentSystemButton.TabIndex = 0;
            this._selectPaymentSystemButton.Text = "Выбрать способ оплаты";
            this._selectPaymentSystemButton.UseVisualStyleBackColor = true;
            this._selectPaymentSystemButton.Click += new System.EventHandler(this.OnSelectPaymentSystemButtonClick);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 474);
            this.Controls.Add(this._selectPaymentSystemButton);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _selectPaymentSystemButton;

        #endregion
    }
}

