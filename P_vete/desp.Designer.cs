namespace P_vete
{
    partial class frmdesp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdesp));
            this.veterinariaDataSet = new P_vete.VeterinariaDataSet();
            this.t_desparacitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_desparacitacionTableAdapter = new P_vete.VeterinariaDataSetTableAdapters.t_desparacitacionTableAdapter();
            this.tableAdapterManager = new P_vete.VeterinariaDataSetTableAdapters.TableAdapterManager();
            this.t_desparacitacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_desparacitacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.t_desparacitacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionBindingNavigator)).BeginInit();
            this.t_desparacitacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // veterinariaDataSet
            // 
            this.veterinariaDataSet.DataSetName = "VeterinariaDataSet";
            this.veterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_desparacitacionBindingSource
            // 
            this.t_desparacitacionBindingSource.DataMember = "t_desparacitacion";
            this.t_desparacitacionBindingSource.DataSource = this.veterinariaDataSet;
            // 
            // t_desparacitacionTableAdapter
            // 
            this.t_desparacitacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_clienteTableAdapter = null;
            this.tableAdapterManager.t_desparacitacionTableAdapter = this.t_desparacitacionTableAdapter;
            this.tableAdapterManager.t_mascotaTableAdapter = null;
            this.tableAdapterManager.t_vacunasTableAdapter = null;
            this.tableAdapterManager.t_veterinarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = P_vete.VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_desparacitacionBindingNavigator
            // 
            this.t_desparacitacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_desparacitacionBindingNavigator.BindingSource = this.t_desparacitacionBindingSource;
            this.t_desparacitacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_desparacitacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_desparacitacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_desparacitacionBindingNavigatorSaveItem});
            this.t_desparacitacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_desparacitacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_desparacitacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_desparacitacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_desparacitacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_desparacitacionBindingNavigator.Name = "t_desparacitacionBindingNavigator";
            this.t_desparacitacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_desparacitacionBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.t_desparacitacionBindingNavigator.TabIndex = 0;
            this.t_desparacitacionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_desparacitacionDataGridView
            // 
            this.t_desparacitacionDataGridView.AutoGenerateColumns = false;
            this.t_desparacitacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_desparacitacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.t_desparacitacionDataGridView.DataSource = this.t_desparacitacionBindingSource;
            this.t_desparacitacionDataGridView.Location = new System.Drawing.Point(106, 115);
            this.t_desparacitacionDataGridView.Name = "t_desparacitacionDataGridView";
            this.t_desparacitacionDataGridView.Size = new System.Drawing.Size(647, 220);
            this.t_desparacitacionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_desp";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_desp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "veterinario";
            this.dataGridViewTextBoxColumn2.HeaderText = "veterinario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mascota";
            this.dataGridViewTextBoxColumn3.HeaderText = "mascota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_veterinario";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_veterinario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_mascota";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_mascota";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
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
            // t_desparacitacionBindingNavigatorSaveItem
            // 
            this.t_desparacitacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_desparacitacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_desparacitacionBindingNavigatorSaveItem.Image")));
            this.t_desparacitacionBindingNavigatorSaveItem.Name = "t_desparacitacionBindingNavigatorSaveItem";
            this.t_desparacitacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_desparacitacionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.t_desparacitacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_desparacitacionBindingNavigatorSaveItem_Click);
            // 
            // frmdesp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t_desparacitacionDataGridView);
            this.Controls.Add(this.t_desparacitacionBindingNavigator);
            this.Name = "frmdesp";
            this.Text = "desp";
            this.Load += new System.EventHandler(this.desp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionBindingNavigator)).EndInit();
            this.t_desparacitacionBindingNavigator.ResumeLayout(false);
            this.t_desparacitacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_desparacitacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VeterinariaDataSet veterinariaDataSet;
        private System.Windows.Forms.BindingSource t_desparacitacionBindingSource;
        private VeterinariaDataSetTableAdapters.t_desparacitacionTableAdapter t_desparacitacionTableAdapter;
        private VeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_desparacitacionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_desparacitacionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_desparacitacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}