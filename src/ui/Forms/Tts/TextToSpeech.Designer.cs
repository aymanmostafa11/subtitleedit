namespace Nikse.SubtitleEdit.Forms.Tts
{
    sealed partial class TextToSpeech
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonGenerateTTS = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelEngine = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.nikseComboBoxLanguage = new Nikse.SubtitleEdit.Controls.NikseComboBox();
            this.linkLabelCustomAudio = new System.Windows.Forms.LinkLabel();
            this.checkBoxAudioEncoding = new System.Windows.Forms.CheckBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.nikseComboBoxRegion = new Nikse.SubtitleEdit.Controls.NikseComboBox();
            this.labelVoiceCount = new System.Windows.Forms.Label();
            this.checkBoxShowPreview = new System.Windows.Forms.CheckBox();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.nikseTextBoxApiKey = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.TextBoxTest = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.buttonTestVoice = new System.Windows.Forms.Button();
            this.checkBoxAddToVideoFile = new System.Windows.Forms.CheckBox();
            this.labelVoice = new System.Windows.Forms.Label();
            this.nikseComboBoxVoice = new Nikse.SubtitleEdit.Controls.NikseComboBox();
            this.contextMenuStripVoices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshVoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nikseComboBoxEngine = new Nikse.SubtitleEdit.Controls.NikseComboBox();
            this.groupBoxElevenLabsOptions = new System.Windows.Forms.GroupBox();
            this.label_stability = new System.Windows.Forms.Label();
            this.label_similarity = new System.Windows.Forms.Label();
            this.label_style = new System.Windows.Forms.Label();
            this.char_count = new System.Windows.Forms.Label();
            this.label_char_count = new System.Windows.Forms.Label();
            this.checkBoxContext = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeakerBoost = new System.Windows.Forms.CheckBox();
            this.nikseTextBoxStability = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.nikseTextBoxStyle = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.nikseTextBoxSimilarity = new Nikse.SubtitleEdit.Controls.NikseTextBox();
            this.listViewActors = new System.Windows.Forms.ListView();
            this.columnHeaderActor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVoice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripActors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelActors = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.context_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSettings.SuspendLayout();
            this.contextMenuStripVoices.SuspendLayout();
            this.groupBoxElevenLabsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(960, 598);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 100;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelProgress.Location = new System.Drawing.Point(16, 570);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(92, 16);
            this.labelProgress.TabIndex = 9;
            this.labelProgress.Text = "labelProgress";
            // 
            // buttonGenerateTTS
            // 
            this.buttonGenerateTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateTTS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGenerateTTS.Location = new System.Drawing.Point(864, 558);
            this.buttonGenerateTTS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerateTTS.Name = "buttonGenerateTTS";
            this.buttonGenerateTTS.Size = new System.Drawing.Size(304, 28);
            this.buttonGenerateTTS.TabIndex = 90;
            this.buttonGenerateTTS.Text = "Generate speech from text";
            this.buttonGenerateTTS.UseVisualStyleBackColor = true;
            this.buttonGenerateTTS.Click += new System.EventHandler(this.ButtonGenerateTtsClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 598);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(932, 12);
            this.progressBar1.TabIndex = 12;
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEngine.Location = new System.Drawing.Point(19, 26);
            this.labelEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(49, 16);
            this.labelEngine.TabIndex = 14;
            this.labelEngine.Text = "Engine";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSettings.Controls.Add(this.labelLanguage);
            this.groupBoxSettings.Controls.Add(this.nikseComboBoxLanguage);
            this.groupBoxSettings.Controls.Add(this.linkLabelCustomAudio);
            this.groupBoxSettings.Controls.Add(this.checkBoxAudioEncoding);
            this.groupBoxSettings.Controls.Add(this.labelRegion);
            this.groupBoxSettings.Controls.Add(this.nikseComboBoxRegion);
            this.groupBoxSettings.Controls.Add(this.labelVoiceCount);
            this.groupBoxSettings.Controls.Add(this.checkBoxShowPreview);
            this.groupBoxSettings.Controls.Add(this.labelApiKey);
            this.groupBoxSettings.Controls.Add(this.nikseTextBoxApiKey);
            this.groupBoxSettings.Controls.Add(this.TextBoxTest);
            this.groupBoxSettings.Controls.Add(this.buttonTestVoice);
            this.groupBoxSettings.Controls.Add(this.checkBoxAddToVideoFile);
            this.groupBoxSettings.Controls.Add(this.labelVoice);
            this.groupBoxSettings.Controls.Add(this.nikseComboBoxVoice);
            this.groupBoxSettings.Controls.Add(this.labelEngine);
            this.groupBoxSettings.Controls.Add(this.nikseComboBoxEngine);
            this.groupBoxSettings.Controls.Add(this.groupBoxElevenLabsOptions);
            this.groupBoxSettings.Location = new System.Drawing.Point(20, 15);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Size = new System.Drawing.Size(521, 535);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLanguage.Location = new System.Drawing.Point(19, 337);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(68, 16);
            this.labelLanguage.TabIndex = 36;
            this.labelLanguage.Text = "Language";
            // 
            // nikseComboBoxLanguage
            // 
            this.nikseComboBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseComboBoxLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.nikseComboBoxLanguage.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nikseComboBoxLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.nikseComboBoxLanguage.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nikseComboBoxLanguage.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.nikseComboBoxLanguage.ButtonForeColorDown = System.Drawing.Color.Orange;
            this.nikseComboBoxLanguage.ButtonForeColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseComboBoxLanguage.DropDownHeight = 400;
            this.nikseComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nikseComboBoxLanguage.DropDownWidth = 0;
            this.nikseComboBoxLanguage.FormattingEnabled = false;
            this.nikseComboBoxLanguage.Location = new System.Drawing.Point(136, 331);
            this.nikseComboBoxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.nikseComboBoxLanguage.MaxLength = 32767;
            this.nikseComboBoxLanguage.Name = "nikseComboBoxLanguage";
            this.nikseComboBoxLanguage.SelectedIndex = -1;
            this.nikseComboBoxLanguage.SelectedItem = null;
            this.nikseComboBoxLanguage.SelectedText = "";
            this.nikseComboBoxLanguage.Size = new System.Drawing.Size(355, 28);
            this.nikseComboBoxLanguage.TabIndex = 35;
            this.nikseComboBoxLanguage.UsePopupWindow = false;
            // 
            // linkLabelCustomAudio
            // 
            this.linkLabelCustomAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelCustomAudio.AutoSize = true;
            this.linkLabelCustomAudio.Location = new System.Drawing.Point(225, 492);
            this.linkLabelCustomAudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelCustomAudio.Name = "linkLabelCustomAudio";
            this.linkLabelCustomAudio.Size = new System.Drawing.Size(55, 16);
            this.linkLabelCustomAudio.TabIndex = 34;
            this.linkLabelCustomAudio.TabStop = true;
            this.linkLabelCustomAudio.Text = "Settings";
            this.linkLabelCustomAudio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCustomAudio_LinkClicked);
            // 
            // checkBoxAudioEncoding
            // 
            this.checkBoxAudioEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAudioEncoding.AutoSize = true;
            this.checkBoxAudioEncoding.Location = new System.Drawing.Point(43, 495);
            this.checkBoxAudioEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAudioEncoding.Name = "checkBoxAudioEncoding";
            this.checkBoxAudioEncoding.Size = new System.Drawing.Size(170, 20);
            this.checkBoxAudioEncoding.TabIndex = 33;
            this.checkBoxAudioEncoding.Text = "Custom audio encoding";
            this.checkBoxAudioEncoding.UseVisualStyleBackColor = true;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRegion.Location = new System.Drawing.Point(19, 264);
            this.labelRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(51, 16);
            this.labelRegion.TabIndex = 32;
            this.labelRegion.Text = "Region";
            // 
            // nikseComboBoxRegion
            // 
            this.nikseComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseComboBoxRegion.BackColor = System.Drawing.SystemColors.Window;
            this.nikseComboBoxRegion.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nikseComboBoxRegion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.nikseComboBoxRegion.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nikseComboBoxRegion.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.nikseComboBoxRegion.ButtonForeColorDown = System.Drawing.Color.Orange;
            this.nikseComboBoxRegion.ButtonForeColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseComboBoxRegion.DropDownHeight = 400;
            this.nikseComboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nikseComboBoxRegion.DropDownWidth = 0;
            this.nikseComboBoxRegion.FormattingEnabled = false;
            this.nikseComboBoxRegion.Location = new System.Drawing.Point(136, 257);
            this.nikseComboBoxRegion.Margin = new System.Windows.Forms.Padding(4);
            this.nikseComboBoxRegion.MaxLength = 32767;
            this.nikseComboBoxRegion.Name = "nikseComboBoxRegion";
            this.nikseComboBoxRegion.SelectedIndex = -1;
            this.nikseComboBoxRegion.SelectedItem = null;
            this.nikseComboBoxRegion.SelectedText = "";
            this.nikseComboBoxRegion.Size = new System.Drawing.Size(355, 28);
            this.nikseComboBoxRegion.TabIndex = 31;
            this.nikseComboBoxRegion.UsePopupWindow = false;
            this.nikseComboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.nikseComboBoxRegion_SelectedIndexChanged);
            // 
            // labelVoiceCount
            // 
            this.labelVoiceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVoiceCount.Location = new System.Drawing.Point(357, 78);
            this.labelVoiceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoiceCount.Name = "labelVoiceCount";
            this.labelVoiceCount.Size = new System.Drawing.Size(133, 28);
            this.labelVoiceCount.TabIndex = 29;
            this.labelVoiceCount.Text = "255";
            this.labelVoiceCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // checkBoxShowPreview
            // 
            this.checkBoxShowPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowPreview.AutoSize = true;
            this.checkBoxShowPreview.Checked = true;
            this.checkBoxShowPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowPreview.Location = new System.Drawing.Point(23, 435);
            this.checkBoxShowPreview.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowPreview.Name = "checkBoxShowPreview";
            this.checkBoxShowPreview.Size = new System.Drawing.Size(142, 20);
            this.checkBoxShowPreview.TabIndex = 25;
            this.checkBoxShowPreview.Text = "Review audio clips";
            this.checkBoxShowPreview.UseVisualStyleBackColor = true;
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelApiKey.Location = new System.Drawing.Point(19, 229);
            this.labelApiKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(53, 16);
            this.labelApiKey.TabIndex = 28;
            this.labelApiKey.Text = "API key";
            // 
            // nikseTextBoxApiKey
            // 
            this.nikseTextBoxApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseTextBoxApiKey.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseTextBoxApiKey.Location = new System.Drawing.Point(136, 225);
            this.nikseTextBoxApiKey.Margin = new System.Windows.Forms.Padding(4);
            this.nikseTextBoxApiKey.Name = "nikseTextBoxApiKey";
            this.nikseTextBoxApiKey.Size = new System.Drawing.Size(353, 22);
            this.nikseTextBoxApiKey.TabIndex = 27;
            // 
            // TextBoxTest
            // 
            this.TextBoxTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTest.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.TextBoxTest.Location = new System.Drawing.Point(23, 188);
            this.TextBoxTest.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTest.Name = "TextBoxTest";
            this.TextBoxTest.Size = new System.Drawing.Size(467, 22);
            this.TextBoxTest.TabIndex = 20;
            this.TextBoxTest.Text = "Hello, how are you?";
            this.TextBoxTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTest_KeyDown);
            // 
            // buttonTestVoice
            // 
            this.buttonTestVoice.Location = new System.Drawing.Point(23, 150);
            this.buttonTestVoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTestVoice.Name = "buttonTestVoice";
            this.buttonTestVoice.Size = new System.Drawing.Size(200, 28);
            this.buttonTestVoice.TabIndex = 15;
            this.buttonTestVoice.Text = "Test voice";
            this.buttonTestVoice.UseVisualStyleBackColor = true;
            this.buttonTestVoice.Click += new System.EventHandler(this.buttonTestVoice_Click);
            // 
            // checkBoxAddToVideoFile
            // 
            this.checkBoxAddToVideoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAddToVideoFile.AutoSize = true;
            this.checkBoxAddToVideoFile.Checked = true;
            this.checkBoxAddToVideoFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddToVideoFile.Location = new System.Drawing.Point(23, 464);
            this.checkBoxAddToVideoFile.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAddToVideoFile.Name = "checkBoxAddToVideoFile";
            this.checkBoxAddToVideoFile.Size = new System.Drawing.Size(217, 20);
            this.checkBoxAddToVideoFile.TabIndex = 26;
            this.checkBoxAddToVideoFile.Text = "Add audio to video file (new file)";
            this.checkBoxAddToVideoFile.UseVisualStyleBackColor = true;
            // 
            // labelVoice
            // 
            this.labelVoice.AutoSize = true;
            this.labelVoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVoice.Location = new System.Drawing.Point(19, 90);
            this.labelVoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoice.Name = "labelVoice";
            this.labelVoice.Size = new System.Drawing.Size(42, 16);
            this.labelVoice.TabIndex = 16;
            this.labelVoice.Text = "Voice";
            // 
            // nikseComboBoxVoice
            // 
            this.nikseComboBoxVoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseComboBoxVoice.BackColor = System.Drawing.SystemColors.Window;
            this.nikseComboBoxVoice.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nikseComboBoxVoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.nikseComboBoxVoice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nikseComboBoxVoice.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.nikseComboBoxVoice.ButtonForeColorDown = System.Drawing.Color.Orange;
            this.nikseComboBoxVoice.ButtonForeColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseComboBoxVoice.ContextMenuStrip = this.contextMenuStripVoices;
            this.nikseComboBoxVoice.DropDownHeight = 400;
            this.nikseComboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nikseComboBoxVoice.DropDownWidth = 0;
            this.nikseComboBoxVoice.FormattingEnabled = false;
            this.nikseComboBoxVoice.Location = new System.Drawing.Point(23, 111);
            this.nikseComboBoxVoice.Margin = new System.Windows.Forms.Padding(4);
            this.nikseComboBoxVoice.MaxLength = 32767;
            this.nikseComboBoxVoice.Name = "nikseComboBoxVoice";
            this.nikseComboBoxVoice.SelectedIndex = -1;
            this.nikseComboBoxVoice.SelectedItem = null;
            this.nikseComboBoxVoice.SelectedText = "";
            this.nikseComboBoxVoice.Size = new System.Drawing.Size(468, 28);
            this.nikseComboBoxVoice.TabIndex = 10;
            this.nikseComboBoxVoice.UsePopupWindow = false;
            // 
            // contextMenuStripVoices
            // 
            this.contextMenuStripVoices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripVoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshVoicesToolStripMenuItem});
            this.contextMenuStripVoices.Name = "contextMenuStripVoices";
            this.contextMenuStripVoices.Size = new System.Drawing.Size(173, 28);
            this.contextMenuStripVoices.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripVoices_Opening);
            // 
            // refreshVoicesToolStripMenuItem
            // 
            this.refreshVoicesToolStripMenuItem.Name = "refreshVoicesToolStripMenuItem";
            this.refreshVoicesToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.refreshVoicesToolStripMenuItem.Text = "Refresh voices";
            this.refreshVoicesToolStripMenuItem.Click += new System.EventHandler(this.refreshVoicesToolStripMenuItem_Click);
            // 
            // nikseComboBoxEngine
            // 
            this.nikseComboBoxEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nikseComboBoxEngine.BackColor = System.Drawing.SystemColors.Window;
            this.nikseComboBoxEngine.BackColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nikseComboBoxEngine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.nikseComboBoxEngine.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nikseComboBoxEngine.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.nikseComboBoxEngine.ButtonForeColorDown = System.Drawing.Color.Orange;
            this.nikseComboBoxEngine.ButtonForeColorOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseComboBoxEngine.DropDownHeight = 400;
            this.nikseComboBoxEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.nikseComboBoxEngine.DropDownWidth = 391;
            this.nikseComboBoxEngine.FormattingEnabled = false;
            this.nikseComboBoxEngine.Location = new System.Drawing.Point(23, 49);
            this.nikseComboBoxEngine.Margin = new System.Windows.Forms.Padding(4);
            this.nikseComboBoxEngine.MaxLength = 32767;
            this.nikseComboBoxEngine.Name = "nikseComboBoxEngine";
            this.nikseComboBoxEngine.SelectedIndex = -1;
            this.nikseComboBoxEngine.SelectedItem = null;
            this.nikseComboBoxEngine.SelectedText = "";
            this.nikseComboBoxEngine.Size = new System.Drawing.Size(468, 28);
            this.nikseComboBoxEngine.TabIndex = 5;
            this.nikseComboBoxEngine.TabStop = false;
            this.nikseComboBoxEngine.Text = "nikseComboBox1";
            this.nikseComboBoxEngine.UsePopupWindow = false;
            // 
            // groupBoxElevenLabsOptions
            // 
            this.groupBoxElevenLabsOptions.AutoSize = true;
            this.groupBoxElevenLabsOptions.Controls.Add(this.label_stability);
            this.groupBoxElevenLabsOptions.Controls.Add(this.label_similarity);
            this.groupBoxElevenLabsOptions.Controls.Add(this.label_style);
            this.groupBoxElevenLabsOptions.Controls.Add(this.char_count);
            this.groupBoxElevenLabsOptions.Controls.Add(this.label_char_count);
            this.groupBoxElevenLabsOptions.Controls.Add(this.checkBoxContext);
            this.groupBoxElevenLabsOptions.Controls.Add(this.checkBoxSpeakerBoost);
            this.groupBoxElevenLabsOptions.Controls.Add(this.nikseTextBoxStability);
            this.groupBoxElevenLabsOptions.Controls.Add(this.nikseTextBoxStyle);
            this.groupBoxElevenLabsOptions.Controls.Add(this.nikseTextBoxSimilarity);
            this.groupBoxElevenLabsOptions.Location = new System.Drawing.Point(23, 287);
            this.groupBoxElevenLabsOptions.Name = "groupBoxElevenLabsOptions";
            this.groupBoxElevenLabsOptions.Size = new System.Drawing.Size(468, 148);
            this.groupBoxElevenLabsOptions.TabIndex = 37;
            this.groupBoxElevenLabsOptions.TabStop = false;
            this.groupBoxElevenLabsOptions.Text = "Extra Options";
            // 
            // label_stability
            // 
            this.label_stability.AutoSize = true;
            this.label_stability.Location = new System.Drawing.Point(370, 21);
            this.label_stability.Name = "label_stability";
            this.label_stability.Size = new System.Drawing.Size(54, 16);
            this.label_stability.TabIndex = 11;
            this.label_stability.Text = "Stability";
            this.label_stability.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_similarity
            // 
            this.label_similarity.AutoSize = true;
            this.label_similarity.Location = new System.Drawing.Point(203, 18);
            this.label_similarity.Name = "label_similarity";
            this.label_similarity.Size = new System.Drawing.Size(61, 16);
            this.label_similarity.TabIndex = 10;
            this.label_similarity.Text = "Similarity";
            this.label_similarity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_style
            // 
            this.label_style.AutoSize = true;
            this.label_style.Location = new System.Drawing.Point(28, 21);
            this.label_style.Name = "label_style";
            this.label_style.Size = new System.Drawing.Size(37, 16);
            this.label_style.TabIndex = 9;
            this.label_style.Text = "Style";
            this.label_style.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // char_count
            // 
            this.char_count.AutoSize = true;
            this.char_count.Location = new System.Drawing.Point(391, 114);
            this.char_count.Name = "char_count";
            this.char_count.Size = new System.Drawing.Size(14, 16);
            this.char_count.TabIndex = 8;
            this.char_count.Text = "0";
            // 
            // label_char_count
            // 
            this.label_char_count.AutoSize = true;
            this.label_char_count.Location = new System.Drawing.Point(334, 79);
            this.label_char_count.Name = "label_char_count";
            this.label_char_count.Size = new System.Drawing.Size(128, 32);
            this.label_char_count.TabIndex = 7;
            this.label_char_count.Text = "Expected Character \r\nCount";
            this.label_char_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxContext
            // 
            this.checkBoxContext.AutoSize = true;
            this.checkBoxContext.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxContext.Location = new System.Drawing.Point(191, 90);
            this.checkBoxContext.Name = "checkBoxContext";
            this.checkBoxContext.Size = new System.Drawing.Size(83, 37);
            this.checkBoxContext.TabIndex = 6;
            this.checkBoxContext.Text = "Add Context";
            this.checkBoxContext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.context_tooltip.SetToolTip(this.checkBoxContext, "Sends previous and next subtitles in the TTS request for better context awareness" +
        "");
            this.checkBoxContext.UseVisualStyleBackColor = true;
            this.checkBoxContext.CheckedChanged += new System.EventHandler(this.checkBoxContext_CheckedChanged);
            // 
            // checkBoxSpeakerBoost
            // 
            this.checkBoxSpeakerBoost.AutoSize = true;
            this.checkBoxSpeakerBoost.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxSpeakerBoost.Location = new System.Drawing.Point(6, 90);
            this.checkBoxSpeakerBoost.Name = "checkBoxSpeakerBoost";
            this.checkBoxSpeakerBoost.Size = new System.Drawing.Size(101, 37);
            this.checkBoxSpeakerBoost.TabIndex = 5;
            this.checkBoxSpeakerBoost.Text = "Speaker Boost";
            this.checkBoxSpeakerBoost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxSpeakerBoost.UseVisualStyleBackColor = true;
            // 
            // nikseTextBoxStability
            // 
            this.nikseTextBoxStability.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseTextBoxStability.Location = new System.Drawing.Point(358, 42);
            this.nikseTextBoxStability.Name = "nikseTextBoxStability";
            this.nikseTextBoxStability.Size = new System.Drawing.Size(80, 22);
            this.nikseTextBoxStability.TabIndex = 4;
            this.nikseTextBoxStability.Text = "(0,1)";
            this.nikseTextBoxStability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nikseTextBoxStyle
            // 
            this.nikseTextBoxStyle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseTextBoxStyle.Location = new System.Drawing.Point(6, 42);
            this.nikseTextBoxStyle.Name = "nikseTextBoxStyle";
            this.nikseTextBoxStyle.Size = new System.Drawing.Size(80, 22);
            this.nikseTextBoxStyle.TabIndex = 2;
            this.nikseTextBoxStyle.Text = "(0,1)";
            this.nikseTextBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nikseTextBoxSimilarity
            // 
            this.nikseTextBoxSimilarity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nikseTextBoxSimilarity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.nikseTextBoxSimilarity.Location = new System.Drawing.Point(194, 42);
            this.nikseTextBoxSimilarity.Name = "nikseTextBoxSimilarity";
            this.nikseTextBoxSimilarity.Size = new System.Drawing.Size(80, 22);
            this.nikseTextBoxSimilarity.TabIndex = 3;
            this.nikseTextBoxSimilarity.Text = "(0,1)";
            this.nikseTextBoxSimilarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewActors
            // 
            this.listViewActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderActor,
            this.columnHeaderVoice});
            this.listViewActors.ContextMenuStrip = this.contextMenuStripActors;
            this.listViewActors.FullRowSelect = true;
            this.listViewActors.GridLines = true;
            this.listViewActors.HideSelection = false;
            this.listViewActors.Location = new System.Drawing.Point(549, 52);
            this.listViewActors.Margin = new System.Windows.Forms.Padding(4);
            this.listViewActors.Name = "listViewActors";
            this.listViewActors.Size = new System.Drawing.Size(617, 498);
            this.listViewActors.TabIndex = 40;
            this.listViewActors.UseCompatibleStateImageBehavior = false;
            this.listViewActors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderActor
            // 
            this.columnHeaderActor.Text = "Actor";
            this.columnHeaderActor.Width = 200;
            // 
            // columnHeaderVoice
            // 
            this.columnHeaderVoice.Text = "Voice";
            this.columnHeaderVoice.Width = 200;
            // 
            // contextMenuStripActors
            // 
            this.contextMenuStripActors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripActors.Name = "contextMenuStripActors";
            this.contextMenuStripActors.Size = new System.Drawing.Size(61, 4);
            // 
            // labelActors
            // 
            this.labelActors.AutoSize = true;
            this.labelActors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelActors.Location = new System.Drawing.Point(549, 23);
            this.labelActors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActors.Name = "labelActors";
            this.labelActors.Size = new System.Drawing.Size(209, 16);
            this.labelActors.TabIndex = 19;
            this.labelActors.Text = "Right-click to assign actor to voice";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(1068, 598);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 101;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TextToSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelActors);
            this.Controls.Add(this.listViewActors);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonGenerateTTS);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonOK);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1141, 629);
            this.Name = "TextToSpeech";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text to speech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextToSpeech_FormClosing);
            this.Load += new System.EventHandler(this.TextToSpeech_Load);
            this.Shown += new System.EventHandler(this.TextToSpeech_Shown);
            this.ResizeEnd += new System.EventHandler(this.TextToSpeech_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.TextToSpeech_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextToSpeech_KeyDown);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.contextMenuStripVoices.ResumeLayout(false);
            this.groupBoxElevenLabsOptions.ResumeLayout(false);
            this.groupBoxElevenLabsOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonGenerateTTS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Controls.NikseComboBox nikseComboBoxEngine;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelVoice;
        private Controls.NikseComboBox nikseComboBoxVoice;
        private System.Windows.Forms.CheckBox checkBoxAddToVideoFile;
        private System.Windows.Forms.ListView listViewActors;
        private System.Windows.Forms.ColumnHeader columnHeaderActor;
        private System.Windows.Forms.ColumnHeader columnHeaderVoice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActors;
        private System.Windows.Forms.Button buttonTestVoice;
        private Controls.NikseTextBox TextBoxTest;
        private System.Windows.Forms.Label labelActors;
        private System.Windows.Forms.Label labelApiKey;
        private Controls.NikseTextBox nikseTextBoxApiKey;
        private System.Windows.Forms.CheckBox checkBoxShowPreview;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelVoiceCount;
        private System.Windows.Forms.Label labelRegion;
        private Controls.NikseComboBox nikseComboBoxRegion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripVoices;
        private System.Windows.Forms.ToolStripMenuItem refreshVoicesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAudioEncoding;
        private System.Windows.Forms.LinkLabel linkLabelCustomAudio;
        private System.Windows.Forms.Label labelLanguage;
        private Controls.NikseComboBox nikseComboBoxLanguage;
        private System.Windows.Forms.GroupBox groupBoxElevenLabsOptions;
        private Controls.NikseTextBox nikseTextBoxStyle;
        private Controls.NikseTextBox nikseTextBoxSimilarity;
        private System.Windows.Forms.CheckBox checkBoxContext;
        private System.Windows.Forms.CheckBox checkBoxSpeakerBoost;
        private Controls.NikseTextBox nikseTextBoxStability;
        private System.Windows.Forms.Label label_similarity;
        private System.Windows.Forms.Label label_style;
        private System.Windows.Forms.Label char_count;
        private System.Windows.Forms.Label label_char_count;
        private System.Windows.Forms.Label label_stability;
        private System.Windows.Forms.ToolTip context_tooltip;
    }
}