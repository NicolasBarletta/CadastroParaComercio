namespace CozinhaDaCelina
{
    partial class addProduto
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label validadeLabel;
            System.Windows.Forms.Label mercadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduto));
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdclientesDataSet = new CozinhaDaCelina.bdclientesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.validadeTextBox = new System.Windows.Forms.TextBox();
            this.mercadoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            validadeLabel = new System.Windows.Forms.Label();
            mercadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdclientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Location = new System.Drawing.Point(104, 122);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(85, 54);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            marcaLabel.Location = new System.Drawing.Point(98, 180);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(91, 54);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            quantidadeLabel.Location = new System.Drawing.Point(45, 249);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(144, 54);
            quantidadeLabel.TabIndex = 7;
            quantidadeLabel.Text = "Quantidade:";
            quantidadeLabel.Click += new System.EventHandler(this.quantidadeLabel_Click);
            // 
            // validadeLabel
            // 
            validadeLabel.AutoSize = true;
            validadeLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            validadeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            validadeLabel.Location = new System.Drawing.Point(75, 319);
            validadeLabel.Name = "validadeLabel";
            validadeLabel.Size = new System.Drawing.Size(114, 54);
            validadeLabel.TabIndex = 9;
            validadeLabel.Text = "Validade:";
            // 
            // mercadoLabel
            // 
            mercadoLabel.AutoSize = true;
            mercadoLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mercadoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            mercadoLabel.Location = new System.Drawing.Point(75, 402);
            mercadoLabel.Name = "mercadoLabel";
            mercadoLabel.Size = new System.Drawing.Size(114, 54);
            mercadoLabel.TabIndex = 11;
            mercadoLabel.Text = "Mercado:";
            mercadoLabel.Click += new System.EventHandler(this.mercadoLabel_Click);
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bdclientesDataSet;
            // 
            // bdclientesDataSet
            // 
            this.bdclientesDataSet.DataSetName = "bdclientesDataSet";
            this.bdclientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(229, 134);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(214, 30);
            this.nomeTextBox.TabIndex = 4;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(229, 192);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(214, 30);
            this.marcaTextBox.TabIndex = 6;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeTextBox.Location = new System.Drawing.Point(229, 261);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(214, 30);
            this.quantidadeTextBox.TabIndex = 8;
            // 
            // validadeTextBox
            // 
            this.validadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Validade", true));
            this.validadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validadeTextBox.Location = new System.Drawing.Point(229, 331);
            this.validadeTextBox.Name = "validadeTextBox";
            this.validadeTextBox.Size = new System.Drawing.Size(214, 30);
            this.validadeTextBox.TabIndex = 10;
            // 
            // mercadoTextBox
            // 
            this.mercadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Mercado", true));
            this.mercadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercadoTextBox.Location = new System.Drawing.Point(229, 414);
            this.mercadoTextBox.Name = "mercadoTextBox";
            this.mercadoTextBox.Size = new System.Drawing.Size(214, 30);
            this.mercadoTextBox.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(271, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 68);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adicionar Produto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button2.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(525, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 101);
            this.button2.TabIndex = 16;
            this.button2.Text = "VISUALIZAR LISTA DE PRODUTOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button4.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(525, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 101);
            this.button4.TabIndex = 17;
            this.button4.Text = "VISUALIZAR LISTA DE CLIENTES";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(validadeLabel);
            this.Controls.Add(this.validadeTextBox);
            this.Controls.Add(mercadoLabel);
            this.Controls.Add(this.mercadoTextBox);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Name = "addProduto";
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.addProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdclientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdclientesDataSet bdclientesDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox validadeTextBox;
        private System.Windows.Forms.TextBox mercadoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}