namespace PS3Lib_Mod_Demo
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtB_GetOffset = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboB_Procs = new System.Windows.Forms.ComboBox();
            this.lblProcs = new System.Windows.Forms.Label();
            this.tabC_Global = new System.Windows.Forms.TabControl();
            this.tabP_PS3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Setup = new System.Windows.Forms.Button();
            this.btn_FileManager = new System.Windows.Forms.Button();
            this.btn_GameManager = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.p_PS3_Notify = new System.Windows.Forms.Panel();
            this.tB_PS3_Notify = new System.Windows.Forms.TextBox();
            this.btn_PS3_Notify = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.p_PS3_MimicOFW = new System.Windows.Forms.Panel();
            this.cb_RemoveHook = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_D = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P3 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P2 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P1 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_36 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_35 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_11 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_10 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_9 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_7 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_6 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cB_PS3_MIMICOFW = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_PS3_ClearHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PS3_DisableSyscall = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.p_PS3_Led = new System.Windows.Forms.Panel();
            this.cB_PS3_Led_Color = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_PS3_Led_Set = new System.Windows.Forms.Button();
            this.cB_PS3_Led_Mode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.p_PS3_Buzzer = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Ring_Buzzer = new System.Windows.Forms.Button();
            this.cB_PS3_Buzzer = new System.Windows.Forms.ComboBox();
            this.p_PS3_Power = new System.Windows.Forms.Panel();
            this.btn_Power_Execute = new System.Windows.Forms.Button();
            this.cB_PS3_Power = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Temp_Refresh = new System.Windows.Forms.Button();
            this.lbl_Temp_CPU = new System.Windows.Forms.Label();
            this.lbl_Temp_RSX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_core_version = new System.Windows.Forms.Label();
            this.lbl_fw = new System.Windows.Forms.Label();
            this.tabP_Processes = new System.Windows.Forms.TabPage();
            this.btnUnattach = new System.Windows.Forms.Button();
            this.tabC_Process = new System.Windows.Forms.TabControl();
            this.tabP_GetMem = new System.Windows.Forms.TabPage();
            this.nUD_GetLength = new System.Windows.Forms.NumericUpDown();
            this.tabP_SetMem = new System.Windows.Forms.TabPage();
            this.txtB_SetOffset = new System.Windows.Forms.TextBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.btnSetMem = new System.Windows.Forms.Button();
            this.lblOffset = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.tabP_Modules = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Module_Unload = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_Module_Load = new System.Windows.Forms.Button();
            this.tB_Module_Path = new System.Windows.Forms.TextBox();
            this.btn_Module_Refresh = new System.Windows.Forms.Button();
            this.lV_Modules = new System.Windows.Forms.ListView();
            this.cH_Modules_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Modules_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtB_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_Ip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_Connection = new System.Windows.Forms.Panel();
            this.btn_ShowLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Lib_Version = new System.Windows.Forms.Label();
            this.tabC_Global.SuspendLayout();
            this.tabP_PS3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.p_PS3_Notify.SuspendLayout();
            this.p_PS3_MimicOFW.SuspendLayout();
            this.p_PS3_Led.SuspendLayout();
            this.p_PS3_Buzzer.SuspendLayout();
            this.p_PS3_Power.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabP_Processes.SuspendLayout();
            this.tabC_Process.SuspendLayout();
            this.tabP_GetMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetLength)).BeginInit();
            this.tabP_SetMem.SuspendLayout();
            this.tabP_Modules.SuspendLayout();
            this.p_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(383, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(87, 27);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(290, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 27);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Output:\r\n";
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.Control;
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textOutput.Location = new System.Drawing.Point(3, 94);
            this.textOutput.MaxLength = 65536;
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(754, 215);
            this.textOutput.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Offset:\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetMem_Click);
            // 
            // txtB_GetOffset
            // 
            this.txtB_GetOffset.BackColor = System.Drawing.SystemColors.Control;
            this.txtB_GetOffset.Location = new System.Drawing.Point(67, 24);
            this.txtB_GetOffset.MaxLength = 32;
            this.txtB_GetOffset.Name = "txtB_GetOffset";
            this.txtB_GetOffset.Size = new System.Drawing.Size(261, 23);
            this.txtB_GetOffset.TabIndex = 13;
            this.txtB_GetOffset.Text = "0";
            this.txtB_GetOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB_GetOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // btnAttach
            // 
            this.btnAttach.Enabled = false;
            this.btnAttach.Location = new System.Drawing.Point(565, 19);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(87, 25);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(472, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 25);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboB_Procs
            // 
            this.comboB_Procs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_Procs.Enabled = false;
            this.comboB_Procs.FormattingEnabled = true;
            this.comboB_Procs.Location = new System.Drawing.Point(129, 21);
            this.comboB_Procs.MaxDropDownItems = 16;
            this.comboB_Procs.Name = "comboB_Procs";
            this.comboB_Procs.Size = new System.Drawing.Size(306, 23);
            this.comboB_Procs.TabIndex = 1;
            // 
            // lblProcs
            // 
            this.lblProcs.AutoSize = true;
            this.lblProcs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcs.Location = new System.Drawing.Point(17, 24);
            this.lblProcs.Name = "lblProcs";
            this.lblProcs.Size = new System.Drawing.Size(81, 20);
            this.lblProcs.TabIndex = 0;
            this.lblProcs.Text = "Processes:";
            // 
            // tabC_Global
            // 
            this.tabC_Global.Controls.Add(this.tabP_PS3);
            this.tabC_Global.Controls.Add(this.tabP_Processes);
            this.tabC_Global.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabC_Global.Enabled = false;
            this.tabC_Global.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC_Global.Location = new System.Drawing.Point(0, 101);
            this.tabC_Global.Name = "tabC_Global";
            this.tabC_Global.SelectedIndex = 0;
            this.tabC_Global.Size = new System.Drawing.Size(784, 448);
            this.tabC_Global.TabIndex = 25;
            // 
            // tabP_PS3
            // 
            this.tabP_PS3.BackColor = System.Drawing.Color.White;
            this.tabP_PS3.Controls.Add(this.label8);
            this.tabP_PS3.Controls.Add(this.panel3);
            this.tabP_PS3.Controls.Add(this.label20);
            this.tabP_PS3.Controls.Add(this.p_PS3_Notify);
            this.tabP_PS3.Controls.Add(this.label19);
            this.tabP_PS3.Controls.Add(this.p_PS3_MimicOFW);
            this.tabP_PS3.Controls.Add(this.label13);
            this.tabP_PS3.Controls.Add(this.p_PS3_Led);
            this.tabP_PS3.Controls.Add(this.label15);
            this.tabP_PS3.Controls.Add(this.label14);
            this.tabP_PS3.Controls.Add(this.label11);
            this.tabP_PS3.Controls.Add(this.p_PS3_Buzzer);
            this.tabP_PS3.Controls.Add(this.p_PS3_Power);
            this.tabP_PS3.Controls.Add(this.label10);
            this.tabP_PS3.Controls.Add(this.panel2);
            this.tabP_PS3.Controls.Add(this.panel1);
            this.tabP_PS3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_PS3.Location = new System.Drawing.Point(4, 26);
            this.tabP_PS3.Name = "tabP_PS3";
            this.tabP_PS3.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_PS3.Size = new System.Drawing.Size(776, 418);
            this.tabP_PS3.TabIndex = 0;
            this.tabP_PS3.Text = "PS3 Commands";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "webMAN:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Setup);
            this.panel3.Controls.Add(this.btn_FileManager);
            this.panel3.Controls.Add(this.btn_GameManager);
            this.panel3.Location = new System.Drawing.Point(263, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 39);
            this.panel3.TabIndex = 17;
            // 
            // btn_Setup
            // 
            this.btn_Setup.Location = new System.Drawing.Point(351, 6);
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(108, 24);
            this.btn_Setup.TabIndex = 18;
            this.btn_Setup.Text = "Setup";
            this.btn_Setup.UseVisualStyleBackColor = true;
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_FileManager
            // 
            this.btn_FileManager.Location = new System.Drawing.Point(39, 6);
            this.btn_FileManager.Name = "btn_FileManager";
            this.btn_FileManager.Size = new System.Drawing.Size(108, 24);
            this.btn_FileManager.TabIndex = 17;
            this.btn_FileManager.Text = "Files Manager";
            this.btn_FileManager.UseVisualStyleBackColor = true;
            this.btn_FileManager.Click += new System.EventHandler(this.btn_FileManager_Click);
            // 
            // btn_GameManager
            // 
            this.btn_GameManager.Location = new System.Drawing.Point(199, 6);
            this.btn_GameManager.Name = "btn_GameManager";
            this.btn_GameManager.Size = new System.Drawing.Size(108, 24);
            this.btn_GameManager.TabIndex = 16;
            this.btn_GameManager.Text = "Games Manager";
            this.btn_GameManager.UseVisualStyleBackColor = true;
            this.btn_GameManager.Click += new System.EventHandler(this.btn_GameManager_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(259, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "PS3 Notify:";
            // 
            // p_PS3_Notify
            // 
            this.p_PS3_Notify.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Notify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Notify.Controls.Add(this.tB_PS3_Notify);
            this.p_PS3_Notify.Controls.Add(this.btn_PS3_Notify);
            this.p_PS3_Notify.Location = new System.Drawing.Point(263, 181);
            this.p_PS3_Notify.Name = "p_PS3_Notify";
            this.p_PS3_Notify.Size = new System.Drawing.Size(504, 72);
            this.p_PS3_Notify.TabIndex = 15;
            // 
            // tB_PS3_Notify
            // 
            this.tB_PS3_Notify.BackColor = System.Drawing.SystemColors.Control;
            this.tB_PS3_Notify.Location = new System.Drawing.Point(7, 8);
            this.tB_PS3_Notify.MaxLength = 200;
            this.tB_PS3_Notify.Multiline = true;
            this.tB_PS3_Notify.Name = "tB_PS3_Notify";
            this.tB_PS3_Notify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_PS3_Notify.Size = new System.Drawing.Size(399, 53);
            this.tB_PS3_Notify.TabIndex = 16;
            // 
            // btn_PS3_Notify
            // 
            this.btn_PS3_Notify.Location = new System.Drawing.Point(412, 23);
            this.btn_PS3_Notify.Name = "btn_PS3_Notify";
            this.btn_PS3_Notify.Size = new System.Drawing.Size(87, 24);
            this.btn_PS3_Notify.TabIndex = 15;
            this.btn_PS3_Notify.Text = "Notify";
            this.btn_PS3_Notify.UseVisualStyleBackColor = true;
            this.btn_PS3_Notify.Click += new System.EventHandler(this.btn_PS3_Notify_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "PS3 Mimic OFW:";
            // 
            // p_PS3_MimicOFW
            // 
            this.p_PS3_MimicOFW.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_MimicOFW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_MimicOFW.Controls.Add(this.cb_RemoveHook);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_D);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P3);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P2);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P1);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_36);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_35);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_11);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_10);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_9);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_7);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_6);
            this.p_PS3_MimicOFW.Controls.Add(this.panel4);
            this.p_PS3_MimicOFW.Controls.Add(this.cB_PS3_MIMICOFW);
            this.p_PS3_MimicOFW.Controls.Add(this.label24);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_PS3_ClearHistory);
            this.p_PS3_MimicOFW.Controls.Add(this.label1);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_PS3_DisableSyscall);
            this.p_PS3_MimicOFW.Location = new System.Drawing.Point(10, 279);
            this.p_PS3_MimicOFW.Name = "p_PS3_MimicOFW";
            this.p_PS3_MimicOFW.Size = new System.Drawing.Size(759, 134);
            this.p_PS3_MimicOFW.TabIndex = 13;
            // 
            // cb_RemoveHook
            // 
            this.cb_RemoveHook.AutoSize = true;
            this.cb_RemoveHook.Enabled = false;
            this.cb_RemoveHook.Location = new System.Drawing.Point(559, 112);
            this.cb_RemoveHook.Name = "cb_RemoveHook";
            this.cb_RemoveHook.Size = new System.Drawing.Size(156, 19);
            this.cb_RemoveHook.TabIndex = 39;
            this.cb_RemoveHook.Text = "Also remove hook (Beta)";
            this.cb_RemoveHook.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_8_D
            // 
            this.cb_Syscall_8_D.AutoSize = true;
            this.cb_Syscall_8_D.Enabled = false;
            this.cb_Syscall_8_D.Location = new System.Drawing.Point(479, 112);
            this.cb_Syscall_8_D.Name = "cb_Syscall_8_D";
            this.cb_Syscall_8_D.Size = new System.Drawing.Size(64, 19);
            this.cb_Syscall_8_D.TabIndex = 38;
            this.cb_Syscall_8_D.Text = "Disable";
            this.cb_Syscall_8_D.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_D.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_D_CheckedChanged);
            // 
            // cb_Syscall_8_P3
            // 
            this.cb_Syscall_8_P3.AutoSize = true;
            this.cb_Syscall_8_P3.Enabled = false;
            this.cb_Syscall_8_P3.Location = new System.Drawing.Point(479, 87);
            this.cb_Syscall_8_P3.Name = "cb_Syscall_8_P3";
            this.cb_Syscall_8_P3.Size = new System.Drawing.Size(199, 19);
            this.cb_Syscall_8_P3.TabIndex = 37;
            this.cb_Syscall_8_P3.Text = "Fake Disable (Can be re-enabled)";
            this.cb_Syscall_8_P3.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P3.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P3_CheckedChanged);
            // 
            // cb_Syscall_8_P2
            // 
            this.cb_Syscall_8_P2.AutoSize = true;
            this.cb_Syscall_8_P2.Enabled = false;
            this.cb_Syscall_8_P2.Location = new System.Drawing.Point(479, 62);
            this.cb_Syscall_8_P2.Name = "cb_Syscall_8_P2";
            this.cb_Syscall_8_P2.Size = new System.Drawing.Size(218, 19);
            this.cb_Syscall_8_P2.TabIndex = 36;
            this.cb_Syscall_8_P2.Text = "Partial: Keep only PS3M_Api features";
            this.cb_Syscall_8_P2.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P2.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P2_CheckedChanged);
            // 
            // cb_Syscall_8_P1
            // 
            this.cb_Syscall_8_P1.AutoSize = true;
            this.cb_Syscall_8_P1.Enabled = false;
            this.cb_Syscall_8_P1.Location = new System.Drawing.Point(479, 37);
            this.cb_Syscall_8_P1.Name = "cb_Syscall_8_P1";
            this.cb_Syscall_8_P1.Size = new System.Drawing.Size(275, 19);
            this.cb_Syscall_8_P1.TabIndex = 35;
            this.cb_Syscall_8_P1.Text = "Partial: Keep Cobra/Mamba/PS3M_Api features";
            this.cb_Syscall_8_P1.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P1.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P1_CheckedChanged);
            // 
            // cb_Syscall_8
            // 
            this.cb_Syscall_8.AutoSize = true;
            this.cb_Syscall_8.Location = new System.Drawing.Point(463, 12);
            this.cb_Syscall_8.Name = "cb_Syscall_8";
            this.cb_Syscall_8.Size = new System.Drawing.Size(252, 19);
            this.cb_Syscall_8.TabIndex = 34;
            this.cb_Syscall_8.Text = "[8] COBRA/MAMBA/PS3M_API/EXTENDED";
            this.cb_Syscall_8.UseVisualStyleBackColor = true;
            this.cb_Syscall_8.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_CheckedChanged);
            // 
            // cb_Syscall_36
            // 
            this.cb_Syscall_36.AutoSize = true;
            this.cb_Syscall_36.Location = new System.Drawing.Point(281, 112);
            this.cb_Syscall_36.Name = "cb_Syscall_36";
            this.cb_Syscall_36.Size = new System.Drawing.Size(107, 19);
            this.cb_Syscall_36.TabIndex = 33;
            this.cb_Syscall_36.Text = "[36] Map Game";
            this.cb_Syscall_36.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_35
            // 
            this.cb_Syscall_35.AutoSize = true;
            this.cb_Syscall_35.Location = new System.Drawing.Point(345, 87);
            this.cb_Syscall_35.Name = "cb_Syscall_35";
            this.cb_Syscall_35.Size = new System.Drawing.Size(100, 19);
            this.cb_Syscall_35.TabIndex = 32;
            this.cb_Syscall_35.Text = "[35] Map Path";
            this.cb_Syscall_35.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_11
            // 
            this.cb_Syscall_11.AutoSize = true;
            this.cb_Syscall_11.Location = new System.Drawing.Point(345, 62);
            this.cb_Syscall_11.Name = "cb_Syscall_11";
            this.cb_Syscall_11.Size = new System.Drawing.Size(96, 19);
            this.cb_Syscall_11.TabIndex = 31;
            this.cb_Syscall_11.Text = "[11] LV1 Peek";
            this.cb_Syscall_11.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_10
            // 
            this.cb_Syscall_10.AutoSize = true;
            this.cb_Syscall_10.Location = new System.Drawing.Point(345, 37);
            this.cb_Syscall_10.Name = "cb_Syscall_10";
            this.cb_Syscall_10.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_10.TabIndex = 30;
            this.cb_Syscall_10.Text = "[10] LV1 Call";
            this.cb_Syscall_10.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_9
            // 
            this.cb_Syscall_9.AutoSize = true;
            this.cb_Syscall_9.Location = new System.Drawing.Point(239, 87);
            this.cb_Syscall_9.Name = "cb_Syscall_9";
            this.cb_Syscall_9.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_9.TabIndex = 29;
            this.cb_Syscall_9.Text = "[9] LV1 Poke";
            this.cb_Syscall_9.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_7
            // 
            this.cb_Syscall_7.AutoSize = true;
            this.cb_Syscall_7.Location = new System.Drawing.Point(239, 62);
            this.cb_Syscall_7.Name = "cb_Syscall_7";
            this.cb_Syscall_7.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_7.TabIndex = 28;
            this.cb_Syscall_7.Text = "[7] LV2 Poke";
            this.cb_Syscall_7.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_6
            // 
            this.cb_Syscall_6.AutoSize = true;
            this.cb_Syscall_6.Location = new System.Drawing.Point(239, 37);
            this.cb_Syscall_6.Name = "cb_Syscall_6";
            this.cb_Syscall_6.Size = new System.Drawing.Size(90, 19);
            this.cb_Syscall_6.TabIndex = 27;
            this.cb_Syscall_6.Text = "[6] LV2 Peek";
            this.cb_Syscall_6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(226, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 113);
            this.panel4.TabIndex = 23;
            // 
            // cB_PS3_MIMICOFW
            // 
            this.cB_PS3_MIMICOFW.AutoSize = true;
            this.cB_PS3_MIMICOFW.Location = new System.Drawing.Point(4, 48);
            this.cB_PS3_MIMICOFW.Name = "cB_PS3_MIMICOFW";
            this.cB_PS3_MIMICOFW.Size = new System.Drawing.Size(219, 64);
            this.cB_PS3_MIMICOFW.TabIndex = 25;
            this.cB_PS3_MIMICOFW.Text = "Also remove \"unsafe\" empty\r\ndirectory (GAMES, GAMEZ, PS3ISO,\r\nPS2ISO, PSXISO, PSX" +
    "GAMES, PSPISO,\r\nISO, BDISO, DVDISO, PKG).";
            this.cB_PS3_MIMICOFW.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 20);
            this.label24.TabIndex = 24;
            this.label24.Text = "User history:";
            // 
            // btn_PS3_ClearHistory
            // 
            this.btn_PS3_ClearHistory.Location = new System.Drawing.Point(118, 8);
            this.btn_PS3_ClearHistory.Name = "btn_PS3_ClearHistory";
            this.btn_PS3_ClearHistory.Size = new System.Drawing.Size(98, 24);
            this.btn_PS3_ClearHistory.TabIndex = 22;
            this.btn_PS3_ClearHistory.Text = "Clear";
            this.btn_PS3_ClearHistory.UseVisualStyleBackColor = true;
            this.btn_PS3_ClearHistory.Click += new System.EventHandler(this.btn_PS3_ClearHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "CFW Syscall:";
            // 
            // btn_PS3_DisableSyscall
            // 
            this.btn_PS3_DisableSyscall.Location = new System.Drawing.Point(358, 8);
            this.btn_PS3_DisableSyscall.Name = "btn_PS3_DisableSyscall";
            this.btn_PS3_DisableSyscall.Size = new System.Drawing.Size(87, 24);
            this.btn_PS3_DisableSyscall.TabIndex = 15;
            this.btn_PS3_DisableSyscall.Text = "Disable";
            this.btn_PS3_DisableSyscall.UseVisualStyleBackColor = true;
            this.btn_PS3_DisableSyscall.Click += new System.EventHandler(this.btn_PS3_CleanSyscall_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "PS3 Leds:";
            // 
            // p_PS3_Led
            // 
            this.p_PS3_Led.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Led.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Led.Controls.Add(this.cB_PS3_Led_Color);
            this.p_PS3_Led.Controls.Add(this.label17);
            this.p_PS3_Led.Controls.Add(this.label16);
            this.p_PS3_Led.Controls.Add(this.btn_PS3_Led_Set);
            this.p_PS3_Led.Controls.Add(this.cB_PS3_Led_Mode);
            this.p_PS3_Led.Location = new System.Drawing.Point(8, 181);
            this.p_PS3_Led.Name = "p_PS3_Led";
            this.p_PS3_Led.Size = new System.Drawing.Size(249, 72);
            this.p_PS3_Led.TabIndex = 11;
            // 
            // cB_PS3_Led_Color
            // 
            this.cB_PS3_Led_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Led_Color.FormattingEnabled = true;
            this.cB_PS3_Led_Color.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Yellow"});
            this.cB_PS3_Led_Color.Location = new System.Drawing.Point(65, 9);
            this.cB_PS3_Led_Color.MaxDropDownItems = 16;
            this.cB_PS3_Led_Color.Name = "cB_PS3_Led_Color";
            this.cB_PS3_Led_Color.Size = new System.Drawing.Size(111, 23);
            this.cB_PS3_Led_Color.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Mode:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Color:";
            // 
            // btn_PS3_Led_Set
            // 
            this.btn_PS3_Led_Set.Location = new System.Drawing.Point(182, 23);
            this.btn_PS3_Led_Set.Name = "btn_PS3_Led_Set";
            this.btn_PS3_Led_Set.Size = new System.Drawing.Size(60, 24);
            this.btn_PS3_Led_Set.TabIndex = 4;
            this.btn_PS3_Led_Set.Text = "Set";
            this.btn_PS3_Led_Set.UseVisualStyleBackColor = true;
            this.btn_PS3_Led_Set.Click += new System.EventHandler(this.btn_PS3_Led_Set_Click);
            // 
            // cB_PS3_Led_Mode
            // 
            this.cB_PS3_Led_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Led_Mode.FormattingEnabled = true;
            this.cB_PS3_Led_Mode.Items.AddRange(new object[] {
            "Off",
            "On",
            "Blink Fast",
            "Blink Slow"});
            this.cB_PS3_Led_Mode.Location = new System.Drawing.Point(65, 38);
            this.cB_PS3_Led_Mode.MaxDropDownItems = 16;
            this.cB_PS3_Led_Mode.Name = "cB_PS3_Led_Mode";
            this.cB_PS3_Led_Mode.Size = new System.Drawing.Size(111, 23);
            this.cB_PS3_Led_Mode.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "PS3 Buzzer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(259, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "PS3 Temperatures:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "PS3 Power:";
            // 
            // p_PS3_Buzzer
            // 
            this.p_PS3_Buzzer.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Buzzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Buzzer.Controls.Add(this.label12);
            this.p_PS3_Buzzer.Controls.Add(this.btn_Ring_Buzzer);
            this.p_PS3_Buzzer.Controls.Add(this.cB_PS3_Buzzer);
            this.p_PS3_Buzzer.Location = new System.Drawing.Point(8, 116);
            this.p_PS3_Buzzer.Name = "p_PS3_Buzzer";
            this.p_PS3_Buzzer.Size = new System.Drawing.Size(249, 39);
            this.p_PS3_Buzzer.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mode:";
            // 
            // btn_Ring_Buzzer
            // 
            this.btn_Ring_Buzzer.Location = new System.Drawing.Point(182, 4);
            this.btn_Ring_Buzzer.Name = "btn_Ring_Buzzer";
            this.btn_Ring_Buzzer.Size = new System.Drawing.Size(60, 26);
            this.btn_Ring_Buzzer.TabIndex = 11;
            this.btn_Ring_Buzzer.Text = "Ring";
            this.btn_Ring_Buzzer.UseVisualStyleBackColor = true;
            this.btn_Ring_Buzzer.Click += new System.EventHandler(this.btn_Ring_Buzzer_Click);
            // 
            // cB_PS3_Buzzer
            // 
            this.cB_PS3_Buzzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Buzzer.FormattingEnabled = true;
            this.cB_PS3_Buzzer.Items.AddRange(new object[] {
            "Simple",
            "Double",
            "Triple"});
            this.cB_PS3_Buzzer.Location = new System.Drawing.Point(60, 7);
            this.cB_PS3_Buzzer.MaxDropDownItems = 16;
            this.cB_PS3_Buzzer.Name = "cB_PS3_Buzzer";
            this.cB_PS3_Buzzer.Size = new System.Drawing.Size(116, 23);
            this.cB_PS3_Buzzer.TabIndex = 12;
            // 
            // p_PS3_Power
            // 
            this.p_PS3_Power.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Power.Controls.Add(this.btn_Power_Execute);
            this.p_PS3_Power.Controls.Add(this.cB_PS3_Power);
            this.p_PS3_Power.Location = new System.Drawing.Point(518, 26);
            this.p_PS3_Power.Name = "p_PS3_Power";
            this.p_PS3_Power.Size = new System.Drawing.Size(249, 64);
            this.p_PS3_Power.TabIndex = 6;
            // 
            // btn_Power_Execute
            // 
            this.btn_Power_Execute.Location = new System.Drawing.Point(84, 33);
            this.btn_Power_Execute.Name = "btn_Power_Execute";
            this.btn_Power_Execute.Size = new System.Drawing.Size(87, 26);
            this.btn_Power_Execute.TabIndex = 4;
            this.btn_Power_Execute.Text = "Execute";
            this.btn_Power_Execute.UseVisualStyleBackColor = true;
            this.btn_Power_Execute.Click += new System.EventHandler(this.btn_Power_Execute_Click);
            // 
            // cB_PS3_Power
            // 
            this.cB_PS3_Power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Power.FormattingEnabled = true;
            this.cB_PS3_Power.Items.AddRange(new object[] {
            "Shutdown",
            "Quick Reboot",
            "Soft Reboot",
            "Hard Reboot"});
            this.cB_PS3_Power.Location = new System.Drawing.Point(37, 5);
            this.cB_PS3_Power.MaxDropDownItems = 16;
            this.cB_PS3_Power.Name = "cB_PS3_Power";
            this.cB_PS3_Power.Size = new System.Drawing.Size(173, 23);
            this.cB_PS3_Power.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "PS3 Details:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Temp_Refresh);
            this.panel2.Controls.Add(this.lbl_Temp_CPU);
            this.panel2.Controls.Add(this.lbl_Temp_RSX);
            this.panel2.Location = new System.Drawing.Point(263, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 64);
            this.panel2.TabIndex = 4;
            // 
            // btn_Temp_Refresh
            // 
            this.btn_Temp_Refresh.Location = new System.Drawing.Point(168, 16);
            this.btn_Temp_Refresh.Name = "btn_Temp_Refresh";
            this.btn_Temp_Refresh.Size = new System.Drawing.Size(76, 27);
            this.btn_Temp_Refresh.TabIndex = 3;
            this.btn_Temp_Refresh.Text = "Refresh";
            this.btn_Temp_Refresh.UseVisualStyleBackColor = true;
            this.btn_Temp_Refresh.Click += new System.EventHandler(this.btn_Temp_Refresh_Click);
            // 
            // lbl_Temp_CPU
            // 
            this.lbl_Temp_CPU.AutoSize = true;
            this.lbl_Temp_CPU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp_CPU.Location = new System.Drawing.Point(3, 5);
            this.lbl_Temp_CPU.Name = "lbl_Temp_CPU";
            this.lbl_Temp_CPU.Size = new System.Drawing.Size(39, 20);
            this.lbl_Temp_CPU.TabIndex = 1;
            this.lbl_Temp_CPU.Text = "CPU:";
            // 
            // lbl_Temp_RSX
            // 
            this.lbl_Temp_RSX.AutoSize = true;
            this.lbl_Temp_RSX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp_RSX.Location = new System.Drawing.Point(3, 33);
            this.lbl_Temp_RSX.Name = "lbl_Temp_RSX";
            this.lbl_Temp_RSX.Size = new System.Drawing.Size(38, 20);
            this.lbl_Temp_RSX.TabIndex = 2;
            this.lbl_Temp_RSX.Text = "RSX:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_core_version);
            this.panel1.Controls.Add(this.lbl_fw);
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 64);
            this.panel1.TabIndex = 0;
            // 
            // lbl_core_version
            // 
            this.lbl_core_version.AutoSize = true;
            this.lbl_core_version.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core_version.Location = new System.Drawing.Point(3, 33);
            this.lbl_core_version.Name = "lbl_core_version";
            this.lbl_core_version.Size = new System.Drawing.Size(77, 20);
            this.lbl_core_version.TabIndex = 4;
            this.lbl_core_version.Text = "PS3M_API:";
            // 
            // lbl_fw
            // 
            this.lbl_fw.AutoSize = true;
            this.lbl_fw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fw.Location = new System.Drawing.Point(3, 5);
            this.lbl_fw.Name = "lbl_fw";
            this.lbl_fw.Size = new System.Drawing.Size(73, 20);
            this.lbl_fw.TabIndex = 0;
            this.lbl_fw.Text = "Firmware:";
            // 
            // tabP_Processes
            // 
            this.tabP_Processes.BackColor = System.Drawing.Color.White;
            this.tabP_Processes.Controls.Add(this.btnUnattach);
            this.tabP_Processes.Controls.Add(this.tabC_Process);
            this.tabP_Processes.Controls.Add(this.btnAttach);
            this.tabP_Processes.Controls.Add(this.btnRefresh);
            this.tabP_Processes.Controls.Add(this.lblProcs);
            this.tabP_Processes.Controls.Add(this.comboB_Procs);
            this.tabP_Processes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_Processes.Location = new System.Drawing.Point(4, 26);
            this.tabP_Processes.Name = "tabP_Processes";
            this.tabP_Processes.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Processes.Size = new System.Drawing.Size(776, 418);
            this.tabP_Processes.TabIndex = 1;
            this.tabP_Processes.Text = "Processes Commands";
            // 
            // btnUnattach
            // 
            this.btnUnattach.Enabled = false;
            this.btnUnattach.Location = new System.Drawing.Point(658, 19);
            this.btnUnattach.Name = "btnUnattach";
            this.btnUnattach.Size = new System.Drawing.Size(87, 25);
            this.btnUnattach.TabIndex = 5;
            this.btnUnattach.Text = "Unattach";
            this.btnUnattach.UseVisualStyleBackColor = true;
            this.btnUnattach.Click += new System.EventHandler(this.btnUnattach_Click);
            // 
            // tabC_Process
            // 
            this.tabC_Process.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabC_Process.Controls.Add(this.tabP_GetMem);
            this.tabC_Process.Controls.Add(this.tabP_SetMem);
            this.tabC_Process.Controls.Add(this.tabP_Modules);
            this.tabC_Process.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabC_Process.Enabled = false;
            this.tabC_Process.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC_Process.Location = new System.Drawing.Point(3, 68);
            this.tabC_Process.Name = "tabC_Process";
            this.tabC_Process.SelectedIndex = 0;
            this.tabC_Process.Size = new System.Drawing.Size(770, 347);
            this.tabC_Process.TabIndex = 4;
            // 
            // tabP_GetMem
            // 
            this.tabP_GetMem.BackColor = System.Drawing.Color.White;
            this.tabP_GetMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabP_GetMem.Controls.Add(this.nUD_GetLength);
            this.tabP_GetMem.Controls.Add(this.textOutput);
            this.tabP_GetMem.Controls.Add(this.label4);
            this.tabP_GetMem.Controls.Add(this.label2);
            this.tabP_GetMem.Controls.Add(this.label3);
            this.tabP_GetMem.Controls.Add(this.button1);
            this.tabP_GetMem.Controls.Add(this.txtB_GetOffset);
            this.tabP_GetMem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabP_GetMem.Location = new System.Drawing.Point(4, 29);
            this.tabP_GetMem.Name = "tabP_GetMem";
            this.tabP_GetMem.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_GetMem.Size = new System.Drawing.Size(762, 314);
            this.tabP_GetMem.TabIndex = 0;
            this.tabP_GetMem.Text = "Get Memory";
            // 
            // nUD_GetLength
            // 
            this.nUD_GetLength.BackColor = System.Drawing.SystemColors.Control;
            this.nUD_GetLength.Location = new System.Drawing.Point(464, 24);
            this.nUD_GetLength.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nUD_GetLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_GetLength.Name = "nUD_GetLength";
            this.nUD_GetLength.Size = new System.Drawing.Size(120, 23);
            this.nUD_GetLength.TabIndex = 22;
            this.nUD_GetLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_GetLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabP_SetMem
            // 
            this.tabP_SetMem.BackColor = System.Drawing.Color.White;
            this.tabP_SetMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabP_SetMem.Controls.Add(this.txtB_SetOffset);
            this.tabP_SetMem.Controls.Add(this.textValue);
            this.tabP_SetMem.Controls.Add(this.btnSetMem);
            this.tabP_SetMem.Controls.Add(this.lblOffset);
            this.tabP_SetMem.Controls.Add(this.lblValue);
            this.tabP_SetMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_SetMem.Location = new System.Drawing.Point(4, 29);
            this.tabP_SetMem.Name = "tabP_SetMem";
            this.tabP_SetMem.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_SetMem.Size = new System.Drawing.Size(762, 314);
            this.tabP_SetMem.TabIndex = 1;
            this.tabP_SetMem.Text = "Set Memory";
            // 
            // txtB_SetOffset
            // 
            this.txtB_SetOffset.BackColor = System.Drawing.SystemColors.Control;
            this.txtB_SetOffset.Location = new System.Drawing.Point(67, 24);
            this.txtB_SetOffset.MaxLength = 32;
            this.txtB_SetOffset.Name = "txtB_SetOffset";
            this.txtB_SetOffset.Size = new System.Drawing.Size(261, 23);
            this.txtB_SetOffset.TabIndex = 24;
            this.txtB_SetOffset.Text = "0";
            this.txtB_SetOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB_SetOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // textValue
            // 
            this.textValue.BackColor = System.Drawing.SystemColors.Control;
            this.textValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textValue.Location = new System.Drawing.Point(3, 94);
            this.textValue.MaxLength = 65536;
            this.textValue.Multiline = true;
            this.textValue.Name = "textValue";
            this.textValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textValue.Size = new System.Drawing.Size(754, 215);
            this.textValue.TabIndex = 25;
            this.textValue.Text = "000102030405060708090A0B0C0D0E0F";
            this.textValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // btnSetMem
            // 
            this.btnSetMem.Location = new System.Drawing.Point(667, 22);
            this.btnSetMem.Name = "btnSetMem";
            this.btnSetMem.Size = new System.Drawing.Size(87, 23);
            this.btnSetMem.TabIndex = 26;
            this.btnSetMem.Text = "Set";
            this.btnSetMem.UseVisualStyleBackColor = true;
            this.btnSetMem.Click += new System.EventHandler(this.btnSetMem_Click);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffset.Location = new System.Drawing.Point(11, 27);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(50, 17);
            this.lblOffset.TabIndex = 27;
            this.lblOffset.Text = "Offset:\r\n";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(10, 69);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(46, 17);
            this.lblValue.TabIndex = 28;
            this.lblValue.Text = "Value:";
            // 
            // tabP_Modules
            // 
            this.tabP_Modules.BackColor = System.Drawing.Color.White;
            this.tabP_Modules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabP_Modules.Controls.Add(this.label23);
            this.tabP_Modules.Controls.Add(this.btn_Module_Unload);
            this.tabP_Modules.Controls.Add(this.label22);
            this.tabP_Modules.Controls.Add(this.label21);
            this.tabP_Modules.Controls.Add(this.btn_Module_Load);
            this.tabP_Modules.Controls.Add(this.tB_Module_Path);
            this.tabP_Modules.Controls.Add(this.btn_Module_Refresh);
            this.tabP_Modules.Controls.Add(this.lV_Modules);
            this.tabP_Modules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_Modules.Location = new System.Drawing.Point(4, 29);
            this.tabP_Modules.Name = "tabP_Modules";
            this.tabP_Modules.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Modules.Size = new System.Drawing.Size(762, 314);
            this.tabP_Modules.TabIndex = 2;
            this.tabP_Modules.Text = "Modules";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(276, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(238, 20);
            this.label23.TabIndex = 31;
            this.label23.Text = "!!! LOAD/UNLOAD IS IN BETA !!!";
            // 
            // btn_Module_Unload
            // 
            this.btn_Module_Unload.Location = new System.Drawing.Point(581, 58);
            this.btn_Module_Unload.Name = "btn_Module_Unload";
            this.btn_Module_Unload.Size = new System.Drawing.Size(173, 24);
            this.btn_Module_Unload.TabIndex = 30;
            this.btn_Module_Unload.Text = "Unload selected module";
            this.btn_Module_Unload.UseVisualStyleBackColor = true;
            this.btn_Module_Unload.Click += new System.EventHandler(this.btn_Module_Unload_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Modules loaded:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Load a module, path:";
            // 
            // btn_Module_Load
            // 
            this.btn_Module_Load.Location = new System.Drawing.Point(667, 11);
            this.btn_Module_Load.Name = "btn_Module_Load";
            this.btn_Module_Load.Size = new System.Drawing.Size(87, 24);
            this.btn_Module_Load.TabIndex = 18;
            this.btn_Module_Load.Text = "Load";
            this.btn_Module_Load.UseVisualStyleBackColor = true;
            this.btn_Module_Load.Click += new System.EventHandler(this.btn_Module_Load_Click);
            // 
            // tB_Module_Path
            // 
            this.tB_Module_Path.BackColor = System.Drawing.SystemColors.Control;
            this.tB_Module_Path.Location = new System.Drawing.Point(156, 11);
            this.tB_Module_Path.MaxLength = 128;
            this.tB_Module_Path.Name = "tB_Module_Path";
            this.tB_Module_Path.Size = new System.Drawing.Size(505, 23);
            this.tB_Module_Path.TabIndex = 17;
            // 
            // btn_Module_Refresh
            // 
            this.btn_Module_Refresh.Location = new System.Drawing.Point(127, 58);
            this.btn_Module_Refresh.Name = "btn_Module_Refresh";
            this.btn_Module_Refresh.Size = new System.Drawing.Size(87, 24);
            this.btn_Module_Refresh.TabIndex = 3;
            this.btn_Module_Refresh.Text = "Refresh";
            this.btn_Module_Refresh.UseVisualStyleBackColor = true;
            this.btn_Module_Refresh.Click += new System.EventHandler(this.btn_Module_Refresh_Click);
            // 
            // lV_Modules
            // 
            this.lV_Modules.AutoArrange = false;
            this.lV_Modules.BackColor = System.Drawing.SystemColors.Control;
            this.lV_Modules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_Modules_Name,
            this.cH_Modules_Path});
            this.lV_Modules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lV_Modules.FullRowSelect = true;
            this.lV_Modules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lV_Modules.HideSelection = false;
            this.lV_Modules.Location = new System.Drawing.Point(3, 94);
            this.lV_Modules.MultiSelect = false;
            this.lV_Modules.Name = "lV_Modules";
            this.lV_Modules.ShowGroups = false;
            this.lV_Modules.Size = new System.Drawing.Size(754, 215);
            this.lV_Modules.TabIndex = 0;
            this.lV_Modules.UseCompatibleStateImageBehavior = false;
            this.lV_Modules.View = System.Windows.Forms.View.Details;
            // 
            // cH_Modules_Name
            // 
            this.cH_Modules_Name.Text = "Name";
            this.cH_Modules_Name.Width = 135;
            // 
            // cH_Modules_Path
            // 
            this.cH_Modules_Path.Text = "Path";
            this.cH_Modules_Path.Width = 549;
            // 
            // txtB_Port
            // 
            this.txtB_Port.Location = new System.Drawing.Point(215, 7);
            this.txtB_Port.MaxLength = 5;
            this.txtB_Port.Name = "txtB_Port";
            this.txtB_Port.Size = new System.Drawing.Size(55, 23);
            this.txtB_Port.TabIndex = 13;
            this.txtB_Port.Text = "7887";
            this.txtB_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "PORT: ";
            // 
            // txtB_Ip
            // 
            this.txtB_Ip.Location = new System.Drawing.Point(37, 7);
            this.txtB_Ip.MaxLength = 16;
            this.txtB_Ip.Name = "txtB_Ip";
            this.txtB_Ip.Size = new System.Drawing.Size(116, 23);
            this.txtB_Ip.TabIndex = 11;
            this.txtB_Ip.Text = "127.0.0.1";
            this.txtB_Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP: ";
            // 
            // p_Connection
            // 
            this.p_Connection.BackColor = System.Drawing.SystemColors.Control;
            this.p_Connection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Connection.Controls.Add(this.btn_ShowLog);
            this.p_Connection.Controls.Add(this.txtB_Ip);
            this.p_Connection.Controls.Add(this.txtB_Port);
            this.p_Connection.Controls.Add(this.btnConnect);
            this.p_Connection.Controls.Add(this.btnDisconnect);
            this.p_Connection.Controls.Add(this.label5);
            this.p_Connection.Controls.Add(this.label6);
            this.p_Connection.Location = new System.Drawing.Point(185, 32);
            this.p_Connection.Name = "p_Connection";
            this.p_Connection.Size = new System.Drawing.Size(586, 38);
            this.p_Connection.TabIndex = 26;
            // 
            // btn_ShowLog
            // 
            this.btn_ShowLog.Location = new System.Drawing.Point(476, 4);
            this.btn_ShowLog.Name = "btn_ShowLog";
            this.btn_ShowLog.Size = new System.Drawing.Size(87, 27);
            this.btn_ShowLog.TabIndex = 14;
            this.btn_ShowLog.Text = "Show Log";
            this.btn_ShowLog.UseVisualStyleBackColor = true;
            this.btn_ShowLog.Click += new System.EventHandler(this.btn_ShowLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS3_Manager_API_Demo_Tools.Properties.Resources.ICON0;
            this.pictureBox1.Location = new System.Drawing.Point(1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Lib_Version
            // 
            this.lbl_Lib_Version.AutoSize = true;
            this.lbl_Lib_Version.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lib_Version.Location = new System.Drawing.Point(695, 9);
            this.lbl_Lib_Version.Name = "lbl_Lib_Version";
            this.lbl_Lib_Version.Size = new System.Drawing.Size(77, 20);
            this.lbl_Lib_Version.TabIndex = 28;
            this.lbl_Lib_Version.Text = "Lib v7.7.7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.lbl_Lib_Version);
            this.Controls.Add(this.p_Connection);
            this.Controls.Add(this.tabC_Global);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS3 Manager API Demo Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabC_Global.ResumeLayout(false);
            this.tabP_PS3.ResumeLayout(false);
            this.tabP_PS3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.p_PS3_Notify.ResumeLayout(false);
            this.p_PS3_Notify.PerformLayout();
            this.p_PS3_MimicOFW.ResumeLayout(false);
            this.p_PS3_MimicOFW.PerformLayout();
            this.p_PS3_Led.ResumeLayout(false);
            this.p_PS3_Led.PerformLayout();
            this.p_PS3_Buzzer.ResumeLayout(false);
            this.p_PS3_Buzzer.PerformLayout();
            this.p_PS3_Power.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabP_Processes.ResumeLayout(false);
            this.tabP_Processes.PerformLayout();
            this.tabC_Process.ResumeLayout(false);
            this.tabP_GetMem.ResumeLayout(false);
            this.tabP_GetMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetLength)).EndInit();
            this.tabP_SetMem.ResumeLayout(false);
            this.tabP_SetMem.PerformLayout();
            this.tabP_Modules.ResumeLayout(false);
            this.tabP_Modules.PerformLayout();
            this.p_Connection.ResumeLayout(false);
            this.p_Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtB_GetOffset;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboB_Procs;
        private System.Windows.Forms.Label lblProcs;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.TabControl tabC_Global;
        private System.Windows.Forms.TabPage tabP_PS3;
        private System.Windows.Forms.TabPage tabP_Processes;
        private System.Windows.Forms.TabControl tabC_Process;
        private System.Windows.Forms.TabPage tabP_GetMem;
        private System.Windows.Forms.TabPage tabP_SetMem;
        private System.Windows.Forms.TextBox txtB_SetOffset;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button btnSetMem;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel p_PS3_Led;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_PS3_Led_Set;
        private System.Windows.Forms.ComboBox cB_PS3_Led_Mode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel p_PS3_Buzzer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Ring_Buzzer;
        private System.Windows.Forms.ComboBox cB_PS3_Buzzer;
        private System.Windows.Forms.Panel p_PS3_Power;
        private System.Windows.Forms.Button btn_Power_Execute;
        private System.Windows.Forms.ComboBox cB_PS3_Power;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Temp_Refresh;
        private System.Windows.Forms.Label lbl_Temp_CPU;
        private System.Windows.Forms.Label lbl_Temp_RSX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_core_version;
        private System.Windows.Forms.Label lbl_fw;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel p_PS3_Notify;
        private System.Windows.Forms.TextBox tB_PS3_Notify;
        private System.Windows.Forms.Button btn_PS3_Notify;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel p_PS3_MimicOFW;
        private System.Windows.Forms.Button btn_PS3_DisableSyscall;
        private System.Windows.Forms.Button btnUnattach;
        private System.Windows.Forms.TabPage tabP_Modules;
        private System.Windows.Forms.NumericUpDown nUD_GetLength;
        protected internal System.Windows.Forms.TextBox txtB_Port;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox txtB_Ip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel p_Connection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_GameManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Setup;
        private System.Windows.Forms.Button btn_FileManager;
        private System.Windows.Forms.Button btn_PS3_ClearHistory;
        private System.Windows.Forms.Button btn_Module_Unload;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_Module_Load;
        private System.Windows.Forms.TextBox tB_Module_Path;
        private System.Windows.Forms.Button btn_Module_Refresh;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cB_PS3_MIMICOFW;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ShowLog;
        private System.Windows.Forms.ListView lV_Modules;
        private System.Windows.Forms.ColumnHeader cH_Modules_Name;
        private System.Windows.Forms.ColumnHeader cH_Modules_Path;
        private System.Windows.Forms.Label lbl_Lib_Version;
        private System.Windows.Forms.CheckBox cb_RemoveHook;
        private System.Windows.Forms.CheckBox cb_Syscall_8_D;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P3;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P2;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P1;
        private System.Windows.Forms.CheckBox cb_Syscall_8;
        private System.Windows.Forms.CheckBox cb_Syscall_36;
        private System.Windows.Forms.CheckBox cb_Syscall_35;
        private System.Windows.Forms.CheckBox cb_Syscall_11;
        private System.Windows.Forms.CheckBox cb_Syscall_10;
        private System.Windows.Forms.CheckBox cb_Syscall_9;
        private System.Windows.Forms.CheckBox cb_Syscall_7;
        private System.Windows.Forms.CheckBox cb_Syscall_6;
        private System.Windows.Forms.ComboBox cB_PS3_Led_Color;
    }
}

