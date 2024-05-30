namespace TicTacToe
{
    internal static class Program
    {

public class TicTacToeForm : Form
    {
        private Button[,] buttons = new Button[3, 3];
        private char currentPlayer = 'X';

        public TicTacToeForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.ClientSize = new Size(300, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "���� 3 � ���";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].Location = new Point(j * 100, i * 100);
                    buttons[i, j].Font = new Font("Arial", 24);
                    buttons[i, j].Click += ButtonClick;
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "")
            {
                button.Text = currentPlayer.ToString();
                if (CheckForWinner())
                {
                    MessageBox.Show($"����� {currentPlayer} �������!", "������");
                    ResetGame();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("�����!", "���� ��������");
                    ResetGame();
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }

        private bool CheckForWinner()
        {
            

            return false; // ������� true, ���� ������ ����������
        }

        private bool IsBoardFull()
        {
            // �������� ������������� �����
            // ...

            return false; // ������� true, ���� ����� ��������� ���������
        }

        private void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        private void ResetGame()
        {
            // ����� ����
            // ...
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicTacToeForm());
        }
    }

}
}