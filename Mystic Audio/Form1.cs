using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using TagLib;
using Un4seen.Bass;

namespace Mystic_Audio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Un4seen.Bass.BassNet.Registration("Donjffrs50@gmail.com", "2X9243620152222");
            Bass.BASS_Init(1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            TrackBar.Maximum = 100;
            TrackBar.Minimum = 50;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL,VolumeBar.Value / 100f);
            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
            if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #region Variables

        private ObservableCollection<Song> Songs = new ObservableCollection<Song>();
        private ObservableCollection<Song> History = new ObservableCollection<Song>();
        private ObservableCollection<Song> Files = new ObservableCollection<Song>();
        private ObservableCollection<Song> Music = new ObservableCollection<Song>();
        private List<XElement> Playlist = new List<XElement>();
        private ObservableCollection<Song> songlist = new ObservableCollection<Song>();
        private int stream = -1;
        bool shouldChangePosition = false;

        float[] dd = new float[1024];
        Bitmap bmp = new Bitmap(632, 344);

        Brush b ;
        Brush b2 ;
        Un4seen.Bass.Misc.Visuals spektrum = new Un4seen.Bass.Misc.Visuals();

        float dIncreaser(float i, float max)
        {
            float k;
            k = 1 + (float)Math.Sqrt(i * 2);
            return k;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool CheckRepeatedSong(string path)
        {
            bool isExist = false;
            for (int i = 0; i < History.Count; i++)
            {
                if (History[i].FilePath == path)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        private DialogResult result;

        #endregion


        #region Helpers
        public void RemoveItem(ObservableCollection<Song> collection, Song instance)
        {
            collection.Remove(collection.Where(i => i.FilePath == instance.FilePath).Single());
        }


        #endregion

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Mp3 files (*.mp3)|*.mp3";
            dlg.Multiselect = true;
            dlg.Title = "Open Aidio Files";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                {
                    Song song = new Song(file);
                    var f = TagLib.File.Create(file); // Change file path accordingly.
                    song.Album = f.Tag.Album;
                    song.Artists = f.Tag.FirstPerformer;
                    song.Title = f.Tag.Title;
                    song.Genre = f.Tag.FirstGenre;
                    song.Year = f.Tag.Year.ToString();
                    song.Duration = f.Properties.Duration.TotalSeconds.ToString();
                    song.FilePath = file;


                    if (f.Tag.Pictures.Length > 0)
                    {
                        var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                        song.CoverArt = Image.FromStream(new MemoryStream(bin));
                    }
                    MusicBox.DataSource = null;
                    Songs.Add(song);
                    MusicBox.DataSource = Songs;
                    this.MusicBox.DisplayMember = "Title"; //Column's name which you want to show in the list
                    this.MusicBox.ValueMember = "Title";
                }
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (MusicBox.Items != null)
            {
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                PlayListtmr.Enabled = true;
                PlayListtmr.Start();
                TrackBarTimer.Enabled = true;
                TrackBarTimer.Start();
                Song song = MusicBox.SelectedItems[0] as Song;

                Un4seen.Bass.BASSActive isActive = default(Un4seen.Bass.BASSActive);

                isActive = Bass.BASS_ChannelIsActive(stream);
                if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelStop(stream);
                }

                
                stream = Bass.BASS_StreamCreateFile(song.FilePath, 0, 0, BASSFlag.BASS_STREAM_AUTOFREE | BASSFlag.BASS_STREAM_PRESCAN);
                

                Bass.BASS_ChannelPlay(stream, false);

                long pos = 0;
                long len = 0;
                len = Bass.BASS_ChannelGetLength(stream);
                pos = Bass.BASS_ChannelGetPosition(stream);
                if (pos >= len)
                {
                    if (!CheckRepeatedSong(song.FilePath))
                    {
                        History.Add(song);
                    }
                    
                }

            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (MusicBox.Items != null)
            {
                Un4seen.Bass.BASSActive isActive = default(Un4seen.Bass.BASSActive);
                isActive = Bass.BASS_ChannelIsActive(stream);
                if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                    PlayListtmr.Enabled = false;
                    PlayListtmr.Stop();
                    TrackBarTimer.Enabled = false;
                    TrackBarTimer.Stop();
                    PlayBtn.Enabled = false;
                    Bass.BASS_ChannelPause(stream);
                    
                }
                else if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PAUSED)
                {
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                    PlayListtmr.Enabled = true;
                    PlayListtmr.Start();
                    TrackBarTimer.Enabled = true;
                    TrackBarTimer.Start();
                    PlayBtn.Enabled = true;
                    Bass.BASS_ChannelPlay(stream, false);
                    

                }
            }
        }

        private void MusicBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            Song song = MusicBox.SelectedItem as Song;

            if (MusicBox.Items != null  && song != null)
            {
                long pos = 0;
                long len = 0;
                len = Bass.BASS_ChannelGetLength(stream);
                pos = Bass.BASS_ChannelGetPosition(stream);
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                if (pos >= len)
                {

                    if (!CheckRepeatedSong(song.FilePath))
                    {
                        History.Add(song);
                    }
                }
                PlayListtmr.Enabled = true;
                PlayListtmr.Start();
                TrackBarTimer.Enabled = true;
                TrackBarTimer.Start();
                Un4seen.Bass.BASSActive isActive = default(Un4seen.Bass.BASSActive);

                isActive = Bass.BASS_ChannelIsActive(stream);
                if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelStop(stream);
                }

                // If ofd.FileName = "" Then Exit Sub
                stream = Bass.BASS_StreamCreateFile(song.FilePath, 0, 0, BASSFlag.BASS_STREAM_AUTOFREE | BASSFlag.BASS_STREAM_PRESCAN);
                //stream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);

                //  stream = Bass.BASS_Stream
                Bass.BASS_ChannelPlay(stream, false);

                var f = TagLib.File.Create(song.FilePath); // Change file path accordingly.
                Artistlbl.Text = f.Tag.FirstPerformer;
                Titlelbl.Text = f.Tag.Title;
                Genrelbl.Text = f.Tag.FirstGenre;
                Yearlbl.Text = f.Tag.Year.ToString();
                Durationlbl.Text = f.Properties.Duration.TotalSeconds.ToString();
                if (f.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    pictureBox1.BackgroundImage = song.CoverArt;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            TrackBarTimer.Enabled = false;
            TrackBarTimer.Stop();
            RepeatOnetmr.Enabled = false;
            RepeatOnetmr.Stop();
            PlayListtmr.Enabled = false;
            PlayListtmr.Stop();
            Bass.BASS_ChannelStop(stream);
            
        }

        private void PlayListtmr_Tick(object sender, EventArgs e)
        {
            long pos = 0;
            long len = 0;
            len = Bass.BASS_ChannelGetLength(stream);
            pos = Bass.BASS_ChannelGetPosition(stream);

            if (pos >= len)
            {
                Song song = MusicBox.SelectedItems[0] as Song;
                
                SkipNextBtn_Click(sender, e);
                if (!CheckRepeatedSong(song.FilePath))
                {
                    History.Add(song);
                }
            }
        }

        private void SkipNextBtn_Click(object sender, EventArgs e)
        {
            if (MusicBox.Items != null)
            {
                try
                {
                    long pos = 0;
                    long len = 0;
                    len = Bass.BASS_ChannelGetLength(stream);
                    pos = Bass.BASS_ChannelGetPosition(stream);

                    if (pos >= len)
                    {
                        Song song = MusicBox.SelectedItems[0] as Song;

                        if (!CheckRepeatedSong(song.FilePath))
                        {
                            History.Add(song);
                        }
                    }
                    PlayListtmr.Enabled = true;
                    PlayListtmr.Start();
                    TrackBarTimer.Enabled = true;
                    TrackBarTimer.Start();
                    //int index = listBox_songs.SelectedIndex;
                    //listBox_songs.SelectedItem = listBox_songs.Items[index + 1];
                    MusicBox.SelectedIndex++;
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                }
                catch (ArgumentOutOfRangeException)
                {
                    MusicBox.SelectedItem = MusicBox.Items[0];
                }
            }
        }

        private void SkipPreviousBtn_Click(object sender, EventArgs e)
        {
            if (MusicBox.Items != null)
            {
                try
                {
                    long pos = 0;
                    long len = 0;
                    len = Bass.BASS_ChannelGetLength(stream);
                    pos = Bass.BASS_ChannelGetPosition(stream);

                    if (pos >= len)
                    {
                        Song song = MusicBox.SelectedItems[0] as Song;

                        if (!CheckRepeatedSong(song.FilePath))
                        {
                            History.Add(song);
                        }
                    }
                    PlayListtmr.Enabled = true;
                    PlayListtmr.Start();
                    TrackBarTimer.Enabled = true;
                    TrackBarTimer.Start();
                    //int index = listBox_songs.SelectedIndex;
                    //listBox_songs.SelectedItem = listBox_songs.Items[index - 1];
                    MusicBox.SelectedIndex--;
                    Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

                }
                catch (ArgumentOutOfRangeException)
                {
                    MusicBox.SelectedItem = MusicBox.Items[MusicBox.Items.Count - 1];
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            PlayListtmr.Enabled = false;
            PlayListtmr.Stop();
            TrackBarTimer.Enabled = false;
            TrackBarTimer.Stop();
            // free the stream
            Bass.BASS_StreamFree(stream);
            // free BASS
            Bass.BASS_Free();
            Environment.Exit(0);
        }

        private void TrackBarTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                TrackBar.Maximum = (int)(Bass.BASS_ChannelGetLength(stream) / 1000);
                //TrackBar.Minimum = TrackBar.Maximum;
                TrackBar.Value = (int)(Bass.BASS_ChannelGetPosition(stream) / 1000);

                long pos = 0;
                long len = 0;
                len = Bass.BASS_ChannelGetLength(stream);
                pos = Bass.BASS_ChannelGetPosition(stream);

                if (pos >= len)
                {
                    Song song = MusicBox.SelectedItems[0] as Song;

                    if (!CheckRepeatedSong(song.FilePath))
                    {
                        History.Add(song);
                    }
                }
            }
            catch
            {

            }
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            shouldChangePosition = true;
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            shouldChangePosition = false;
        }

        private void TrackBar_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {

            if (shouldChangePosition)
            {
                Bass.BASS_ChannelSetPosition(stream, TrackBar.Value * 1000);
            }
        }

        private void RepeatOnetmr_Tick(object sender, EventArgs e)
        {
            long pos = 0;
            long len = 0;
            len = Bass.BASS_ChannelGetLength(stream);
            pos = Bass.BASS_ChannelGetPosition(stream);
            if (pos >= len)
            {
                Song song = MusicBox.SelectedItems[0] as Song;

                stream = Bass.BASS_StreamCreateFile(song.FilePath, 0, 0, BASSFlag.BASS_STREAM_AUTOFREE | BASSFlag.BASS_STREAM_PRESCAN);

                Un4seen.Bass.BASSActive isActive = default(Un4seen.Bass.BASSActive);

                isActive = Bass.BASS_ChannelIsActive(stream);
                if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
                {
                    Bass.BASS_ChannelStop(stream);
                }
                Bass.BASS_ChannelSetPosition(stream, 0, BASSMode.BASS_POS_BYTES);

                //  stream = Bass.BASS_Stream
                Bass.BASS_ChannelPlay(stream, false);
                if (!CheckRepeatedSong(song.FilePath))
                {
                    History.Add(song);
                }
            }
        }

        private void RepeatBtn_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

            PlayListtmr.Enabled = false;
            PlayListtmr.Stop();
            RepeatOnetmr.Enabled = true;
            RepeatOnetmr.Start();
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100f);

            Random rng = new Random();
            int n = Songs.Count;
            //begin updating
            MusicBox.BeginUpdate();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = Songs[k];
                Songs[k] = Songs[n];
                Songs[n] = (Song)value;
                MusicBox.DataSource = Songs;
                MusicBox.SelectedIndex = n;
            }

            MusicBox.EndUpdate();
            MusicBox.Invalidate();
            PlayListtmr.Enabled = true;
            PlayListtmr.Start();
            TrackBarTimer.Enabled = true;
            TrackBarTimer.Start();

            long pos = 0;
            long len = 0;
            len = Bass.BASS_ChannelGetLength(stream);
            pos = Bass.BASS_ChannelGetPosition(stream);

            if (pos >= len)
            {
                Song song = MusicBox.SelectedItems[0] as Song;

                if (!CheckRepeatedSong(song.FilePath))
                {
                    History.Add(song);
                }
            }
        }

        private void Visualstmr_Tick(object sender, EventArgs e)
        {
            b = new SolidBrush(Color.FromArgb(0, 122, 204));
            b2 = new SolidBrush(Color.Transparent);




            Graphics g = Graphics.FromImage(bmp);

            float[] d = new float[1024];

            g.Clear(Color.Transparent);
            Un4seen.Bass.BASSActive isActive = default(Un4seen.Bass.BASSActive);
            isActive = Bass.BASS_ChannelIsActive(stream);

            if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
            {

                Bass.BASS_ChannelGetData(stream, d, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT1024);
            }
            else if (isActive == Un4seen.Bass.BASSActive.BASS_ACTIVE_PAUSED)
            {
                for (int i = 0; i <= 1023; i++)
                {
                    d[i] = d[i] - 0.002F;
                    d[i] = Math.Max(d[i], 0);
                }
            }

            int amount = 512;
            int step = (int)(1024 / amount);
            float x, y, w, h;

            int j = -1;

            for (int i = 0; i < 1024; i += step)
            {

                j++;
                x = ((float)i / (float)amount * bmp.Width);
                w = Math.Max(((float)bmp.Width / (float)amount), 3);

                y = bmp.Height * (1 - d[i] * dIncreaser(i, 1024)) - 2;
                h = bmp.Height + 2;// -y - 3;

                g.FillRectangle(b, x, y, w, h - y);

                dd[i] = dd[i] - 0.002F;
                if (dd[i] < d[i])
                    dd[i] = d[i];

                y = bmp.Height * (1 - dd[i] * dIncreaser(i, 1024)) - 2;
                g.FillRectangle(b2, x, y, w, 2);

            }
            pictureBox1.BackgroundImage = null;
            pictureBox1.Image = bmp;
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            Visualstmr.Enabled = true;
            Visualstmr.Start();
            Song song = MusicBox.SelectedItem as Song;

            if (pictureBox1.Image == bmp && MusicBox.SelectedItem != null)
            {
                MusicBox.SelectedIndex = MusicBox.SelectedIndex;
                pictureBox1.Image = null;
                Visualstmr.Enabled = false;
                Visualstmr.Stop();
                var f = TagLib.File.Create(song.FilePath); // Change file path accordingly.
                


                if (f.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(bin));
                    pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                }
            }
            else
            {
                                   
                Visualstmr.Enabled = true;
                Visualstmr.Start();
            }
            
        }

        private void VolumeBar_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Bass.BASS_ChannelSetAttribute(stream, Un4seen.Bass.BASSAttribute.BASS_ATTRIB_VOL, VolumeBar.Value / 100F);

        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleBarPnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Artistlbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Titlelbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Genrelbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Durationlbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Yearlbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleBarPnl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            MusicBox.SelectedIndexChanged -= MusicBox_SelectedIndexChanged;

            // Music.Clear();
            Music.Clear();
            MusicBox.BeginUpdate();
            if (string.IsNullOrEmpty(Searchtxt.Text) == false)
            {
                MusicBox.DataSource = null;
                foreach (Song song in Songs)
                {
                    if (song.Title.StartsWith(Searchtxt.Text))
                    {

                        Music.Add(song);
                        MusicBox.DataSource = Music;
                        MusicBox.DisplayMember = "Title";
                    }
                }
            }
            else if (string.IsNullOrEmpty(Searchtxt.Text) == true)
            {
                MusicBox.SelectedIndexChanged += MusicBox_SelectedIndexChanged;
                if (MusicBox.SelectedIndex != MusicBox.SelectedIndex)
                {

                }
                MusicBox.DataSource = null;
                MusicBox.DataSource = Songs;
                MusicBox.DisplayMember = "Title";
            }
            MusicBox.EndUpdate();




            if (MusicBox.DataSource == History)
            {
                MusicBox.BeginUpdate();
                if (string.IsNullOrEmpty(Searchtxt.Text) == false)
                {

                    MusicBox.DataSource = null;
                    foreach (Song song in History)
                    {
                        if (song.Title.StartsWith(Searchtxt.Text))
                        {

                            History.Add(song);
                            MusicBox.DataSource = History;
                            MusicBox.DisplayMember = "Title";
                        }
                    }
                }
                else
                {

                    MusicBox.DataSource = null;
                    MusicBox.DataSource = Songs;
                    MusicBox.DisplayMember = "Title";
                }
                MusicBox.EndUpdate();
            }
            

        }

        private void MusicBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MusicBox_DragDrop(object sender, DragEventArgs e)
        {
            Files.Clear();
            MusicBox.BeginUpdate();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Song song = new Song(file);
                var f = TagLib.File.Create(file); // Change file path accordingly.
                song.Album = f.Tag.Album;
                song.Artists = f.Tag.FirstPerformer;
                song.Title = f.Tag.Title;
                song.Genre = f.Tag.FirstGenre;
                song.Year = f.Tag.Year.ToString();
                song.Duration = f.Properties.Duration.TotalSeconds.ToString();
                song.FilePath = file;


                if (f.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    song.CoverArt = Image.FromStream(new MemoryStream(bin));
                }
                Files.Add(song);
                MusicBox.DataSource = null;
                MusicBox.DataSource = Files;
                MusicBox.DisplayMember = "Title";
                MusicBox.EndUpdate();
            }
                
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            

            if (MusicBox.DataSource == Songs)
            {
               
                MusicBox.DataSource = History;
                MusicBox.DisplayMember = "Title";
                MusicBox.EndUpdate();
            }
            else
            {
                
                MusicBox.BeginUpdate();
                MusicBox.DataSource = null;

                MusicBox.DataSource = Songs;
                MusicBox.DisplayMember = "Title";
                MusicBox.EndUpdate();
            }
        }

        private void PlaylistBtn_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Are you sure you want to save your play list ?!","Mystic Audio",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "XML Files (*.xml)|*.xml";
                savefile.Title = "Save your playlist";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    XElement element = new XElement("Items");
                    foreach (Song item in MusicBox.SelectedItems)
                    {
                        element.Add(new XElement("Name", item.FilePath));
                    }
                    XDocument document = new XDocument();
                    document.Add(element);
                    document.Save(savefile.FileName, SaveOptions.DisableFormatting);
                }
                MessageBox.Show("Playlist saved !!", "Mystic Audio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Nothing was done !!", "Mystic Audio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Are you sure you want to load your play list ?!", "Mystic Audio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "XML files (*.xml)|*.xml";
                dlg.Multiselect = true;
                dlg.Title = "Open XML Files";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var xml = XElement.Load(dlg.FileName);
                    foreach (XElement item in xml.Descendants("Name"))
                    {
                        Song song = new Song(item.Value);
                        var f = TagLib.File.Create(item.Value); // Change file path accordingly.
                        song.FilePath = item.Value;
                        song.Album = f.Tag.Album;
                        song.Artists = f.Tag.FirstPerformer;
                        song.Title = f.Tag.Title;
                        song.Genre = f.Tag.FirstGenre;
                        song.Year = f.Tag.Year.ToString();
                        song.Duration = f.Properties.Duration.TotalSeconds.ToString();

                        if (f.Tag.Pictures.Length > 0)
                        {
                            var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                            song.CoverArt = Image.FromStream(new MemoryStream(bin));
                        }
                        Songs.Add(song);

                    }

                    MusicBox.DataSource = null;
                    MusicBox.DataSource = Songs;
                    MusicBox.DisplayMember = "Title";

                }
                    MessageBox.Show("Playlist loaded !!", "Mystic Audio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Nothing was done !!", "Mystic Audio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
