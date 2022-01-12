
namespace Mystic_Audio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.TitleBarPnl = new System.Windows.Forms.Panel();
            this.Searchtxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.PlaylistBtn = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.VolumeBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.ShuffleBtn = new System.Windows.Forms.Button();
            this.RepeatBtn = new System.Windows.Forms.Button();
            this.SkipPreviousBtn = new System.Windows.Forms.Button();
            this.SwitchBtn = new System.Windows.Forms.Button();
            this.SkipNextBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.TrackBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.MusicBox = new System.Windows.Forms.ListBox();
            this.Artistlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Genrelbl = new System.Windows.Forms.Label();
            this.Yearlbl = new System.Windows.Forms.Label();
            this.Durationlbl = new System.Windows.Forms.Label();
            this.PlayListtmr = new System.Windows.Forms.Timer(this.components);
            this.TrackBarTimer = new System.Windows.Forms.Timer(this.components);
            this.RepeatOnetmr = new System.Windows.Forms.Timer(this.components);
            this.Visualstmr = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBarPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPnl
            // 
            this.TitleBarPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TitleBarPnl.Controls.Add(this.Searchtxt);
            this.TitleBarPnl.Controls.Add(this.MinBtn);
            this.TitleBarPnl.Controls.Add(this.MaxBtn);
            this.TitleBarPnl.Controls.Add(this.ExitBtn);
            this.TitleBarPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPnl.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPnl.Name = "TitleBarPnl";
            this.TitleBarPnl.Size = new System.Drawing.Size(1100, 50);
            this.TitleBarPnl.TabIndex = 0;
            this.TitleBarPnl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TitleBarPnl_MouseDoubleClick);
            this.TitleBarPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPnl_MouseDown);
            // 
            // Searchtxt
            // 
            this.Searchtxt.AcceptsReturn = false;
            this.Searchtxt.AcceptsTab = false;
            this.Searchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchtxt.AnimationSpeed = 200;
            this.Searchtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Searchtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Searchtxt.BackColor = System.Drawing.Color.Transparent;
            this.Searchtxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchtxt.BackgroundImage")));
            this.Searchtxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Searchtxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Searchtxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Searchtxt.BorderColorIdle = System.Drawing.Color.Transparent;
            this.Searchtxt.BorderRadius = 20;
            this.Searchtxt.BorderThickness = 1;
            this.Searchtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.DefaultText = "";
            this.Searchtxt.FillColor = System.Drawing.Color.White;
            this.Searchtxt.HideSelection = true;
            this.Searchtxt.IconLeft = global::Mystic_Audio.Properties.Resources.search;
            this.Searchtxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.IconPadding = 10;
            this.Searchtxt.IconRight = null;
            this.Searchtxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.Lines = new string[0];
            this.Searchtxt.Location = new System.Drawing.Point(696, 3);
            this.Searchtxt.MaxLength = 32767;
            this.Searchtxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.Searchtxt.Modified = false;
            this.Searchtxt.Multiline = false;
            this.Searchtxt.Name = "Searchtxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Searchtxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnIdleState = stateProperties4;
            this.Searchtxt.Padding = new System.Windows.Forms.Padding(3);
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Searchtxt.PlaceholderText = "Search Music";
            this.Searchtxt.ReadOnly = false;
            this.Searchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.SelectionLength = 0;
            this.Searchtxt.SelectionStart = 0;
            this.Searchtxt.ShortcutsEnabled = true;
            this.Searchtxt.Size = new System.Drawing.Size(323, 42);
            this.Searchtxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Searchtxt.TabIndex = 3;
            this.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Searchtxt.TextMarginBottom = 0;
            this.Searchtxt.TextMarginLeft = 3;
            this.Searchtxt.TextMarginTop = 0;
            this.Searchtxt.TextPlaceholder = "Search Music";
            this.Searchtxt.UseSystemPasswordChar = false;
            this.Searchtxt.WordWrap = true;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.minimize;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Location = new System.Drawing.Point(1025, 3);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(20, 20);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.max;
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Location = new System.Drawing.Point(1051, 3);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(20, 20);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.close;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1077, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.ImportBtn);
            this.panel1.Controls.Add(this.PlaylistBtn);
            this.panel1.Controls.Add(this.HistoryBtn);
            this.panel1.Controls.Add(this.OpenBtn);
            this.panel1.Controls.Add(this.VolumeBar);
            this.panel1.Controls.Add(this.ShuffleBtn);
            this.panel1.Controls.Add(this.RepeatBtn);
            this.panel1.Controls.Add(this.SkipPreviousBtn);
            this.panel1.Controls.Add(this.SwitchBtn);
            this.panel1.Controls.Add(this.SkipNextBtn);
            this.panel1.Controls.Add(this.StopBtn);
            this.panel1.Controls.Add(this.PauseBtn);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.TrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImportBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.import;
            this.ImportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImportBtn.FlatAppearance.BorderSize = 0;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportBtn.Location = new System.Drawing.Point(107, 55);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(20, 20);
            this.ImportBtn.TabIndex = 15;
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // PlaylistBtn
            // 
            this.PlaylistBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlaylistBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.playlist;
            this.PlaylistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaylistBtn.FlatAppearance.BorderSize = 0;
            this.PlaylistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistBtn.Location = new System.Drawing.Point(81, 55);
            this.PlaylistBtn.Name = "PlaylistBtn";
            this.PlaylistBtn.Size = new System.Drawing.Size(20, 20);
            this.PlaylistBtn.TabIndex = 14;
            this.PlaylistBtn.UseVisualStyleBackColor = true;
            this.PlaylistBtn.Click += new System.EventHandler(this.PlaylistBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HistoryBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.history;
            this.HistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HistoryBtn.FlatAppearance.BorderSize = 0;
            this.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryBtn.Location = new System.Drawing.Point(55, 55);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(20, 20);
            this.HistoryBtn.TabIndex = 13;
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.add;
            this.OpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Location = new System.Drawing.Point(3, 55);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(20, 20);
            this.OpenBtn.TabIndex = 11;
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.AllowCursorChanges = true;
            this.VolumeBar.AllowHomeEndKeysDetection = false;
            this.VolumeBar.AllowIncrementalClickMoves = true;
            this.VolumeBar.AllowMouseDownEffects = false;
            this.VolumeBar.AllowMouseHoverEffects = false;
            this.VolumeBar.AllowScrollingAnimations = true;
            this.VolumeBar.AllowScrollKeysDetection = true;
            this.VolumeBar.AllowScrollOptionsMenu = true;
            this.VolumeBar.AllowShrinkingOnFocusLost = false;
            this.VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeBar.BackgroundImage")));
            this.VolumeBar.BindingContainer = null;
            this.VolumeBar.BorderRadius = 2;
            this.VolumeBar.BorderThickness = 1;
            this.VolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBar.DrawThickBorder = false;
            this.VolumeBar.DurationBeforeShrink = 2000;
            this.VolumeBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.VolumeBar.LargeChange = 10;
            this.VolumeBar.Location = new System.Drawing.Point(632, 44);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Minimum = 0;
            this.VolumeBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.VolumeBar.MinimumThumbLength = 18;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.VolumeBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.VolumeBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.VolumeBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeBar.ShrinkSizeLimit = 3;
            this.VolumeBar.Size = new System.Drawing.Size(456, 31);
            this.VolumeBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.VolumeBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.VolumeBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.VolumeBar.SmallChange = 1;
            this.VolumeBar.TabIndex = 10;
            this.VolumeBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.VolumeBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.VolumeBar.ThumbLength = 45;
            this.VolumeBar.ThumbMargin = 1;
            this.VolumeBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.VolumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.VolumeBar.Value = 50;
            this.VolumeBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.VolumeBar_Scroll);
            // 
            // ShuffleBtn
            // 
            this.ShuffleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShuffleBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.shuffle;
            this.ShuffleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShuffleBtn.FlatAppearance.BorderSize = 0;
            this.ShuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleBtn.Location = new System.Drawing.Point(450, 55);
            this.ShuffleBtn.Name = "ShuffleBtn";
            this.ShuffleBtn.Size = new System.Drawing.Size(20, 20);
            this.ShuffleBtn.TabIndex = 9;
            this.ShuffleBtn.UseVisualStyleBackColor = true;
            this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
            // 
            // RepeatBtn
            // 
            this.RepeatBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RepeatBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.repeat;
            this.RepeatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RepeatBtn.FlatAppearance.BorderSize = 0;
            this.RepeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatBtn.Location = new System.Drawing.Point(606, 55);
            this.RepeatBtn.Name = "RepeatBtn";
            this.RepeatBtn.Size = new System.Drawing.Size(20, 20);
            this.RepeatBtn.TabIndex = 8;
            this.RepeatBtn.UseVisualStyleBackColor = true;
            this.RepeatBtn.Click += new System.EventHandler(this.RepeatBtn_Click);
            // 
            // SkipPreviousBtn
            // 
            this.SkipPreviousBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SkipPreviousBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.skipprevious;
            this.SkipPreviousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SkipPreviousBtn.FlatAppearance.BorderSize = 0;
            this.SkipPreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipPreviousBtn.Location = new System.Drawing.Point(476, 55);
            this.SkipPreviousBtn.Name = "SkipPreviousBtn";
            this.SkipPreviousBtn.Size = new System.Drawing.Size(20, 20);
            this.SkipPreviousBtn.TabIndex = 7;
            this.SkipPreviousBtn.UseVisualStyleBackColor = true;
            this.SkipPreviousBtn.Click += new System.EventHandler(this.SkipPreviousBtn_Click);
            // 
            // SwitchBtn
            // 
            this.SwitchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SwitchBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.switch2;
            this.SwitchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SwitchBtn.FlatAppearance.BorderSize = 0;
            this.SwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchBtn.Location = new System.Drawing.Point(29, 55);
            this.SwitchBtn.Name = "SwitchBtn";
            this.SwitchBtn.Size = new System.Drawing.Size(20, 20);
            this.SwitchBtn.TabIndex = 12;
            this.SwitchBtn.UseVisualStyleBackColor = true;
            this.SwitchBtn.Click += new System.EventHandler(this.SwitchBtn_Click);
            // 
            // SkipNextBtn
            // 
            this.SkipNextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SkipNextBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.skipnext;
            this.SkipNextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SkipNextBtn.FlatAppearance.BorderSize = 0;
            this.SkipNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipNextBtn.Location = new System.Drawing.Point(580, 55);
            this.SkipNextBtn.Name = "SkipNextBtn";
            this.SkipNextBtn.Size = new System.Drawing.Size(20, 20);
            this.SkipNextBtn.TabIndex = 6;
            this.SkipNextBtn.UseVisualStyleBackColor = true;
            this.SkipNextBtn.Click += new System.EventHandler(this.SkipNextBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StopBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.stop;
            this.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Location = new System.Drawing.Point(554, 55);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(20, 20);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PauseBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.pause;
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PauseBtn.FlatAppearance.BorderSize = 0;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Location = new System.Drawing.Point(528, 55);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(20, 20);
            this.PauseBtn.TabIndex = 4;
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlayBtn.BackgroundImage = global::Mystic_Audio.Properties.Resources.play;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(502, 55);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(20, 20);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.AllowCursorChanges = true;
            this.TrackBar.AllowHomeEndKeysDetection = false;
            this.TrackBar.AllowIncrementalClickMoves = true;
            this.TrackBar.AllowMouseDownEffects = false;
            this.TrackBar.AllowMouseHoverEffects = false;
            this.TrackBar.AllowScrollingAnimations = true;
            this.TrackBar.AllowScrollKeysDetection = true;
            this.TrackBar.AllowScrollOptionsMenu = true;
            this.TrackBar.AllowShrinkingOnFocusLost = false;
            this.TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrackBar.BackgroundImage")));
            this.TrackBar.BindingContainer = null;
            this.TrackBar.BorderRadius = 2;
            this.TrackBar.BorderThickness = 1;
            this.TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBar.DrawThickBorder = false;
            this.TrackBar.DurationBeforeShrink = 2000;
            this.TrackBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.TrackBar.LargeChange = 0;
            this.TrackBar.Location = new System.Drawing.Point(3, 3);
            this.TrackBar.Maximum = 10;
            this.TrackBar.Minimum = 0;
            this.TrackBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.TrackBar.MinimumThumbLength = 18;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.TrackBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.TrackBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.TrackBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.TrackBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.TrackBar.ShrinkSizeLimit = 3;
            this.TrackBar.Size = new System.Drawing.Size(1094, 31);
            this.TrackBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.TrackBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.TrackBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.TrackBar.SmallChange = 0;
            this.TrackBar.TabIndex = 0;
            this.TrackBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.TrackBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.TrackBar.ThumbLength = 18;
            this.TrackBar.ThumbMargin = 1;
            this.TrackBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.TrackBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.TrackBar.Value = 0;
            this.TrackBar.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.TrackBar_ValueChanged);
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // MusicBox
            // 
            this.MusicBox.AllowDrop = true;
            this.MusicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.MusicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MusicBox.FormattingEnabled = true;
            this.MusicBox.ItemHeight = 25;
            this.MusicBox.Location = new System.Drawing.Point(650, 50);
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(450, 500);
            this.MusicBox.TabIndex = 3;
            this.MusicBox.SelectedIndexChanged += new System.EventHandler(this.MusicBox_SelectedIndexChanged);
            this.MusicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MusicBox_DragDrop);
            this.MusicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MusicBox_DragEnter);
            // 
            // Artistlbl
            // 
            this.Artistlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Artistlbl.AutoSize = true;
            this.Artistlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artistlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Artistlbl.Location = new System.Drawing.Point(7, 406);
            this.Artistlbl.Name = "Artistlbl";
            this.Artistlbl.Size = new System.Drawing.Size(0, 25);
            this.Artistlbl.TabIndex = 13;
            this.Artistlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artistlbl_MouseDown);
            // 
            // Titlelbl
            // 
            this.Titlelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Titlelbl.Location = new System.Drawing.Point(7, 431);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(0, 25);
            this.Titlelbl.TabIndex = 14;
            this.Titlelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlelbl_MouseDown);
            // 
            // Genrelbl
            // 
            this.Genrelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Genrelbl.AutoSize = true;
            this.Genrelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genrelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Genrelbl.Location = new System.Drawing.Point(7, 456);
            this.Genrelbl.Name = "Genrelbl";
            this.Genrelbl.Size = new System.Drawing.Size(0, 25);
            this.Genrelbl.TabIndex = 15;
            this.Genrelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Genrelbl_MouseDown);
            // 
            // Yearlbl
            // 
            this.Yearlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Yearlbl.AutoSize = true;
            this.Yearlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Yearlbl.Location = new System.Drawing.Point(7, 481);
            this.Yearlbl.Name = "Yearlbl";
            this.Yearlbl.Size = new System.Drawing.Size(0, 25);
            this.Yearlbl.TabIndex = 16;
            this.Yearlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yearlbl_MouseDown);
            // 
            // Durationlbl
            // 
            this.Durationlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Durationlbl.AutoSize = true;
            this.Durationlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durationlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Durationlbl.Location = new System.Drawing.Point(7, 506);
            this.Durationlbl.Name = "Durationlbl";
            this.Durationlbl.Size = new System.Drawing.Size(0, 25);
            this.Durationlbl.TabIndex = 17;
            this.Durationlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Durationlbl_MouseDown);
            // 
            // PlayListtmr
            // 
            this.PlayListtmr.Interval = 5000;
            this.PlayListtmr.Tick += new System.EventHandler(this.PlayListtmr_Tick);
            // 
            // TrackBarTimer
            // 
            this.TrackBarTimer.Interval = 250;
            this.TrackBarTimer.Tick += new System.EventHandler(this.TrackBarTimer_Tick);
            // 
            // RepeatOnetmr
            // 
            this.RepeatOnetmr.Tick += new System.EventHandler(this.RepeatOnetmr_Tick);
            // 
            // Visualstmr
            // 
            this.Visualstmr.Interval = 33;
            this.Visualstmr.Tick += new System.EventHandler(this.Visualstmr_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 344);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.Durationlbl);
            this.Controls.Add(this.Yearlbl);
            this.Controls.Add(this.Genrelbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.Artistlbl);
            this.Controls.Add(this.MusicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBarPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.TitleBarPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPnl;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuHSlider TrackBar;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button SkipNextBtn;
        private System.Windows.Forms.Button SkipPreviousBtn;
        private System.Windows.Forms.Button RepeatBtn;
        private System.Windows.Forms.Button ShuffleBtn;
        private System.Windows.Forms.Button OpenBtn;
        private Bunifu.UI.WinForms.BunifuHSlider VolumeBar;
        private System.Windows.Forms.Button SwitchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox MusicBox;
        private System.Windows.Forms.Label Artistlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Genrelbl;
        private System.Windows.Forms.Label Yearlbl;
        private System.Windows.Forms.Label Durationlbl;
        private System.Windows.Forms.Timer PlayListtmr;
        private System.Windows.Forms.Timer TrackBarTimer;
        private System.Windows.Forms.Timer RepeatOnetmr;
        private System.Windows.Forms.Timer Visualstmr;
        private Bunifu.UI.WinForms.BunifuTextBox Searchtxt;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Button PlaylistBtn;
        private System.Windows.Forms.Button ImportBtn;
    }
}

