namespace Brown2D
{
    public partial class Brown2D : Form
    {
        public Brown2D()
        {
            InitializeComponent();

            var bmp = new Bitmap(300, 300);
            using(Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(Color.White);
            }
            brownPictureBox.Image = bmp;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                Drawing.getBounds(minBoundTextBox.Text, maxBoundTextBox.Text);
                var thread1 = new Thread(new ParameterizedThreadStart(ThreadTask!));
                var thread2 = new Thread(new ParameterizedThreadStart(ThreadTask!));
                var thread3 = new Thread(new ParameterizedThreadStart(ThreadTask!));

                thread1.Start(Color.Red);
                thread2.Start(Color.Yellow);
                thread3.Start(Color.Black);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Minimum value can't be greater than maximum value!");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the right values!");
            }
        }

        private void ThreadTask(object obj)
        {
            var drawing = new Drawing();
            var color = (Color)obj;
            drawing.pen = new Pen(color);
            for (int i = 0; i < 10; i++)
            {

                brownPictureBox.BeginInvoke(() =>
                {
                    drawing.setPicture(brownPictureBox);
                });

                Thread.Sleep(1000);
            }

        }
    }
}
