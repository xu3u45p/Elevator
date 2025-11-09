using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
namespace Elevator
{
    public partial class Form1 : Form
    {
        class Elevator
        {
            private int current_floor;
            private readonly Label screen_elevator, screen_floor;
            private Button button, other_button;
            private Panel back, doorLeft, doorRight;
            public Elevator(Label label, Label label3, Button b1, Button b2, Panel p)
            {
                screen_elevator = label;
                screen_floor = label3;
                button = b1;
                other_button = b2;
                back = p;
                current_floor = Convert.ToInt32(screen_elevator.Text);

                screen_elevator.AutoSize = false;
                screen_elevator.TextAlign = ContentAlignment.MiddleCenter;
                screen_elevator.Width = 24;

                screen_floor.AutoSize = false;
                screen_floor.TextAlign = ContentAlignment.MiddleCenter;
                screen_floor.Width = 96;

                doorLeft = new Panel { BackColor = Color.Gray };
                doorRight = new Panel { BackColor = Color.Gray };

                int w = back.Width, h = back.Height;
                doorLeft.Bounds = new Rectangle(0, 0, w / 2 - 1, h);
                doorRight.Bounds = new Rectangle(w / 2, 0, w / 2 - 1, h);

                back.Controls.Add(doorLeft);
                back.Controls.Add(doorRight);
            }

            public async void display_floor(int user_at, int user_going)
            {
                button.Enabled = false;
                other_button.Enabled = false;
                bool at_ten_floor;

                // elevator moves to where user is at
                at_ten_floor = false;
                if (user_at > current_floor)
                {
                    for (int i = current_floor + 1; i <= user_at; i++)
                    {
                        await Task.Delay(1000);
                        if (i == 10)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 10f, screen_elevator.Font.Style);
                            at_ten_floor = true;
                        }
                        else if (at_ten_floor)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 12f, screen_elevator.Font.Style);
                            at_ten_floor = false;
                        }
                        screen_elevator.Text = i.ToString();
                    }
                }
                else
                {
                    for (int i = current_floor - 1; i >= user_at; i--)
                    {
                        await Task.Delay(1000);
                        if (i == 10)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 10f, screen_elevator.Font.Style);
                            at_ten_floor = true;
                        }
                        else if (at_ten_floor)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 12f, screen_elevator.Font.Style);
                            at_ten_floor = false;
                        }
                        screen_elevator.Text = i.ToString(); 
                    }
                }
                await Task.Delay(800);
                await this.openDoor();
                await Task.Delay(500);
                await this.closeDoor();

                // elevator moves to where user is going to
                at_ten_floor = false;
                if (user_going > user_at)
                {
                    for (int i = user_at + 1; i <= user_going; i++)
                    {
                        await Task.Delay(1000);
                        if (i == 10)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 10f, screen_elevator.Font.Style);
                            screen_floor.Font = new Font(screen_elevator.Font.FontFamily, 42f, screen_elevator.Font.Style | FontStyle.Bold);
                            at_ten_floor = true;
                        }
                        else if (at_ten_floor)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 12f, screen_elevator.Font.Style);
                            screen_floor.Font = new Font(screen_elevator.Font.FontFamily, 48f, screen_elevator.Font.Style | FontStyle.Bold);
                            at_ten_floor = false;
                        }
                        screen_elevator.Text = i.ToString();
                        screen_floor.Text = i.ToString();
                    }
                }
                else
                {
                    for (int i = user_at - 1; i >= user_going; i--)
                    {
                        await Task.Delay(1000);
                        if (i == 10)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 10f, screen_elevator.Font.Style);
                            screen_floor.Font = new Font(screen_elevator.Font.FontFamily, 42f, screen_elevator.Font.Style);
                            at_ten_floor = true;
                        }
                        else if (at_ten_floor)
                        {
                            screen_elevator.Font = new Font(screen_elevator.Font.FontFamily, 12f, screen_elevator.Font.Style);
                            screen_floor.Font = new Font(screen_elevator.Font.FontFamily, 48f, screen_elevator.Font.Style);
                            at_ten_floor = false;
                        }
                        screen_elevator.Text = i.ToString();
                        
                    }
                }
                button.Enabled = true;
                other_button.Enabled = true;
            }
            public void move(int user_at, int user_going)
            {
                this.display_floor(user_at, user_going);
                current_floor = user_going;
            }
            public async Task openDoor(int durationMs = 800, int fps = 60)
            {

                int steps = Math.Max(1, durationMs * fps / 1000);
                int w = back.Width;

                int startL = doorLeft.Left;
                int startR = doorRight.Left;
                int endL = -w / 2;
                int endR = w;

                for (int i = 1; i <= steps; i++)
                {
                    double t = (double)i / steps;
                    doorLeft.Left = startL + (int)Math.Round((endL - startL) * t);
                    doorRight.Left = startR + (int)Math.Round((endR - startR) * t);
                    await Task.Delay(1000 / fps);
                }
            }

            public async Task closeDoor(int durationMs = 800, int fps = 60)
            {
                int steps = Math.Max(1, durationMs * fps / 1000);
                int w = back.Width;

                int startL = doorLeft.Left;
                int startR = doorRight.Left;
                int endL = 0;
                int endR = w / 2;

                for (int i = 1; i <= steps; i++)
                {
                    double t = (double)i / steps;
                    doorLeft.Left = startL + (int)Math.Round((endL - startL) * t);
                    doorRight.Left = startR + (int)Math.Round((endR - startR) * t);
                    await Task.Delay(1000 / fps);
                }
            }
        }
        private Elevator elevator1;
        private Elevator elevator2;

        public Form1()
        {
            InitializeComponent();
            elevator1 = new Elevator(label1, label3, button1, button2, panel1);
            elevator2 = new Elevator(label2, label3, button2, button1, panel5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool check_input(TextBox textBox, out int user_at, out int user_going)
        {
            user_at = Convert.ToInt32(label3.Text);
            user_going = -1;
            try
            {
                bool okInt = int.TryParse(textBox.Text, out user_going);
                textBox.Text = "";
                if (!okInt)
                {
                    throw new Exception("請輸入數字，範圍為1至10。");
                }
                if (user_going < 1 || user_going > 10)
                {
                    throw new Exception("本棟建築只有1至10層。");
                }
                if (user_at == user_going)
                {
                    throw new Exception("你已經在第" + user_going + "層了。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_at, user_going;
            if(check_input(textBox1, out user_at, out user_going))
            {
                elevator1.move(user_at, user_going);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int user_at, user_going;
            if (check_input(textBox2, out user_at, out user_going))
            {
                elevator2.move(user_at, user_going);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
