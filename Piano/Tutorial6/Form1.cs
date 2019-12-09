using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Tutorial6
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //사용가능한 장치를 담을 리스트를 생성하고
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            //현재 사용가능한 입력장치 리스트를 가져온다
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();

            //var형식은 할당되는 데이터를 파악해 컴파일러가 자동으로 해당변수의 형식을 지정한다
            //그래서 선언과 동시에 초기화를 해야한다
            foreach (var source in sources)
            {
                //foreach문을 이용해 sources에 있는 값을 source에 저장해주고 
                //ListViewItem 이라는 객체를 생성해주고 ListViewItem은 listbox를 제어하는 컨트롤 이다.
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item);
            }
        }

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        private void button2_Click(object sender, EventArgs e)
        {
            //시작버튼
            if (sourceList.SelectedItems.Count == 0)
                return;
            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveInProvider(sourceStream);

            waveOut = new NAudio.Wave.DirectSoundOut();
            waveOut.Init(waveIn);

            sourceStream.StartRecording();
            waveOut.Play();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //정지 버튼
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
           if(waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //프로그램 종료 창
            button4_Click(sender, e);
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //저장 및 녹음시작
            label1.Visible = true;
            if (sourceList.SelectedItems.Count == 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);
            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }
        private void sourceStream_DataAvailable(object sender,NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
                
        }

        private void Button27_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key == Keys.A)
            {

                //Rectangle[] rect = new Rectangle[50];
                //foreach ( i in rect)
                //{

                //}

                button27.BackColor = Color.Black;
                player = new SoundPlayer(Properties.Resources._25);
                //player.Load();
                player.Play();
            }

            else if (key == Keys.S)
            {
                player = new SoundPlayer(Properties.Resources._26);

                button26.BackColor = Color.Orange;
                //player.PlaySync();
                player.Play();
            }
            else if (key == Keys.D)
            {
                player = new SoundPlayer(Properties.Resources._27);
                button14.BackColor = Color.Gold;
                player.Play();
            }
            else if (key == Keys.F)
            {
                player = new SoundPlayer(Properties.Resources._28);
                button6.BackColor = Color.DeepPink;
                player.Play();
            }
            else if (key == Keys.G)
            {
                player = new SoundPlayer(Properties.Resources._29);
                button7.BackColor = Color.Pink;
                player.Play();
            }
            else if (key == Keys.H)
            {
                player = new SoundPlayer(Properties.Resources._30);
                button9.BackColor = Color.Navy;
                player.Play();
            }
            else if (key == Keys.J)
            {
                player = new SoundPlayer(Properties.Resources._31);
                button11.BackColor = Color.Aqua;
                player.Play();
            }
            else if (key == Keys.K)
            {
                player = new SoundPlayer(Properties.Resources._32);
                button21.BackColor = Color.CadetBlue;
                player.Play();
            }
            else if (key == Keys.L)
            {
                player = new SoundPlayer(Properties.Resources._33);
                button20.BackColor = Color.Blue;
                player.Play();
            }
            else if (key == Keys.Z)
            {
                player = new SoundPlayer(Properties.Resources._34);
                button19.BackColor = Color.Khaki;
                player.Play();
            }
            else if (key == Keys.X)
            {
                player = new SoundPlayer(Properties.Resources._35);
                button18.BackColor = Color.Tan;
                player.Play();
            }
            else if (key == Keys.C)
            {
                player = new SoundPlayer(Properties.Resources._36);
                button17.BackColor = Color.Blue;
                player.Play();
            }
            else if (key == Keys.V)
            {
                player = new SoundPlayer(Properties.Resources._37);
                button16.BackColor = Color.Cyan;
                player.Play();
            }

            Invalidate();
        }

        private void Button27_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (key == Keys.A)
            {
                button27.BackColor = Color.White;
            }
            else if (key == Keys.S)
            {
                button26.BackColor = Color.White;
            }
            else if (key == Keys.D)
            {
                button14.BackColor = Color.White;
            }
            else if (key == Keys.F)
            {
                button6.BackColor = Color.White;
            }
            else if (key == Keys.G)
            {
                button7.BackColor = Color.White;
            }
            else if (key == Keys.H)
            {
                button9.BackColor = Color.White;
            }
            else if (key == Keys.J)
            {
                button11.BackColor = Color.White;
            }
            else if (key == Keys.K)
            {
                button21.BackColor = Color.White;
            }
            else if (key == Keys.L)
            {
                button20.BackColor = Color.White;
            }
            else if (key == Keys.Z)
            {
                button19.BackColor = Color.White;
            }
            else if (key == Keys.X)
            {
                button18.BackColor = Color.White;
            }
            else if (key == Keys.C)
            {
                button17.BackColor = Color.White;
            }
            else if (key == Keys.V)
            {
                button16.BackColor = Color.White;
            }
            Invalidate();
        
        }


    }
}
