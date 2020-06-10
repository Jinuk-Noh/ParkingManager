namespace 주차관리_프로그램_연습
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_select = new System.Windows.Forms.TextBox();
            this.metroPanel_search = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.textBox_spotNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTile_out = new MetroFramework.Controls.MetroTile();
            this.metroTile_park = new MetroFramework.Controls.MetroTile();
            this.metroTile_addParkingSpot = new MetroFramework.Controls.MetroTile();
            this.metroTile_deleteSpot = new MetroFramework.Controls.MetroTile();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel_search.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(24, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(566, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(546, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(24, 488);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(966, 112);
            this.listBox1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "선택",
            "공간번호",
            "차량번호",
            "차주이름",
            "전화번호"});
            this.metroComboBox1.Location = new System.Drawing.Point(25, 142);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(78, 29);
            this.metroComboBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(123, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "전화번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(123, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "차주이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(123, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "차량번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(123, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "공간번호";
            // 
            // textBox_select
            // 
            this.textBox_select.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_select.Location = new System.Drawing.Point(111, 142);
            this.textBox_select.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_select.Name = "textBox_select";
            this.textBox_select.Size = new System.Drawing.Size(238, 26);
            this.textBox_select.TabIndex = 1;
            // 
            // metroPanel_search
            // 
            this.metroPanel_search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.metroPanel_search.Controls.Add(this.label1);
            this.metroPanel_search.Controls.Add(this.label2);
            this.metroPanel_search.Controls.Add(this.label3);
            this.metroPanel_search.Controls.Add(this.label4);
            this.metroPanel_search.Controls.Add(this.metroComboBox1);
            this.metroPanel_search.Controls.Add(this.label8);
            this.metroPanel_search.Controls.Add(this.label7);
            this.metroPanel_search.Controls.Add(this.label5);
            this.metroPanel_search.Controls.Add(this.label6);
            this.metroPanel_search.Controls.Add(this.textBox_select);
            this.metroPanel_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroPanel_search.CustomBackground = true;
            this.metroPanel_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel_search.HorizontalScrollbarBarColor = true;
            this.metroPanel_search.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_search.HorizontalScrollbarSize = 9;
            this.metroPanel_search.Location = new System.Drawing.Point(598, 77);
            this.metroPanel_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroPanel_search.Name = "metroPanel_search";
            this.metroPanel_search.Size = new System.Drawing.Size(382, 177);
            this.metroPanel_search.TabIndex = 8;
            this.metroPanel_search.VerticalScrollbarBarColor = true;
            this.metroPanel_search.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_search.VerticalScrollbarSize = 10;
            this.metroPanel_search.Click += new System.EventHandler(this.metroPanel_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "공간번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "차량번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "차주이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "전화번호";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SkyBlue;
            this.label15.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 146);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "전화번호";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.SkyBlue;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 114);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "차주이름";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.SkyBlue;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(15, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "차량번호";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SkyBlue;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(15, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "공간번호";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(102, 143);
            this.textBox_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(227, 21);
            this.textBox_phoneNumber.TabIndex = 18;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(102, 111);
            this.textBox_driverName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(227, 21);
            this.textBox_driverName.TabIndex = 17;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(102, 78);
            this.textBox_carNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(227, 21);
            this.textBox_carNumber.TabIndex = 16;
            // 
            // textBox_spotNumber
            // 
            this.textBox_spotNumber.Location = new System.Drawing.Point(102, 46);
            this.textBox_spotNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_spotNumber.Name = "textBox_spotNumber";
            this.textBox_spotNumber.Size = new System.Drawing.Size(227, 21);
            this.textBox_spotNumber.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("굴림", 30F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(368, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 40);
            this.label9.TabIndex = 20;
            this.label9.Text = "label11";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.SkyBlue;
            this.metroPanel2.Controls.Add(this.metroTile_out);
            this.metroPanel2.Controls.Add(this.metroTile_park);
            this.metroPanel2.Controls.Add(this.label9);
            this.metroPanel2.Controls.Add(this.label18);
            this.metroPanel2.Controls.Add(this.label17);
            this.metroPanel2.Controls.Add(this.textBox_phoneNumber);
            this.metroPanel2.Controls.Add(this.label16);
            this.metroPanel2.Controls.Add(this.textBox_driverName);
            this.metroPanel2.Controls.Add(this.label15);
            this.metroPanel2.Controls.Add(this.textBox_carNumber);
            this.metroPanel2.Controls.Add(this.textBox_spotNumber);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.ForeColor = System.Drawing.Color.Black;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 9;
            this.metroPanel2.Location = new System.Drawing.Point(24, 77);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(566, 177);
            this.metroPanel2.TabIndex = 22;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTile_out
            // 
            this.metroTile_out.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroTile_out.CustomBackground = true;
            this.metroTile_out.CustomForeColor = true;
            this.metroTile_out.ForeColor = System.Drawing.Color.Black;
            this.metroTile_out.Location = new System.Drawing.Point(452, 78);
            this.metroTile_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile_out.Name = "metroTile_out";
            this.metroTile_out.Size = new System.Drawing.Size(90, 90);
            this.metroTile_out.TabIndex = 23;
            this.metroTile_out.Text = "출차";
            this.metroTile_out.TileImage = global::주차관리_프로그램_연습.Properties.Resources._out;
            this.metroTile_out.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_out.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_out.UseTileImage = true;
            this.metroTile_out.Click += new System.EventHandler(this.metroTile_out_Click);
            // 
            // metroTile_park
            // 
            this.metroTile_park.BackColor = System.Drawing.Color.SteelBlue;
            this.metroTile_park.CustomBackground = true;
            this.metroTile_park.CustomForeColor = true;
            this.metroTile_park.ForeColor = System.Drawing.Color.Black;
            this.metroTile_park.Location = new System.Drawing.Point(346, 78);
            this.metroTile_park.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile_park.Name = "metroTile_park";
            this.metroTile_park.Size = new System.Drawing.Size(90, 90);
            this.metroTile_park.TabIndex = 22;
            this.metroTile_park.Text = "주차";
            this.metroTile_park.TileImage = global::주차관리_프로그램_연습.Properties.Resources.park;
            this.metroTile_park.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_park.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_park.UseTileImage = true;
            this.metroTile_park.Click += new System.EventHandler(this.metroTile_park_Click);
            // 
            // metroTile_addParkingSpot
            // 
            this.metroTile_addParkingSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.metroTile_addParkingSpot.CustomBackground = true;
            this.metroTile_addParkingSpot.Location = new System.Drawing.Point(598, 267);
            this.metroTile_addParkingSpot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile_addParkingSpot.Name = "metroTile_addParkingSpot";
            this.metroTile_addParkingSpot.Size = new System.Drawing.Size(190, 209);
            this.metroTile_addParkingSpot.TabIndex = 23;
            this.metroTile_addParkingSpot.Text = "주차공간 추가";
            this.metroTile_addParkingSpot.TileImage = global::주차관리_프로그램_연습.Properties.Resources.add;
            this.metroTile_addParkingSpot.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_addParkingSpot.UseTileImage = true;
            this.metroTile_addParkingSpot.Click += new System.EventHandler(this.metroTile_addParkingSpot_Click);
            // 
            // metroTile_deleteSpot
            // 
            this.metroTile_deleteSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.metroTile_deleteSpot.CustomBackground = true;
            this.metroTile_deleteSpot.Location = new System.Drawing.Point(794, 267);
            this.metroTile_deleteSpot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroTile_deleteSpot.Name = "metroTile_deleteSpot";
            this.metroTile_deleteSpot.Size = new System.Drawing.Size(190, 209);
            this.metroTile_deleteSpot.TabIndex = 24;
            this.metroTile_deleteSpot.Text = "주차공간 없애기";
            this.metroTile_deleteSpot.TileImage = global::주차관리_프로그램_연습.Properties.Resources.delete1;
            this.metroTile_deleteSpot.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_deleteSpot.UseTileImage = true;
            this.metroTile_deleteSpot.Click += new System.EventHandler(this.metroTile_deleteSpot_Click);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "parkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "parkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "carNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "carNumber";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "driverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "driverName";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "parkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "parkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(주차관리_프로그램_연습.Car);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1018, 607);
            this.Controls.Add(this.metroTile_deleteSpot);
            this.Controls.Add(this.metroTile_addParkingSpot);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel_search);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "주차관리";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel_search.ResumeLayout(false);
            this.metroPanel_search.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TextBox textBox_select;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.TextBox textBox_spotNumber;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile metroTile_addParkingSpot;
        private MetroFramework.Controls.MetroTile metroTile_deleteSpot;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTile_out;
        private MetroFramework.Controls.MetroTile metroTile_park;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroPanel metroPanel_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

