using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_dos_Animais
{
    public class FrmAprende
    {
        private Form _formAprende;
        private string _texto;
        private Label _labelAprende;
        private TextBox _textBoxAprende;
        private Button _buttonAprende;

        public FrmAprende(string texto)
        {
            this._texto = texto;
        }

        public string MostraForm()
        {
            this._formAprende = new Form();
            this._labelAprende = new Label();
            this._textBoxAprende = new TextBox();
            this._buttonAprende = new Button();
            
            #region Label
            this._labelAprende.AutoSize = true;
            this._labelAprende.Location = new Point(3, 13);
            this._labelAprende.Name = "lblAprende";
            this._labelAprende.Text = this._texto;
            this._labelAprende.Size = new Size(35, 13);
            #endregion

            #region TextBox
            this._textBoxAprende.Location = new Point(3, 31);
            this._textBoxAprende.Name = "txtAprende";
            this._textBoxAprende.Size = new Size(215, 20);
            this._textBoxAprende.TabIndex = 0;
            #endregion

            #region Button
            this._buttonAprende.Location = new Point(230, 27);
            this._buttonAprende.Name = "btnAprende";
            this._buttonAprende.Size = new Size(75, 23);
            this._buttonAprende.Text = "Sair";
            this._buttonAprende.Click += (sender, e) => { this._formAprende.Close(); };
            #endregion

            #region Form
            this._formAprende.Width = 320;
            this._formAprende.Height = 80;
            this._formAprende.ShowIcon = false;
            this._formAprende.SizeGripStyle = SizeGripStyle.Hide;
            this._formAprende.ShowInTaskbar = false;
            this._formAprende.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this._formAprende.Text = "Caixa de Dialogo";
            this._formAprende.StartPosition = FormStartPosition.CenterScreen;
            this._formAprende.Controls.Add(this._buttonAprende);
            this._formAprende.Controls.Add(this._labelAprende);
            this._formAprende.Controls.Add(this._textBoxAprende);
            #endregion

            this._formAprende.ShowDialog();

            return this._textBoxAprende.Text;
        }
    }
}
