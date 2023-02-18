using System;
using System.Windows.Forms;

namespace PierceStat
{
    partial class Form_MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell2 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBox_ComPortsList = new System.Windows.Forms.ComboBox();
            this.label_COM = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCOMPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ConnectCOM = new System.Windows.Forms.Button();
            this.richTextBox_Messages = new System.Windows.Forms.RichTextBox();
            this.groupBox_PierceStat = new System.Windows.Forms.GroupBox();
            this.numericUpDown_DerNumber = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.numericUpDown_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.button_CalibrateKprt = new System.Windows.Forms.Button();
            this.numericUpDown_KprtValue = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.numericUpDown_TstopKprt = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.numericUpDown_TstartKprt = new System.Windows.Forms.NumericUpDown();
            this.groupBox_ChannelsMode = new System.Windows.Forms.GroupBox();
            this.radioButton_ModeDependent = new System.Windows.Forms.RadioButton();
            this.radioButton_ModeIndependent = new System.Windows.Forms.RadioButton();
            this.button_ResetPlots = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox_PlotTempFreq = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp4 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp3 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp2 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp1 = new System.Windows.Forms.CheckBox();
            this.chart_Freq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Temps = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_SaveFlash = new System.Windows.Forms.Button();
            this.numericUpDown_U_HeaterSet = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox_Meas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_AlarmFreqMasked = new System.Windows.Forms.CheckBox();
            this.label_CurrentCh1 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp4Masked = new System.Windows.Forms.CheckBox();
            this.pictureBox_AlarmFreq = new System.Windows.Forms.PictureBox();
            this.checkBox_AlarmTemp3Masked = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp2Masked = new System.Windows.Forms.CheckBox();
            this.numericUpDown_FreqMax = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown_FreqMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp4 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_FreqMeas = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_AlarmTemp3 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp2 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_CurrentCh1Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp2Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp3Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp4Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh1Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh2Meas = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AlarmCurrentCh1Masked = new System.Windows.Forms.CheckBox();
            this.checkBox_AlarmU_HeaterMasked = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox_AlarmU_PowerMasked = new System.Windows.Forms.CheckBox();
            this.label_U_Power = new System.Windows.Forms.Label();
            this.numericUpDown_Temp4Min = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AlarmCurrentCh2Masked = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Temp3Min = new System.Windows.Forms.NumericUpDown();
            this.label_U_Heater = new System.Windows.Forms.Label();
            this.numericUpDown_Temp2Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMeas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMeas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp4Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp3Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh2Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp2Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMax = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_AlarmCurrentCh1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmCurrentCh2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmU_Power = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmU_Heater = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp1Masked = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox_Channel2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDown_ISet2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Polarity2 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox_Temp2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointTemp2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_PTemp2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DTemp2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ITemp2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Freq2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointFreq2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_DFreq2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PFreq2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IFreq2 = new System.Windows.Forms.NumericUpDown();
            this.button_EnableCh2 = new System.Windows.Forms.Button();
            this.comboBox_Source2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_Mode2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_Load2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox_Channel1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_ISet1 = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox_Polarity1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox_Temp1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointTemp1 = new System.Windows.Forms.NumericUpDown();
            this.label_SetPointTemp = new System.Windows.Forms.Label();
            this.label_PTemp1 = new System.Windows.Forms.Label();
            this.label_ITemp1 = new System.Windows.Forms.Label();
            this.label_DTemp1 = new System.Windows.Forms.Label();
            this.numericUpDown_PTemp1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DTemp1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ITemp1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Freq1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointFreq1 = new System.Windows.Forms.NumericUpDown();
            this.label_SetPointFreq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_DFreq1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PFreq1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IFreq1 = new System.Windows.Forms.NumericUpDown();
            this.button_EnableCh1 = new System.Windows.Forms.Button();
            this.comboBox_Source1 = new System.Windows.Forms.ComboBox();
            this.label_Source1 = new System.Windows.Forms.Label();
            this.comboBox_Mode1 = new System.Windows.Forms.ComboBox();
            this.label_Mode1 = new System.Windows.Forms.Label();
            this.comboBox_Load1 = new System.Windows.Forms.ComboBox();
            this.label_Load1 = new System.Windows.Forms.Label();
            this.checkBox_U_HeaterEnable = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_PierceStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KprtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstopKprt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstartKprt)).BeginInit();
            this.groupBox_ChannelsMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterSet)).BeginInit();
            this.groupBox_Meas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Heater)).BeginInit();
            this.groupBox_Channel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet2)).BeginInit();
            this.groupBox_Temp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp2)).BeginInit();
            this.groupBox_Freq2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq2)).BeginInit();
            this.groupBox_Channel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet1)).BeginInit();
            this.groupBox_Temp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp1)).BeginInit();
            this.groupBox_Freq1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ComPortsList
            // 
            this.comboBox_ComPortsList.FormattingEnabled = true;
            this.comboBox_ComPortsList.Location = new System.Drawing.Point(74, 58);
            this.comboBox_ComPortsList.Name = "comboBox_ComPortsList";
            this.comboBox_ComPortsList.Size = new System.Drawing.Size(121, 28);
            this.comboBox_ComPortsList.TabIndex = 0;
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(12, 62);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(45, 20);
            this.label_COM.TabIndex = 1;
            this.label_COM.Text = "COM";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1922, 33);
            this.menuStrip_Main.TabIndex = 2;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCOMPortsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updateCOMPortsToolStripMenuItem
            // 
            this.updateCOMPortsToolStripMenuItem.Name = "updateCOMPortsToolStripMenuItem";
            this.updateCOMPortsToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.updateCOMPortsToolStripMenuItem.Text = "Update COM ports";
            this.updateCOMPortsToolStripMenuItem.Click += new System.EventHandler(this.updateCOMPortsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button_ConnectCOM
            // 
            this.button_ConnectCOM.Location = new System.Drawing.Point(225, 48);
            this.button_ConnectCOM.Name = "button_ConnectCOM";
            this.button_ConnectCOM.Size = new System.Drawing.Size(124, 38);
            this.button_ConnectCOM.TabIndex = 3;
            this.button_ConnectCOM.Text = "Connect";
            this.button_ConnectCOM.UseVisualStyleBackColor = true;
            this.button_ConnectCOM.Click += new System.EventHandler(this.button_ConnectCOM_Click);
            // 
            // richTextBox_Messages
            // 
            this.richTextBox_Messages.Location = new System.Drawing.Point(1516, 132);
            this.richTextBox_Messages.Name = "richTextBox_Messages";
            this.richTextBox_Messages.Size = new System.Drawing.Size(366, 1075);
            this.richTextBox_Messages.TabIndex = 4;
            this.richTextBox_Messages.Text = "";
            // 
            // groupBox_PierceStat
            // 
            this.groupBox_PierceStat.Controls.Add(this.numericUpDown_DerNumber);
            this.groupBox_PierceStat.Controls.Add(this.label38);
            this.groupBox_PierceStat.Controls.Add(this.numericUpDown_TimeInterval);
            this.groupBox_PierceStat.Controls.Add(this.label37);
            this.groupBox_PierceStat.Controls.Add(this.groupBox4);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_ChannelsMode);
            this.groupBox_PierceStat.Controls.Add(this.button_ResetPlots);
            this.groupBox_PierceStat.Controls.Add(this.label31);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_PlotTempFreq);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_PlotTemp4);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_PlotTemp3);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_PlotTemp2);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_PlotTemp1);
            this.groupBox_PierceStat.Controls.Add(this.chart_Freq);
            this.groupBox_PierceStat.Controls.Add(this.chart_Temps);
            this.groupBox_PierceStat.Controls.Add(this.button_SaveFlash);
            this.groupBox_PierceStat.Controls.Add(this.numericUpDown_U_HeaterSet);
            this.groupBox_PierceStat.Controls.Add(this.label21);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_Meas);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_Channel2);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_Channel1);
            this.groupBox_PierceStat.Controls.Add(this.checkBox_U_HeaterEnable);
            this.groupBox_PierceStat.Location = new System.Drawing.Point(16, 123);
            this.groupBox_PierceStat.Name = "groupBox_PierceStat";
            this.groupBox_PierceStat.Size = new System.Drawing.Size(1476, 1198);
            this.groupBox_PierceStat.TabIndex = 5;
            this.groupBox_PierceStat.TabStop = false;
            this.groupBox_PierceStat.Text = "PierceStat™ ";
            // 
            // numericUpDown_DerNumber
            // 
            this.numericUpDown_DerNumber.Location = new System.Drawing.Point(1065, 1132);
            this.numericUpDown_DerNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_DerNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DerNumber.Name = "numericUpDown_DerNumber";
            this.numericUpDown_DerNumber.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown_DerNumber.TabIndex = 54;
            this.numericUpDown_DerNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(816, 1135);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(220, 20);
            this.label38.TabIndex = 52;
            this.label38.Text = "Number to calculate derivative";
            // 
            // numericUpDown_TimeInterval
            // 
            this.numericUpDown_TimeInterval.Location = new System.Drawing.Point(664, 118);
            this.numericUpDown_TimeInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_TimeInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_TimeInterval.Name = "numericUpDown_TimeInterval";
            this.numericUpDown_TimeInterval.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown_TimeInterval.TabIndex = 51;
            this.numericUpDown_TimeInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(669, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(126, 20);
            this.label37.TabIndex = 50;
            this.label37.Text = "Time interval, ms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.button_CalibrateKprt);
            this.groupBox4.Controls.Add(this.numericUpDown_KprtValue);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.numericUpDown_TstopKprt);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.numericUpDown_TstartKprt);
            this.groupBox4.Location = new System.Drawing.Point(804, 542);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(651, 105);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kprt Calibration";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(504, 57);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 26);
            this.numericUpDown2.TabIndex = 58;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(424, 63);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(51, 20);
            this.label39.TabIndex = 57;
            this.label39.Text = "f0, Hz";
            // 
            // button_CalibrateKprt
            // 
            this.button_CalibrateKprt.Location = new System.Drawing.Point(504, 11);
            this.button_CalibrateKprt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_CalibrateKprt.Name = "button_CalibrateKprt";
            this.button_CalibrateKprt.Size = new System.Drawing.Size(112, 35);
            this.button_CalibrateKprt.TabIndex = 56;
            this.button_CalibrateKprt.Text = "Calibrate";
            this.button_CalibrateKprt.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_KprtValue
            // 
            this.numericUpDown_KprtValue.DecimalPlaces = 1;
            this.numericUpDown_KprtValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_KprtValue.Location = new System.Drawing.Point(320, 57);
            this.numericUpDown_KprtValue.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_KprtValue.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown_KprtValue.Name = "numericUpDown_KprtValue";
            this.numericUpDown_KprtValue.Size = new System.Drawing.Size(99, 26);
            this.numericUpDown_KprtValue.TabIndex = 55;
            this.numericUpDown_KprtValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(208, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(86, 20);
            this.label36.TabIndex = 54;
            this.label36.Text = "Kprt, Hz/°C";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(345, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(208, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(130, 20);
            this.label35.TabIndex = 52;
            this.label35.Text = "Number of points";
            // 
            // numericUpDown_TstopKprt
            // 
            this.numericUpDown_TstopKprt.DecimalPlaces = 2;
            this.numericUpDown_TstopKprt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_TstopKprt.Location = new System.Drawing.Point(88, 60);
            this.numericUpDown_TstopKprt.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_TstopKprt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_TstopKprt.Name = "numericUpDown_TstopKprt";
            this.numericUpDown_TstopKprt.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_TstopKprt.TabIndex = 51;
            this.numericUpDown_TstopKprt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 60);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 20);
            this.label34.TabIndex = 50;
            this.label34.Text = "Tstop, °C";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 20);
            this.label33.TabIndex = 49;
            this.label33.Text = "Tstart, °C";
            // 
            // numericUpDown_TstartKprt
            // 
            this.numericUpDown_TstartKprt.DecimalPlaces = 2;
            this.numericUpDown_TstartKprt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_TstartKprt.Location = new System.Drawing.Point(88, 26);
            this.numericUpDown_TstartKprt.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_TstartKprt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_TstartKprt.Name = "numericUpDown_TstartKprt";
            this.numericUpDown_TstartKprt.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown_TstartKprt.TabIndex = 48;
            this.numericUpDown_TstartKprt.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // groupBox_ChannelsMode
            // 
            this.groupBox_ChannelsMode.Controls.Add(this.radioButton_ModeDependent);
            this.groupBox_ChannelsMode.Controls.Add(this.radioButton_ModeIndependent);
            this.groupBox_ChannelsMode.Location = new System.Drawing.Point(476, 35);
            this.groupBox_ChannelsMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ChannelsMode.Name = "groupBox_ChannelsMode";
            this.groupBox_ChannelsMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ChannelsMode.Size = new System.Drawing.Size(170, 109);
            this.groupBox_ChannelsMode.TabIndex = 47;
            this.groupBox_ChannelsMode.TabStop = false;
            this.groupBox_ChannelsMode.Text = "Channels mode";
            // 
            // radioButton_ModeDependent
            // 
            this.radioButton_ModeDependent.AutoSize = true;
            this.radioButton_ModeDependent.Location = new System.Drawing.Point(14, 74);
            this.radioButton_ModeDependent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ModeDependent.Name = "radioButton_ModeDependent";
            this.radioButton_ModeDependent.Size = new System.Drawing.Size(114, 24);
            this.radioButton_ModeDependent.TabIndex = 46;
            this.radioButton_ModeDependent.Text = "Dependent";
            this.radioButton_ModeDependent.UseVisualStyleBackColor = true;
            this.radioButton_ModeDependent.CheckedChanged += new System.EventHandler(this.radioButton_ModeDependent_CheckedChanged);
            // 
            // radioButton_ModeIndependent
            // 
            this.radioButton_ModeIndependent.AutoSize = true;
            this.radioButton_ModeIndependent.Checked = true;
            this.radioButton_ModeIndependent.Location = new System.Drawing.Point(14, 42);
            this.radioButton_ModeIndependent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_ModeIndependent.Name = "radioButton_ModeIndependent";
            this.radioButton_ModeIndependent.Size = new System.Drawing.Size(125, 24);
            this.radioButton_ModeIndependent.TabIndex = 45;
            this.radioButton_ModeIndependent.TabStop = true;
            this.radioButton_ModeIndependent.Text = "Independent";
            this.radioButton_ModeIndependent.UseVisualStyleBackColor = true;
            // 
            // button_ResetPlots
            // 
            this.button_ResetPlots.Location = new System.Drawing.Point(666, 51);
            this.button_ResetPlots.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ResetPlots.Name = "button_ResetPlots";
            this.button_ResetPlots.Size = new System.Drawing.Size(112, 35);
            this.button_ResetPlots.TabIndex = 44;
            this.button_ResetPlots.Text = "Reset Plots";
            this.button_ResetPlots.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(808, 512);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 20);
            this.label31.TabIndex = 43;
            this.label31.Text = "Plot select";
            // 
            // checkBox_PlotTempFreq
            // 
            this.checkBox_PlotTempFreq.AutoSize = true;
            this.checkBox_PlotTempFreq.Location = new System.Drawing.Point(1308, 506);
            this.checkBox_PlotTempFreq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PlotTempFreq.Name = "checkBox_PlotTempFreq";
            this.checkBox_PlotTempFreq.Size = new System.Drawing.Size(94, 24);
            this.checkBox_PlotTempFreq.TabIndex = 42;
            this.checkBox_PlotTempFreq.Text = "Temp (f)";
            this.checkBox_PlotTempFreq.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp4
            // 
            this.checkBox_PlotTemp4.AutoSize = true;
            this.checkBox_PlotTemp4.Location = new System.Drawing.Point(1210, 506);
            this.checkBox_PlotTemp4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PlotTemp4.Name = "checkBox_PlotTemp4";
            this.checkBox_PlotTemp4.Size = new System.Drawing.Size(84, 24);
            this.checkBox_PlotTemp4.TabIndex = 41;
            this.checkBox_PlotTemp4.Text = "Temp4";
            this.checkBox_PlotTemp4.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp3
            // 
            this.checkBox_PlotTemp3.AutoSize = true;
            this.checkBox_PlotTemp3.Location = new System.Drawing.Point(1113, 508);
            this.checkBox_PlotTemp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PlotTemp3.Name = "checkBox_PlotTemp3";
            this.checkBox_PlotTemp3.Size = new System.Drawing.Size(84, 24);
            this.checkBox_PlotTemp3.TabIndex = 40;
            this.checkBox_PlotTemp3.Text = "Temp3";
            this.checkBox_PlotTemp3.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp2
            // 
            this.checkBox_PlotTemp2.AutoSize = true;
            this.checkBox_PlotTemp2.Checked = true;
            this.checkBox_PlotTemp2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotTemp2.Location = new System.Drawing.Point(1016, 508);
            this.checkBox_PlotTemp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PlotTemp2.Name = "checkBox_PlotTemp2";
            this.checkBox_PlotTemp2.Size = new System.Drawing.Size(84, 24);
            this.checkBox_PlotTemp2.TabIndex = 39;
            this.checkBox_PlotTemp2.Text = "Temp2";
            this.checkBox_PlotTemp2.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp1
            // 
            this.checkBox_PlotTemp1.AutoSize = true;
            this.checkBox_PlotTemp1.Checked = true;
            this.checkBox_PlotTemp1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotTemp1.Location = new System.Drawing.Point(918, 509);
            this.checkBox_PlotTemp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PlotTemp1.Name = "checkBox_PlotTemp1";
            this.checkBox_PlotTemp1.Size = new System.Drawing.Size(84, 24);
            this.checkBox_PlotTemp1.TabIndex = 38;
            this.checkBox_PlotTemp1.Text = "Temp1";
            this.checkBox_PlotTemp1.UseVisualStyleBackColor = true;
            // 
            // chart_Freq
            // 
            chartArea1.AxisX.Title = "Time, s";
            chartArea1.AxisY.Title = "Frequency, Hz";
            chartArea1.AxisY2.Title = "Derivative, Hz/s";
            chartArea1.Name = "ChartArea1";
            this.chart_Freq.ChartAreas.Add(chartArea1);
            legendCell1.Name = "Cell1";
            legendItem1.Cells.Add(legendCell1);
            legend1.CustomItems.Add(legendItem1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart_Freq.Legends.Add(legend1);
            this.chart_Freq.Location = new System.Drawing.Point(813, 655);
            this.chart_Freq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Freq.Name = "chart_Freq";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.LegendText = "Frequency";
            series1.Name = "Series_FreqData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.LegendText = "Derivative";
            series2.Name = "Series_DFreq";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_Freq.Series.Add(series1);
            this.chart_Freq.Series.Add(series2);
            this.chart_Freq.Size = new System.Drawing.Size(656, 462);
            this.chart_Freq.TabIndex = 37;
            this.chart_Freq.Text = "Frequency";
            title1.Name = "Title1";
            title1.Text = "Frequency and derivative";
            this.chart_Freq.Titles.Add(title1);
            // 
            // chart_Temps
            // 
            chartArea2.AxisX.Title = "Time, s";
            chartArea2.AxisY.Title = "Temp, °C";
            chartArea2.Name = "ChartArea1";
            this.chart_Temps.ChartAreas.Add(chartArea2);
            legendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn1.Name = "Symbols";
            legendCellColumn2.Name = "Names";
            legend2.CellColumns.Add(legendCellColumn1);
            legend2.CellColumns.Add(legendCellColumn2);
            legendCell2.Name = "Cell1";
            legendItem2.Cells.Add(legendCell2);
            legend2.CustomItems.Add(legendItem2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.Name = "Legend1";
            this.chart_Temps.Legends.Add(legend2);
            this.chart_Temps.Location = new System.Drawing.Point(813, 38);
            this.chart_Temps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_Temps.Name = "chart_Temps";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.LegendText = "Temp 1";
            series3.Name = "Series_Temp1Data";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.LegendText = "Temp 2";
            series4.Name = "Series_Temp2Data";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.LegendText = "Temp3";
            series5.Name = "Series_Temp3Data";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.LegendText = "Temp 4";
            series6.Name = "Series_Temp4Data";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.LegendText = "Temp (f)";
            series7.Name = "Series_TempFreqData";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_Temps.Series.Add(series3);
            this.chart_Temps.Series.Add(series4);
            this.chart_Temps.Series.Add(series5);
            this.chart_Temps.Series.Add(series6);
            this.chart_Temps.Series.Add(series7);
            this.chart_Temps.Size = new System.Drawing.Size(656, 462);
            this.chart_Temps.TabIndex = 36;
            this.chart_Temps.Text = "Temperatures";
            title2.Name = "Title1";
            title2.Text = "Temperature";
            this.chart_Temps.Titles.Add(title2);
            // 
            // button_SaveFlash
            // 
            this.button_SaveFlash.Location = new System.Drawing.Point(50, 38);
            this.button_SaveFlash.Name = "button_SaveFlash";
            this.button_SaveFlash.Size = new System.Drawing.Size(297, 58);
            this.button_SaveFlash.TabIndex = 35;
            this.button_SaveFlash.Text = "Save Flash";
            this.button_SaveFlash.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_U_HeaterSet
            // 
            this.numericUpDown_U_HeaterSet.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterSet.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_HeaterSet.Location = new System.Drawing.Point(208, 118);
            this.numericUpDown_U_HeaterSet.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterSet.Name = "numericUpDown_U_HeaterSet";
            this.numericUpDown_U_HeaterSet.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown_U_HeaterSet.TabIndex = 33;
            this.numericUpDown_U_HeaterSet.ValueChanged += new System.EventHandler(this.numericUpDown_U_HeaterSet_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(46, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 20);
            this.label21.TabIndex = 32;
            this.label21.Text = "U_Heater Set, V";
            // 
            // groupBox_Meas
            // 
            this.groupBox_Meas.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Meas.Location = new System.Drawing.Point(38, 678);
            this.groupBox_Meas.Name = "groupBox_Meas";
            this.groupBox_Meas.Size = new System.Drawing.Size(740, 442);
            this.groupBox_Meas.TabIndex = 31;
            this.groupBox_Meas.TabStop = false;
            this.groupBox_Meas.Text = "Measurements";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmFreqMasked, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentCh1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp4Masked, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmFreq, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp3Masked, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp2Masked, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMax, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMin, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp4, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMeas, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp3, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.label24, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp2, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp1, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh1Meas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Max, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Max, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Max, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Max, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh1Max, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh2Meas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmCurrentCh1Masked, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmU_HeaterMasked, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmU_PowerMasked, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_U_Power, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Min, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmCurrentCh2Masked, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Min, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label_U_Heater, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Min, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMeas, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Min, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMeas, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Meas, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMin, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Meas, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh2Max, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Meas, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMax, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Meas, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMax, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmCurrentCh1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmCurrentCh2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmU_Power, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmU_Heater, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp1Masked, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label32, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 417);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // checkBox_AlarmFreqMasked
            // 
            this.checkBox_AlarmFreqMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmFreqMasked.AutoSize = true;
            this.checkBox_AlarmFreqMasked.Location = new System.Drawing.Point(684, 383);
            this.checkBox_AlarmFreqMasked.Name = "checkBox_AlarmFreqMasked";
            this.checkBox_AlarmFreqMasked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmFreqMasked.TabIndex = 77;
            this.checkBox_AlarmFreqMasked.UseVisualStyleBackColor = true;
            // 
            // label_CurrentCh1
            // 
            this.label_CurrentCh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CurrentCh1.AutoSize = true;
            this.label_CurrentCh1.Location = new System.Drawing.Point(16, 45);
            this.label_CurrentCh1.Name = "label_CurrentCh1";
            this.label_CurrentCh1.Size = new System.Drawing.Size(114, 20);
            this.label_CurrentCh1.TabIndex = 28;
            this.label_CurrentCh1.Text = "Current Ch1, A";
            this.label_CurrentCh1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp4Masked
            // 
            this.checkBox_AlarmTemp4Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp4Masked.AutoSize = true;
            this.checkBox_AlarmTemp4Masked.Location = new System.Drawing.Point(684, 341);
            this.checkBox_AlarmTemp4Masked.Name = "checkBox_AlarmTemp4Masked";
            this.checkBox_AlarmTemp4Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmTemp4Masked.TabIndex = 74;
            this.checkBox_AlarmTemp4Masked.UseVisualStyleBackColor = true;
            // 
            // pictureBox_AlarmFreq
            // 
            this.pictureBox_AlarmFreq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmFreq.Location = new System.Drawing.Point(605, 378);
            this.pictureBox_AlarmFreq.Name = "pictureBox_AlarmFreq";
            this.pictureBox_AlarmFreq.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmFreq.TabIndex = 68;
            this.pictureBox_AlarmFreq.TabStop = false;
            // 
            // checkBox_AlarmTemp3Masked
            // 
            this.checkBox_AlarmTemp3Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp3Masked.AutoSize = true;
            this.checkBox_AlarmTemp3Masked.Location = new System.Drawing.Point(684, 304);
            this.checkBox_AlarmTemp3Masked.Name = "checkBox_AlarmTemp3Masked";
            this.checkBox_AlarmTemp3Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmTemp3Masked.TabIndex = 73;
            this.checkBox_AlarmTemp3Masked.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 20);
            this.label23.TabIndex = 43;
            this.label23.Text = "Meas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp2Masked
            // 
            this.checkBox_AlarmTemp2Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp2Masked.AutoSize = true;
            this.checkBox_AlarmTemp2Masked.Location = new System.Drawing.Point(684, 267);
            this.checkBox_AlarmTemp2Masked.Name = "checkBox_AlarmTemp2Masked";
            this.checkBox_AlarmTemp2Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmTemp2Masked.TabIndex = 72;
            this.checkBox_AlarmTemp2Masked.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_FreqMax
            // 
            this.numericUpDown_FreqMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMax.Location = new System.Drawing.Point(451, 380);
            this.numericUpDown_FreqMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMax.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_FreqMax.Name = "numericUpDown_FreqMax";
            this.numericUpDown_FreqMax.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_FreqMax.TabIndex = 76;
            this.numericUpDown_FreqMax.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 20);
            this.label22.TabIndex = 42;
            this.label22.Text = "Min";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_FreqMin
            // 
            this.numericUpDown_FreqMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMin.Location = new System.Drawing.Point(305, 380);
            this.numericUpDown_FreqMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_FreqMin.Name = "numericUpDown_FreqMin";
            this.numericUpDown_FreqMin.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_FreqMin.TabIndex = 35;
            this.numericUpDown_FreqMin.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp4
            // 
            this.pictureBox_AlarmTemp4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp4.Location = new System.Drawing.Point(605, 336);
            this.pictureBox_AlarmTemp4.Name = "pictureBox_AlarmTemp4";
            this.pictureBox_AlarmTemp4.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmTemp4.TabIndex = 67;
            this.pictureBox_AlarmTemp4.TabStop = false;
            // 
            // numericUpDown_FreqMeas
            // 
            this.numericUpDown_FreqMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMeas.Location = new System.Drawing.Point(159, 380);
            this.numericUpDown_FreqMeas.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMeas.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_FreqMeas.Name = "numericUpDown_FreqMeas";
            this.numericUpDown_FreqMeas.ReadOnly = true;
            this.numericUpDown_FreqMeas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_FreqMeas.TabIndex = 35;
            this.numericUpDown_FreqMeas.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // pictureBox_AlarmTemp3
            // 
            this.pictureBox_AlarmTemp3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp3.Location = new System.Drawing.Point(605, 299);
            this.pictureBox_AlarmTemp3.Name = "pictureBox_AlarmTemp3";
            this.pictureBox_AlarmTemp3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmTemp3.TabIndex = 66;
            this.pictureBox_AlarmTemp3.TabStop = false;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(663, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 20);
            this.label24.TabIndex = 68;
            this.label24.Text = "Masked";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp2
            // 
            this.pictureBox_AlarmTemp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp2.Location = new System.Drawing.Point(605, 262);
            this.pictureBox_AlarmTemp2.Name = "pictureBox_AlarmTemp2";
            this.pictureBox_AlarmTemp2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmTemp2.TabIndex = 65;
            this.pictureBox_AlarmTemp2.TabStop = false;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(38, 383);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 20);
            this.label26.TabIndex = 75;
            this.label26.Text = "Freq, Hz";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp1
            // 
            this.pictureBox_AlarmTemp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp1.Location = new System.Drawing.Point(605, 225);
            this.pictureBox_AlarmTemp1.Name = "pictureBox_AlarmTemp1";
            this.pictureBox_AlarmTemp1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmTemp1.TabIndex = 64;
            this.pictureBox_AlarmTemp1.TabStop = false;
            // 
            // numericUpDown_CurrentCh1Meas
            // 
            this.numericUpDown_CurrentCh1Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh1Meas.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh1Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh1Meas.Location = new System.Drawing.Point(159, 42);
            this.numericUpDown_CurrentCh1Meas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh1Meas.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh1Meas.Name = "numericUpDown_CurrentCh1Meas";
            this.numericUpDown_CurrentCh1Meas.ReadOnly = true;
            this.numericUpDown_CurrentCh1Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CurrentCh1Meas.TabIndex = 27;
            // 
            // numericUpDown_Temp1Max
            // 
            this.numericUpDown_Temp1Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Max.DecimalPlaces = 2;
            this.numericUpDown_Temp1Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Max.Location = new System.Drawing.Point(451, 227);
            this.numericUpDown_Temp1Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp1Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Max.Name = "numericUpDown_Temp1Max";
            this.numericUpDown_Temp1Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp1Max.TabIndex = 60;
            // 
            // numericUpDown_Temp2Max
            // 
            this.numericUpDown_Temp2Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Max.DecimalPlaces = 2;
            this.numericUpDown_Temp2Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Max.Location = new System.Drawing.Point(451, 264);
            this.numericUpDown_Temp2Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp2Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Max.Name = "numericUpDown_Temp2Max";
            this.numericUpDown_Temp2Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp2Max.TabIndex = 61;
            // 
            // numericUpDown_Temp3Max
            // 
            this.numericUpDown_Temp3Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Max.DecimalPlaces = 2;
            this.numericUpDown_Temp3Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Max.Location = new System.Drawing.Point(451, 301);
            this.numericUpDown_Temp3Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp3Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Max.Name = "numericUpDown_Temp3Max";
            this.numericUpDown_Temp3Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp3Max.TabIndex = 62;
            // 
            // numericUpDown_Temp4Max
            // 
            this.numericUpDown_Temp4Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Max.DecimalPlaces = 2;
            this.numericUpDown_Temp4Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Max.Location = new System.Drawing.Point(451, 338);
            this.numericUpDown_Temp4Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp4Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Max.Name = "numericUpDown_Temp4Max";
            this.numericUpDown_Temp4Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp4Max.TabIndex = 63;
            // 
            // numericUpDown_CurrentCh1Max
            // 
            this.numericUpDown_CurrentCh1Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh1Max.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh1Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh1Max.Location = new System.Drawing.Point(451, 42);
            this.numericUpDown_CurrentCh1Max.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh1Max.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh1Max.Name = "numericUpDown_CurrentCh1Max";
            this.numericUpDown_CurrentCh1Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CurrentCh1Max.TabIndex = 46;
            // 
            // numericUpDown_CurrentCh2Meas
            // 
            this.numericUpDown_CurrentCh2Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh2Meas.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh2Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh2Meas.Location = new System.Drawing.Point(159, 79);
            this.numericUpDown_CurrentCh2Meas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh2Meas.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh2Meas.Name = "numericUpDown_CurrentCh2Meas";
            this.numericUpDown_CurrentCh2Meas.ReadOnly = true;
            this.numericUpDown_CurrentCh2Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CurrentCh2Meas.TabIndex = 41;
            // 
            // checkBox_AlarmCurrentCh1Masked
            // 
            this.checkBox_AlarmCurrentCh1Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmCurrentCh1Masked.AutoSize = true;
            this.checkBox_AlarmCurrentCh1Masked.Location = new System.Drawing.Point(684, 45);
            this.checkBox_AlarmCurrentCh1Masked.Name = "checkBox_AlarmCurrentCh1Masked";
            this.checkBox_AlarmCurrentCh1Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmCurrentCh1Masked.TabIndex = 34;
            this.checkBox_AlarmCurrentCh1Masked.UseVisualStyleBackColor = true;
            // 
            // checkBox_AlarmU_HeaterMasked
            // 
            this.checkBox_AlarmU_HeaterMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmU_HeaterMasked.AutoSize = true;
            this.checkBox_AlarmU_HeaterMasked.Location = new System.Drawing.Point(684, 156);
            this.checkBox_AlarmU_HeaterMasked.Name = "checkBox_AlarmU_HeaterMasked";
            this.checkBox_AlarmU_HeaterMasked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmU_HeaterMasked.TabIndex = 70;
            this.checkBox_AlarmU_HeaterMasked.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Current Ch2, A";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmU_PowerMasked
            // 
            this.checkBox_AlarmU_PowerMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmU_PowerMasked.AutoSize = true;
            this.checkBox_AlarmU_PowerMasked.Location = new System.Drawing.Point(684, 119);
            this.checkBox_AlarmU_PowerMasked.Name = "checkBox_AlarmU_PowerMasked";
            this.checkBox_AlarmU_PowerMasked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmU_PowerMasked.TabIndex = 69;
            this.checkBox_AlarmU_PowerMasked.UseVisualStyleBackColor = true;
            // 
            // label_U_Power
            // 
            this.label_U_Power.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_U_Power.AutoSize = true;
            this.label_U_Power.Location = new System.Drawing.Point(26, 119);
            this.label_U_Power.Name = "label_U_Power";
            this.label_U_Power.Size = new System.Drawing.Size(93, 20);
            this.label_U_Power.TabIndex = 0;
            this.label_U_Power.Text = "U_Power, V";
            this.label_U_Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Temp4Min
            // 
            this.numericUpDown_Temp4Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Min.DecimalPlaces = 2;
            this.numericUpDown_Temp4Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Min.Location = new System.Drawing.Point(305, 338);
            this.numericUpDown_Temp4Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp4Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Min.Name = "numericUpDown_Temp4Min";
            this.numericUpDown_Temp4Min.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp4Min.TabIndex = 59;
            // 
            // checkBox_AlarmCurrentCh2Masked
            // 
            this.checkBox_AlarmCurrentCh2Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmCurrentCh2Masked.AutoSize = true;
            this.checkBox_AlarmCurrentCh2Masked.Location = new System.Drawing.Point(684, 82);
            this.checkBox_AlarmCurrentCh2Masked.Name = "checkBox_AlarmCurrentCh2Masked";
            this.checkBox_AlarmCurrentCh2Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmCurrentCh2Masked.TabIndex = 35;
            this.checkBox_AlarmCurrentCh2Masked.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Temp3Min
            // 
            this.numericUpDown_Temp3Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Min.DecimalPlaces = 2;
            this.numericUpDown_Temp3Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Min.Location = new System.Drawing.Point(305, 301);
            this.numericUpDown_Temp3Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp3Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Min.Name = "numericUpDown_Temp3Min";
            this.numericUpDown_Temp3Min.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp3Min.TabIndex = 58;
            // 
            // label_U_Heater
            // 
            this.label_U_Heater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_U_Heater.AutoSize = true;
            this.label_U_Heater.Location = new System.Drawing.Point(24, 156);
            this.label_U_Heater.Name = "label_U_Heater";
            this.label_U_Heater.Size = new System.Drawing.Size(98, 20);
            this.label_U_Heater.TabIndex = 1;
            this.label_U_Heater.Text = "U_Heater, V";
            this.label_U_Heater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Temp2Min
            // 
            this.numericUpDown_Temp2Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Min.DecimalPlaces = 2;
            this.numericUpDown_Temp2Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Min.Location = new System.Drawing.Point(305, 264);
            this.numericUpDown_Temp2Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp2Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Min.Name = "numericUpDown_Temp2Min";
            this.numericUpDown_Temp2Min.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp2Min.TabIndex = 57;
            // 
            // numericUpDown_U_PowerMeas
            // 
            this.numericUpDown_U_PowerMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMeas.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMeas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_U_PowerMeas.Location = new System.Drawing.Point(159, 116);
            this.numericUpDown_U_PowerMeas.Name = "numericUpDown_U_PowerMeas";
            this.numericUpDown_U_PowerMeas.ReadOnly = true;
            this.numericUpDown_U_PowerMeas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_PowerMeas.TabIndex = 3;
            // 
            // numericUpDown_Temp1Min
            // 
            this.numericUpDown_Temp1Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Min.DecimalPlaces = 2;
            this.numericUpDown_Temp1Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Min.Location = new System.Drawing.Point(305, 227);
            this.numericUpDown_Temp1Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp1Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Min.Name = "numericUpDown_Temp1Min";
            this.numericUpDown_Temp1Min.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp1Min.TabIndex = 56;
            // 
            // numericUpDown_U_HeaterMeas
            // 
            this.numericUpDown_U_HeaterMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMeas.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMeas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_U_HeaterMeas.Location = new System.Drawing.Point(159, 153);
            this.numericUpDown_U_HeaterMeas.Name = "numericUpDown_U_HeaterMeas";
            this.numericUpDown_U_HeaterMeas.ReadOnly = true;
            this.numericUpDown_U_HeaterMeas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_HeaterMeas.TabIndex = 4;
            // 
            // numericUpDown_U_HeaterMin
            // 
            this.numericUpDown_U_HeaterMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMin.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_U_HeaterMin.Location = new System.Drawing.Point(305, 153);
            this.numericUpDown_U_HeaterMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMin.Name = "numericUpDown_U_HeaterMin";
            this.numericUpDown_U_HeaterMin.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_HeaterMin.TabIndex = 50;
            // 
            // numericUpDown_Temp4Meas
            // 
            this.numericUpDown_Temp4Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp4Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Meas.Location = new System.Drawing.Point(159, 338);
            this.numericUpDown_Temp4Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp4Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Meas.Name = "numericUpDown_Temp4Meas";
            this.numericUpDown_Temp4Meas.ReadOnly = true;
            this.numericUpDown_Temp4Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp4Meas.TabIndex = 39;
            // 
            // numericUpDown_U_PowerMin
            // 
            this.numericUpDown_U_PowerMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMin.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_PowerMin.Location = new System.Drawing.Point(305, 116);
            this.numericUpDown_U_PowerMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMin.Name = "numericUpDown_U_PowerMin";
            this.numericUpDown_U_PowerMin.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_PowerMin.TabIndex = 48;
            // 
            // numericUpDown_Temp3Meas
            // 
            this.numericUpDown_Temp3Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp3Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Meas.Location = new System.Drawing.Point(159, 301);
            this.numericUpDown_Temp3Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp3Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Meas.Name = "numericUpDown_Temp3Meas";
            this.numericUpDown_Temp3Meas.ReadOnly = true;
            this.numericUpDown_Temp3Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp3Meas.TabIndex = 38;
            // 
            // numericUpDown_CurrentCh2Max
            // 
            this.numericUpDown_CurrentCh2Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh2Max.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh2Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh2Max.Location = new System.Drawing.Point(451, 79);
            this.numericUpDown_CurrentCh2Max.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh2Max.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh2Max.Name = "numericUpDown_CurrentCh2Max";
            this.numericUpDown_CurrentCh2Max.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CurrentCh2Max.TabIndex = 47;
            // 
            // numericUpDown_Temp2Meas
            // 
            this.numericUpDown_Temp2Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp2Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Meas.Location = new System.Drawing.Point(159, 264);
            this.numericUpDown_Temp2Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp2Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Meas.Name = "numericUpDown_Temp2Meas";
            this.numericUpDown_Temp2Meas.ReadOnly = true;
            this.numericUpDown_Temp2Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp2Meas.TabIndex = 37;
            // 
            // numericUpDown_U_PowerMax
            // 
            this.numericUpDown_U_PowerMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMax.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_PowerMax.Location = new System.Drawing.Point(451, 116);
            this.numericUpDown_U_PowerMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMax.Name = "numericUpDown_U_PowerMax";
            this.numericUpDown_U_PowerMax.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_PowerMax.TabIndex = 49;
            this.numericUpDown_U_PowerMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_Temp1Meas
            // 
            this.numericUpDown_Temp1Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp1Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Meas.Location = new System.Drawing.Point(159, 227);
            this.numericUpDown_Temp1Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp1Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Meas.Name = "numericUpDown_Temp1Meas";
            this.numericUpDown_Temp1Meas.ReadOnly = true;
            this.numericUpDown_Temp1Meas.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp1Meas.TabIndex = 32;
            // 
            // numericUpDown_U_HeaterMax
            // 
            this.numericUpDown_U_HeaterMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMax.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_HeaterMax.Location = new System.Drawing.Point(451, 153);
            this.numericUpDown_U_HeaterMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMax.Name = "numericUpDown_U_HeaterMax";
            this.numericUpDown_U_HeaterMax.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_HeaterMax.TabIndex = 51;
            this.numericUpDown_U_HeaterMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pictureBox_AlarmCurrentCh1
            // 
            this.pictureBox_AlarmCurrentCh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmCurrentCh1.Location = new System.Drawing.Point(605, 40);
            this.pictureBox_AlarmCurrentCh1.Name = "pictureBox_AlarmCurrentCh1";
            this.pictureBox_AlarmCurrentCh1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmCurrentCh1.TabIndex = 52;
            this.pictureBox_AlarmCurrentCh1.TabStop = false;
            this.pictureBox_AlarmCurrentCh1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 341);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Temp 4, °C";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmCurrentCh2
            // 
            this.pictureBox_AlarmCurrentCh2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmCurrentCh2.Location = new System.Drawing.Point(605, 77);
            this.pictureBox_AlarmCurrentCh2.Name = "pictureBox_AlarmCurrentCh2";
            this.pictureBox_AlarmCurrentCh2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmCurrentCh2.TabIndex = 53;
            this.pictureBox_AlarmCurrentCh2.TabStop = false;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Temp 3, °C";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmU_Power
            // 
            this.pictureBox_AlarmU_Power.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmU_Power.Location = new System.Drawing.Point(605, 114);
            this.pictureBox_AlarmU_Power.Name = "pictureBox_AlarmU_Power";
            this.pictureBox_AlarmU_Power.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmU_Power.TabIndex = 54;
            this.pictureBox_AlarmU_Power.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Temp 2, °C";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmU_Heater
            // 
            this.pictureBox_AlarmU_Heater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmU_Heater.Location = new System.Drawing.Point(605, 151);
            this.pictureBox_AlarmU_Heater.Name = "pictureBox_AlarmU_Heater";
            this.pictureBox_AlarmU_Heater.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_AlarmU_Heater.TabIndex = 55;
            this.pictureBox_AlarmU_Heater.TabStop = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Temp 1, °C";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp1Masked
            // 
            this.checkBox_AlarmTemp1Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp1Masked.AutoSize = true;
            this.checkBox_AlarmTemp1Masked.Location = new System.Drawing.Point(684, 230);
            this.checkBox_AlarmTemp1Masked.Name = "checkBox_AlarmTemp1Masked";
            this.checkBox_AlarmTemp1Masked.Size = new System.Drawing.Size(22, 21);
            this.checkBox_AlarmTemp1Masked.TabIndex = 71;
            this.checkBox_AlarmTemp1Masked.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(595, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 20);
            this.label32.TabIndex = 78;
            this.label32.Text = "Alarm";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Channel2
            // 
            this.groupBox_Channel2.Controls.Add(this.label30);
            this.groupBox_Channel2.Controls.Add(this.numericUpDown_ISet2);
            this.groupBox_Channel2.Controls.Add(this.checkBox_Polarity2);
            this.groupBox_Channel2.Controls.Add(this.label28);
            this.groupBox_Channel2.Controls.Add(this.groupBox_Temp2);
            this.groupBox_Channel2.Controls.Add(this.groupBox_Freq2);
            this.groupBox_Channel2.Controls.Add(this.button_EnableCh2);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Source2);
            this.groupBox_Channel2.Controls.Add(this.label13);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Mode2);
            this.groupBox_Channel2.Controls.Add(this.label14);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Load2);
            this.groupBox_Channel2.Controls.Add(this.label15);
            this.groupBox_Channel2.Location = new System.Drawing.Point(411, 168);
            this.groupBox_Channel2.Name = "groupBox_Channel2";
            this.groupBox_Channel2.Size = new System.Drawing.Size(368, 506);
            this.groupBox_Channel2.TabIndex = 30;
            this.groupBox_Channel2.TabStop = false;
            this.groupBox_Channel2.Text = "Channel 2";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 215);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 20);
            this.label30.TabIndex = 46;
            this.label30.Text = "I Set, %";
            // 
            // numericUpDown_ISet2
            // 
            this.numericUpDown_ISet2.DecimalPlaces = 2;
            this.numericUpDown_ISet2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ISet2.Location = new System.Drawing.Point(160, 214);
            this.numericUpDown_ISet2.Name = "numericUpDown_ISet2";
            this.numericUpDown_ISet2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ISet2.TabIndex = 46;
            // 
            // checkBox_Polarity2
            // 
            this.checkBox_Polarity2.AutoSize = true;
            this.checkBox_Polarity2.Location = new System.Drawing.Point(160, 178);
            this.checkBox_Polarity2.Name = "checkBox_Polarity2";
            this.checkBox_Polarity2.Size = new System.Drawing.Size(103, 24);
            this.checkBox_Polarity2.TabIndex = 37;
            this.checkBox_Polarity2.Text = "Reversed";
            this.checkBox_Polarity2.UseVisualStyleBackColor = true;
            this.checkBox_Polarity2.Click += new System.EventHandler(this.checkBox_Polarity2_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 178);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 20);
            this.label28.TabIndex = 33;
            this.label28.Text = "Polarity";
            // 
            // groupBox_Temp2
            // 
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_SetPointTemp2);
            this.groupBox_Temp2.Controls.Add(this.label5);
            this.groupBox_Temp2.Controls.Add(this.label6);
            this.groupBox_Temp2.Controls.Add(this.label7);
            this.groupBox_Temp2.Controls.Add(this.label8);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_PTemp2);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_DTemp2);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_ITemp2);
            this.groupBox_Temp2.Location = new System.Drawing.Point(22, 255);
            this.groupBox_Temp2.Name = "groupBox_Temp2";
            this.groupBox_Temp2.Size = new System.Drawing.Size(171, 188);
            this.groupBox_Temp2.TabIndex = 31;
            this.groupBox_Temp2.TabStop = false;
            this.groupBox_Temp2.Text = "Temp Source";
            // 
            // numericUpDown_SetPointTemp2
            // 
            this.numericUpDown_SetPointTemp2.DecimalPlaces = 2;
            this.numericUpDown_SetPointTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_SetPointTemp2.Location = new System.Drawing.Point(20, 55);
            this.numericUpDown_SetPointTemp2.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_SetPointTemp2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_SetPointTemp2.Name = "numericUpDown_SetPointTemp2";
            this.numericUpDown_SetPointTemp2.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown_SetPointTemp2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Temp Setpoint, °C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "D";
            // 
            // numericUpDown_PTemp2
            // 
            this.numericUpDown_PTemp2.DecimalPlaces = 2;
            this.numericUpDown_PTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PTemp2.Location = new System.Drawing.Point(40, 88);
            this.numericUpDown_PTemp2.Name = "numericUpDown_PTemp2";
            this.numericUpDown_PTemp2.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_PTemp2.TabIndex = 15;
            // 
            // numericUpDown_DTemp2
            // 
            this.numericUpDown_DTemp2.DecimalPlaces = 2;
            this.numericUpDown_DTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DTemp2.Location = new System.Drawing.Point(40, 146);
            this.numericUpDown_DTemp2.Name = "numericUpDown_DTemp2";
            this.numericUpDown_DTemp2.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_DTemp2.TabIndex = 17;
            // 
            // numericUpDown_ITemp2
            // 
            this.numericUpDown_ITemp2.DecimalPlaces = 2;
            this.numericUpDown_ITemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ITemp2.Location = new System.Drawing.Point(40, 115);
            this.numericUpDown_ITemp2.Name = "numericUpDown_ITemp2";
            this.numericUpDown_ITemp2.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_ITemp2.TabIndex = 16;
            // 
            // groupBox_Freq2
            // 
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_SetPointFreq2);
            this.groupBox_Freq2.Controls.Add(this.label9);
            this.groupBox_Freq2.Controls.Add(this.label10);
            this.groupBox_Freq2.Controls.Add(this.label11);
            this.groupBox_Freq2.Controls.Add(this.label12);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_DFreq2);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_PFreq2);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_IFreq2);
            this.groupBox_Freq2.Location = new System.Drawing.Point(200, 255);
            this.groupBox_Freq2.Name = "groupBox_Freq2";
            this.groupBox_Freq2.Size = new System.Drawing.Size(153, 188);
            this.groupBox_Freq2.TabIndex = 30;
            this.groupBox_Freq2.TabStop = false;
            this.groupBox_Freq2.Text = "Freq Source";
            // 
            // numericUpDown_SetPointFreq2
            // 
            this.numericUpDown_SetPointFreq2.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown_SetPointFreq2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq2.Name = "numericUpDown_SetPointFreq2";
            this.numericUpDown_SetPointFreq2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_SetPointFreq2.TabIndex = 19;
            this.numericUpDown_SetPointFreq2.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Freq Setpoint, Hz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "P";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "I";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "D";
            // 
            // numericUpDown_DFreq2
            // 
            this.numericUpDown_DFreq2.DecimalPlaces = 2;
            this.numericUpDown_DFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DFreq2.Location = new System.Drawing.Point(39, 146);
            this.numericUpDown_DFreq2.Name = "numericUpDown_DFreq2";
            this.numericUpDown_DFreq2.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_DFreq2.TabIndex = 25;
            // 
            // numericUpDown_PFreq2
            // 
            this.numericUpDown_PFreq2.DecimalPlaces = 2;
            this.numericUpDown_PFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PFreq2.Location = new System.Drawing.Point(39, 88);
            this.numericUpDown_PFreq2.Name = "numericUpDown_PFreq2";
            this.numericUpDown_PFreq2.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_PFreq2.TabIndex = 23;
            // 
            // numericUpDown_IFreq2
            // 
            this.numericUpDown_IFreq2.DecimalPlaces = 2;
            this.numericUpDown_IFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IFreq2.Location = new System.Drawing.Point(39, 115);
            this.numericUpDown_IFreq2.Name = "numericUpDown_IFreq2";
            this.numericUpDown_IFreq2.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_IFreq2.TabIndex = 24;
            // 
            // button_EnableCh2
            // 
            this.button_EnableCh2.Location = new System.Drawing.Point(22, 449);
            this.button_EnableCh2.Name = "button_EnableCh2";
            this.button_EnableCh2.Size = new System.Drawing.Size(330, 45);
            this.button_EnableCh2.TabIndex = 26;
            this.button_EnableCh2.Text = "Enable";
            this.button_EnableCh2.UseVisualStyleBackColor = true;
            this.button_EnableCh2.Click += new System.EventHandler(this.button_EnableCh2_Click);
            // 
            // comboBox_Source2
            // 
            this.comboBox_Source2.FormattingEnabled = true;
            this.comboBox_Source2.Items.AddRange(new object[] {
            "Temp1",
            "Temp2",
            "Temp3",
            "Temp4",
            "Freq"});
            this.comboBox_Source2.Location = new System.Drawing.Point(160, 128);
            this.comboBox_Source2.Name = "comboBox_Source2";
            this.comboBox_Source2.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Source2.TabIndex = 9;
            this.comboBox_Source2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Source2_SelectedIndexChanged);
            this.comboBox_Source2.EnabledChanged += new System.EventHandler(this.comboBox_Source2_EnabledChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Source";
            // 
            // comboBox_Mode2
            // 
            this.comboBox_Mode2.FormattingEnabled = true;
            this.comboBox_Mode2.Items.AddRange(new object[] {
            "PID",
            "Const current"});
            this.comboBox_Mode2.Location = new System.Drawing.Point(160, 82);
            this.comboBox_Mode2.Name = "comboBox_Mode2";
            this.comboBox_Mode2.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Mode2.TabIndex = 7;
            this.comboBox_Mode2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Mode";
            // 
            // comboBox_Load2
            // 
            this.comboBox_Load2.FormattingEnabled = true;
            this.comboBox_Load2.Items.AddRange(new object[] {
            "Resistor",
            "Peltier"});
            this.comboBox_Load2.Location = new System.Drawing.Point(160, 31);
            this.comboBox_Load2.Name = "comboBox_Load2";
            this.comboBox_Load2.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Load2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Load";
            // 
            // groupBox_Channel1
            // 
            this.groupBox_Channel1.Controls.Add(this.numericUpDown_ISet1);
            this.groupBox_Channel1.Controls.Add(this.label29);
            this.groupBox_Channel1.Controls.Add(this.checkBox_Polarity1);
            this.groupBox_Channel1.Controls.Add(this.label27);
            this.groupBox_Channel1.Controls.Add(this.groupBox_Temp1);
            this.groupBox_Channel1.Controls.Add(this.groupBox_Freq1);
            this.groupBox_Channel1.Controls.Add(this.button_EnableCh1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Source1);
            this.groupBox_Channel1.Controls.Add(this.label_Source1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Mode1);
            this.groupBox_Channel1.Controls.Add(this.label_Mode1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Load1);
            this.groupBox_Channel1.Controls.Add(this.label_Load1);
            this.groupBox_Channel1.Location = new System.Drawing.Point(38, 168);
            this.groupBox_Channel1.Name = "groupBox_Channel1";
            this.groupBox_Channel1.Size = new System.Drawing.Size(368, 506);
            this.groupBox_Channel1.TabIndex = 5;
            this.groupBox_Channel1.TabStop = false;
            this.groupBox_Channel1.Text = "Channel 1";
            // 
            // numericUpDown_ISet1
            // 
            this.numericUpDown_ISet1.DecimalPlaces = 2;
            this.numericUpDown_ISet1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ISet1.Location = new System.Drawing.Point(160, 214);
            this.numericUpDown_ISet1.Name = "numericUpDown_ISet1";
            this.numericUpDown_ISet1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ISet1.TabIndex = 45;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 220);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 20);
            this.label29.TabIndex = 37;
            this.label29.Text = "I Set, %";
            // 
            // checkBox_Polarity1
            // 
            this.checkBox_Polarity1.AutoSize = true;
            this.checkBox_Polarity1.Location = new System.Drawing.Point(160, 182);
            this.checkBox_Polarity1.Name = "checkBox_Polarity1";
            this.checkBox_Polarity1.Size = new System.Drawing.Size(103, 24);
            this.checkBox_Polarity1.TabIndex = 36;
            this.checkBox_Polarity1.Text = "Reversed";
            this.checkBox_Polarity1.UseVisualStyleBackColor = true;
            this.checkBox_Polarity1.Click += new System.EventHandler(this.checkBox_Polarity1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 182);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 32;
            this.label27.Text = "Polarity";
            // 
            // groupBox_Temp1
            // 
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_SetPointTemp1);
            this.groupBox_Temp1.Controls.Add(this.label_SetPointTemp);
            this.groupBox_Temp1.Controls.Add(this.label_PTemp1);
            this.groupBox_Temp1.Controls.Add(this.label_ITemp1);
            this.groupBox_Temp1.Controls.Add(this.label_DTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_PTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_DTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_ITemp1);
            this.groupBox_Temp1.Location = new System.Drawing.Point(20, 255);
            this.groupBox_Temp1.Name = "groupBox_Temp1";
            this.groupBox_Temp1.Size = new System.Drawing.Size(171, 188);
            this.groupBox_Temp1.TabIndex = 31;
            this.groupBox_Temp1.TabStop = false;
            this.groupBox_Temp1.Text = "Temp Source";
            // 
            // numericUpDown_SetPointTemp1
            // 
            this.numericUpDown_SetPointTemp1.DecimalPlaces = 2;
            this.numericUpDown_SetPointTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_SetPointTemp1.Location = new System.Drawing.Point(20, 55);
            this.numericUpDown_SetPointTemp1.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_SetPointTemp1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_SetPointTemp1.Name = "numericUpDown_SetPointTemp1";
            this.numericUpDown_SetPointTemp1.Size = new System.Drawing.Size(134, 26);
            this.numericUpDown_SetPointTemp1.TabIndex = 11;
            // 
            // label_SetPointTemp
            // 
            this.label_SetPointTemp.AutoSize = true;
            this.label_SetPointTemp.Location = new System.Drawing.Point(16, 32);
            this.label_SetPointTemp.Name = "label_SetPointTemp";
            this.label_SetPointTemp.Size = new System.Drawing.Size(137, 20);
            this.label_SetPointTemp.TabIndex = 10;
            this.label_SetPointTemp.Text = "Temp Setpoint, °C";
            // 
            // label_PTemp1
            // 
            this.label_PTemp1.AutoSize = true;
            this.label_PTemp1.Location = new System.Drawing.Point(16, 91);
            this.label_PTemp1.Name = "label_PTemp1";
            this.label_PTemp1.Size = new System.Drawing.Size(19, 20);
            this.label_PTemp1.TabIndex = 12;
            this.label_PTemp1.Text = "P";
            // 
            // label_ITemp1
            // 
            this.label_ITemp1.AutoSize = true;
            this.label_ITemp1.Location = new System.Drawing.Point(18, 118);
            this.label_ITemp1.Name = "label_ITemp1";
            this.label_ITemp1.Size = new System.Drawing.Size(14, 20);
            this.label_ITemp1.TabIndex = 13;
            this.label_ITemp1.Text = "I";
            // 
            // label_DTemp1
            // 
            this.label_DTemp1.AutoSize = true;
            this.label_DTemp1.Location = new System.Drawing.Point(15, 149);
            this.label_DTemp1.Name = "label_DTemp1";
            this.label_DTemp1.Size = new System.Drawing.Size(21, 20);
            this.label_DTemp1.TabIndex = 14;
            this.label_DTemp1.Text = "D";
            // 
            // numericUpDown_PTemp1
            // 
            this.numericUpDown_PTemp1.DecimalPlaces = 2;
            this.numericUpDown_PTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PTemp1.Location = new System.Drawing.Point(40, 88);
            this.numericUpDown_PTemp1.Name = "numericUpDown_PTemp1";
            this.numericUpDown_PTemp1.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_PTemp1.TabIndex = 15;
            // 
            // numericUpDown_DTemp1
            // 
            this.numericUpDown_DTemp1.DecimalPlaces = 2;
            this.numericUpDown_DTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DTemp1.Location = new System.Drawing.Point(40, 146);
            this.numericUpDown_DTemp1.Name = "numericUpDown_DTemp1";
            this.numericUpDown_DTemp1.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_DTemp1.TabIndex = 17;
            // 
            // numericUpDown_ITemp1
            // 
            this.numericUpDown_ITemp1.DecimalPlaces = 2;
            this.numericUpDown_ITemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ITemp1.Location = new System.Drawing.Point(40, 115);
            this.numericUpDown_ITemp1.Name = "numericUpDown_ITemp1";
            this.numericUpDown_ITemp1.Size = new System.Drawing.Size(112, 26);
            this.numericUpDown_ITemp1.TabIndex = 16;
            // 
            // groupBox_Freq1
            // 
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_SetPointFreq1);
            this.groupBox_Freq1.Controls.Add(this.label_SetPointFreq);
            this.groupBox_Freq1.Controls.Add(this.label3);
            this.groupBox_Freq1.Controls.Add(this.label2);
            this.groupBox_Freq1.Controls.Add(this.label1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_DFreq1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_PFreq1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_IFreq1);
            this.groupBox_Freq1.Location = new System.Drawing.Point(196, 255);
            this.groupBox_Freq1.Name = "groupBox_Freq1";
            this.groupBox_Freq1.Size = new System.Drawing.Size(153, 188);
            this.groupBox_Freq1.TabIndex = 30;
            this.groupBox_Freq1.TabStop = false;
            this.groupBox_Freq1.Text = "Freq Source";
            // 
            // numericUpDown_SetPointFreq1
            // 
            this.numericUpDown_SetPointFreq1.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown_SetPointFreq1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq1.Name = "numericUpDown_SetPointFreq1";
            this.numericUpDown_SetPointFreq1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_SetPointFreq1.TabIndex = 19;
            this.numericUpDown_SetPointFreq1.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label_SetPointFreq
            // 
            this.label_SetPointFreq.AutoSize = true;
            this.label_SetPointFreq.Location = new System.Drawing.Point(14, 32);
            this.label_SetPointFreq.Name = "label_SetPointFreq";
            this.label_SetPointFreq.Size = new System.Drawing.Size(134, 20);
            this.label_SetPointFreq.TabIndex = 18;
            this.label_SetPointFreq.Text = "Freq Setpoint, Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "D";
            // 
            // numericUpDown_DFreq1
            // 
            this.numericUpDown_DFreq1.DecimalPlaces = 2;
            this.numericUpDown_DFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DFreq1.Location = new System.Drawing.Point(39, 146);
            this.numericUpDown_DFreq1.Name = "numericUpDown_DFreq1";
            this.numericUpDown_DFreq1.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_DFreq1.TabIndex = 25;
            // 
            // numericUpDown_PFreq1
            // 
            this.numericUpDown_PFreq1.DecimalPlaces = 2;
            this.numericUpDown_PFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PFreq1.Location = new System.Drawing.Point(39, 88);
            this.numericUpDown_PFreq1.Name = "numericUpDown_PFreq1";
            this.numericUpDown_PFreq1.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_PFreq1.TabIndex = 23;
            // 
            // numericUpDown_IFreq1
            // 
            this.numericUpDown_IFreq1.DecimalPlaces = 2;
            this.numericUpDown_IFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IFreq1.Location = new System.Drawing.Point(39, 115);
            this.numericUpDown_IFreq1.Name = "numericUpDown_IFreq1";
            this.numericUpDown_IFreq1.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_IFreq1.TabIndex = 24;
            // 
            // button_EnableCh1
            // 
            this.button_EnableCh1.Location = new System.Drawing.Point(20, 449);
            this.button_EnableCh1.Name = "button_EnableCh1";
            this.button_EnableCh1.Size = new System.Drawing.Size(330, 45);
            this.button_EnableCh1.TabIndex = 26;
            this.button_EnableCh1.Text = "Enable";
            this.button_EnableCh1.UseVisualStyleBackColor = true;
            this.button_EnableCh1.Click += new System.EventHandler(this.button_EnableCh1_Click);
            // 
            // comboBox_Source1
            // 
            this.comboBox_Source1.DisplayMember = "(none)";
            this.comboBox_Source1.FormattingEnabled = true;
            this.comboBox_Source1.Items.AddRange(new object[] {
            "Temp1",
            "Temp2",
            "Temp3",
            "Temp4",
            "Freq"});
            this.comboBox_Source1.Location = new System.Drawing.Point(160, 128);
            this.comboBox_Source1.Name = "comboBox_Source1";
            this.comboBox_Source1.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Source1.TabIndex = 9;
            this.comboBox_Source1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Source1_SelectedIndexChanged);
            this.comboBox_Source1.EnabledChanged += new System.EventHandler(this.comboBox_Source1_EnabledChanged);
            // 
            // label_Source1
            // 
            this.label_Source1.AutoSize = true;
            this.label_Source1.Location = new System.Drawing.Point(12, 135);
            this.label_Source1.Name = "label_Source1";
            this.label_Source1.Size = new System.Drawing.Size(60, 20);
            this.label_Source1.TabIndex = 8;
            this.label_Source1.Text = "Source";
            // 
            // comboBox_Mode1
            // 
            this.comboBox_Mode1.FormattingEnabled = true;
            this.comboBox_Mode1.Items.AddRange(new object[] {
            "PID",
            "Const current"});
            this.comboBox_Mode1.Location = new System.Drawing.Point(160, 82);
            this.comboBox_Mode1.Name = "comboBox_Mode1";
            this.comboBox_Mode1.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Mode1.TabIndex = 7;
            this.comboBox_Mode1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode1_SelectedIndexChanged);
            // 
            // label_Mode1
            // 
            this.label_Mode1.AutoSize = true;
            this.label_Mode1.Location = new System.Drawing.Point(12, 85);
            this.label_Mode1.Name = "label_Mode1";
            this.label_Mode1.Size = new System.Drawing.Size(49, 20);
            this.label_Mode1.TabIndex = 6;
            this.label_Mode1.Text = "Mode";
            // 
            // comboBox_Load1
            // 
            this.comboBox_Load1.FormattingEnabled = true;
            this.comboBox_Load1.Items.AddRange(new object[] {
            "Resistor",
            "Peltier"});
            this.comboBox_Load1.Location = new System.Drawing.Point(160, 31);
            this.comboBox_Load1.Name = "comboBox_Load1";
            this.comboBox_Load1.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Load1.TabIndex = 1;
            // 
            // label_Load1
            // 
            this.label_Load1.AutoSize = true;
            this.label_Load1.Location = new System.Drawing.Point(12, 32);
            this.label_Load1.Name = "label_Load1";
            this.label_Load1.Size = new System.Drawing.Size(45, 20);
            this.label_Load1.TabIndex = 0;
            this.label_Load1.Text = "Load";
            // 
            // checkBox_U_HeaterEnable
            // 
            this.checkBox_U_HeaterEnable.AutoSize = true;
            this.checkBox_U_HeaterEnable.Location = new System.Drawing.Point(364, 118);
            this.checkBox_U_HeaterEnable.Name = "checkBox_U_HeaterEnable";
            this.checkBox_U_HeaterEnable.Size = new System.Drawing.Size(94, 24);
            this.checkBox_U_HeaterEnable.TabIndex = 2;
            this.checkBox_U_HeaterEnable.Text = "Enabled";
            this.checkBox_U_HeaterEnable.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1512, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 20);
            this.label25.TabIndex = 33;
            this.label25.Text = "Messages";
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1335);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.groupBox_PierceStat);
            this.Controls.Add(this.richTextBox_Messages);
            this.Controls.Add(this.button_ConnectCOM);
            this.Controls.Add(this.label_COM);
            this.Controls.Add(this.comboBox_ComPortsList);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_MainWindow";
            this.Text = "PierceStat";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_PierceStat.ResumeLayout(false);
            this.groupBox_PierceStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KprtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstopKprt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstartKprt)).EndInit();
            this.groupBox_ChannelsMode.ResumeLayout(false);
            this.groupBox_ChannelsMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterSet)).EndInit();
            this.groupBox_Meas.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Heater)).EndInit();
            this.groupBox_Channel2.ResumeLayout(false);
            this.groupBox_Channel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet2)).EndInit();
            this.groupBox_Temp2.ResumeLayout(false);
            this.groupBox_Temp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp2)).EndInit();
            this.groupBox_Freq2.ResumeLayout(false);
            this.groupBox_Freq2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq2)).EndInit();
            this.groupBox_Channel1.ResumeLayout(false);
            this.groupBox_Channel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet1)).EndInit();
            this.groupBox_Temp1.ResumeLayout(false);
            this.groupBox_Temp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp1)).EndInit();
            this.groupBox_Freq1.ResumeLayout(false);
            this.groupBox_Freq1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ComPortsList;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_ConnectCOM;
        private ToolStripMenuItem updateCOMPortsToolStripMenuItem;
        private RichTextBox richTextBox_Messages;
        private GroupBox groupBox_PierceStat;
        private CheckBox checkBox_U_HeaterEnable;
        private Label label_U_Heater;
        private Label label_U_Power;
        private NumericUpDown numericUpDown_U_PowerMeas;
        private NumericUpDown numericUpDown_U_HeaterMeas;
        private GroupBox groupBox_Channel1;
        private ComboBox comboBox_Source1;
        private Label label_Source1;
        private ComboBox comboBox_Mode1;
        private Label label_Mode1;
        private ComboBox comboBox_Load1;
        private Label label_Load1;
        private NumericUpDown numericUpDown_DTemp1;
        private NumericUpDown numericUpDown_ITemp1;
        private NumericUpDown numericUpDown_PTemp1;
        private Label label_DTemp1;
        private Label label_ITemp1;
        private Label label_PTemp1;
        private NumericUpDown numericUpDown_SetPointTemp1;
        private Label label_SetPointTemp;
        private Label label_SetPointFreq;
        private NumericUpDown numericUpDown_DFreq1;
        private NumericUpDown numericUpDown_IFreq1;
        private NumericUpDown numericUpDown_PFreq1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown_SetPointFreq1;
        private Label label_CurrentCh1;
        private NumericUpDown numericUpDown_CurrentCh1Meas;
        private Button button_EnableCh1;
        private GroupBox groupBox_Channel2;
        private GroupBox groupBox_Temp2;
        private NumericUpDown numericUpDown_SetPointTemp2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown_PTemp2;
        private NumericUpDown numericUpDown_DTemp2;
        private NumericUpDown numericUpDown_ITemp2;
        private GroupBox groupBox_Freq2;
        private NumericUpDown numericUpDown_SetPointFreq2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown_DFreq2;
        private NumericUpDown numericUpDown_PFreq2;
        private NumericUpDown numericUpDown_IFreq2;
        private Button button_EnableCh2;
        private ComboBox comboBox_Source2;
        private Label label13;
        private ComboBox comboBox_Mode2;
        private Label label14;
        private ComboBox comboBox_Load2;
        private Label label15;
        private GroupBox groupBox_Temp1;
        private GroupBox groupBox_Freq1;
        private Label label4;
        private GroupBox groupBox_Meas;
        private NumericUpDown numericUpDown_Temp1Meas;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private NumericUpDown numericUpDown_Temp4Meas;
        private NumericUpDown numericUpDown_Temp3Meas;
        private NumericUpDown numericUpDown_Temp2Meas;
        private NumericUpDown numericUpDown_U_HeaterSet;
        private Label label21;
        private NumericUpDown numericUpDown_CurrentCh2Meas;
        private Label label20;
        private NumericUpDown numericUpDown_CurrentCh2Max;
        private NumericUpDown numericUpDown_CurrentCh1Max;
        private Label label23;
        private Label label22;
        private NumericUpDown numericUpDown_U_PowerMax;
        private NumericUpDown numericUpDown_U_PowerMin;
        private NumericUpDown numericUpDown_U_HeaterMax;
        private NumericUpDown numericUpDown_U_HeaterMin;
        private PictureBox pictureBox_AlarmCurrentCh1;
        private NumericUpDown numericUpDown_Temp4Max;
        private NumericUpDown numericUpDown_Temp3Max;
        private NumericUpDown numericUpDown_Temp2Max;
        private NumericUpDown numericUpDown_Temp1Max;
        private NumericUpDown numericUpDown_Temp4Min;
        private NumericUpDown numericUpDown_Temp3Min;
        private NumericUpDown numericUpDown_Temp2Min;
        private NumericUpDown numericUpDown_Temp1Min;
        private PictureBox pictureBox_AlarmU_Heater;
        private PictureBox pictureBox_AlarmU_Power;
        private PictureBox pictureBox_AlarmCurrentCh2;
        private CheckBox checkBox_AlarmCurrentCh1Masked;
        private CheckBox checkBox_AlarmTemp4Masked;
        private CheckBox checkBox_AlarmTemp3Masked;
        private CheckBox checkBox_AlarmTemp2Masked;
        private CheckBox checkBox_AlarmTemp1Masked;
        private CheckBox checkBox_AlarmU_HeaterMasked;
        private CheckBox checkBox_AlarmU_PowerMasked;
        private CheckBox checkBox_AlarmCurrentCh2Masked;
        private Label label24;
        private PictureBox pictureBox_AlarmTemp4;
        private PictureBox pictureBox_AlarmTemp3;
        private PictureBox pictureBox_AlarmTemp2;
        private PictureBox pictureBox_AlarmTemp1;
        private Label label25;
        private NumericUpDown numericUpDown_FreqMax;
        private NumericUpDown numericUpDown_FreqMin;
        private NumericUpDown numericUpDown_FreqMeas;
        private Label label26;
        private CheckBox checkBox_AlarmFreqMasked;
        private PictureBox pictureBox_AlarmFreq;
        private Button button_SaveFlash;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label label28;
        private Label label27;
        private CheckBox checkBox_Polarity2;
        private CheckBox checkBox_Polarity1;
        private Label label30;
        private NumericUpDown numericUpDown_ISet2;
        private NumericUpDown numericUpDown_ISet1;
        private Label label29;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Freq;
        private Label label31;
        private CheckBox checkBox_PlotTempFreq;
        private CheckBox checkBox_PlotTemp4;
        private CheckBox checkBox_PlotTemp3;
        private CheckBox checkBox_PlotTemp2;
        private CheckBox checkBox_PlotTemp1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label32;
        private Button button_ResetPlots;
        private GroupBox groupBox_ChannelsMode;
        private RadioButton radioButton_ModeDependent;
        private RadioButton radioButton_ModeIndependent;
        private Label label33;
        private NumericUpDown numericUpDown_TstartKprt;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDown1;
        private Label label35;
        private NumericUpDown numericUpDown_TstopKprt;
        private Label label34;
        private NumericUpDown numericUpDown_KprtValue;
        private Label label36;
        private Button button_CalibrateKprt;
        private NumericUpDown numericUpDown_TimeInterval;
        private Label label37;
        private NumericUpDown numericUpDown_DerNumber;
        private Label label38;
        private Label label39;
        private NumericUpDown numericUpDown2;
    }

}



