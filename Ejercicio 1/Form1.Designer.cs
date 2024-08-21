namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncuesta = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncuesta
            // 
            this.btnEncuesta.Location = new System.Drawing.Point(162, 18);
            this.btnEncuesta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncuesta.Name = "btnEncuesta";
            this.btnEncuesta.Size = new System.Drawing.Size(270, 75);
            this.btnEncuesta.TabIndex = 0;
            this.btnEncuesta.Text = "Registrar Encuesta";
            this.btnEncuesta.UseVisualStyleBackColor = true;
            this.btnEncuesta.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(162, 136);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(270, 75);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Resultados";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(162, 260);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(270, 75);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "LIstado Contactables";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 356);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnEncuesta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Secretaria de Transporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncuesta;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnList;
    }
}

