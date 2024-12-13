using BinaryTreeMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void Start_bt_Click(object sender, EventArgs e)
        {
            Start_bt.Visible = false;
            Load_bt.Visible = false;
            Quit_bt.Visible = false;
            Demand_lb.Visible = true;
            Expression_txtb.Visible = true;
            Expression_txtb.ReadOnly = false;
            Cal_bt.Visible = true;
            Demand_lb.Text = "Nhập biểu thức cần tính toán";
        }
        private List<string> calculationHistory = new List<string>();
        private void Cal_bt_Click(object sender, EventArgs e)
        {
            Demand_lb.Text = "KẾT QUẢ";
            Equal_lb.Visible = true;
            Cal_bt.Visible = false;
            result_txtb.Visible = true;
            Expression_txtb.ReadOnly = true;
            continue_bt.Visible = true;
            title_bt.Visible = true;
            try
            {
                BinaryTree tree = new BinaryTree();
                Node root = tree.BuildTree(Expression_txtb.Text);
                double result = tree.Evaluate(root);
                UpdateMemory(result);
                preans_bt.Visible = true;
                result_txtb.Text = result.ToString();
                calculationHistory.Add($"Biểu thức: {Expression_txtb.Text}, Kết quả: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã xảy ra lỗi");
                result_txtb.Text = $"Error";
            }

        }
        private void title_bt_Click(object sender, EventArgs e)
        {
            Start_bt.Visible = true;
            Load_bt.Visible = true;
            Load_bt.Enabled = true;
            Quit_bt.Visible = true;
            Demand_lb.Visible = false;
            Equal_lb.Visible = false;
            Cal_bt.Visible = false;
            result_txtb.Visible = false;
            Expression_txtb.Visible = false;
            continue_bt.Visible = false;
            title_bt.Visible = false;
            preans_bt.Visible = false;
        }

        private void Quit_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continue_bt_Click(object sender, EventArgs e)
        {
            Demand_lb.Visible = true;
            Expression_txtb.Visible = true;
            Expression_txtb.ReadOnly = false;           
            Equal_lb.Visible = false;
            result_txtb.Visible = false;
            Demand_lb.Text = "Nhập biểu thức cần tính toán";
            continue_bt.Visible = false;
            title_bt.Visible = false;
            preans_bt.Visible = false;
            Cal_bt.Visible = true;
        }
        private void preans_bt_Click(object sender, EventArgs e)
        {
            
            Expression_txtb.Text = PreAnswer.ToString();
            Expression_txtb.ReadOnly = false;
            continue_bt.Visible = false;
            title_bt.Visible = false;
            preans_bt.Visible = false;
            Cal_bt.Visible = true;
            result_txtb.Visible = false;
        }
        private void Load_bt_Click(object sender, EventArgs e)
        {
            // Tạo giao diện hiển thị lịch sử
            Panel historyPanel = new Panel
            {
                Size = new Size(400, 300),
                Location = new Point(50, 50),
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            ListBox historyListBox = new ListBox
            {
                Size = new Size(380, 260),
                Location = new Point(10, 10),
                Font = new Font("Consolas", 15, FontStyle.Regular) // Thay đổi font chữ               
            };

            Button closeHistoryButton = new Button
            {
                Text = "CLOSE",
                Size = new Size(100, 30),
                Location = new Point(150, 270),
                Font = new Font("Consolas", 15, FontStyle.Bold), // Thay đổi font chữ
                BackColor = Color.White
            };
            closeHistoryButton.Click += (s, args) =>
            {
                historyPanel.Visible = false;
                Controls.Remove(historyPanel);
            };

            // Thêm lịch sử vào ListBox
            foreach (var record in calculationHistory)
            {
                historyListBox.Items.Add(record);
            }

            // Thêm các thành phần vào Panel
            historyPanel.Controls.Add(historyListBox);
            historyPanel.Controls.Add(closeHistoryButton);

            // Thêm Panel vào Form
            Controls.Add(historyPanel);
            historyPanel.BringToFront();
        }
        private double Answer = 0;
        private double PreAnswer = 0;
        // Phương thức để cập nhật Answer và PreAnswer
        public void UpdateMemory(double result)
        {
            PreAnswer = Answer;  // Cập nhật PreAnswer trước khi thay đổi Answer
            Answer = result;  // Cập nhật Answer với kết quả mới
        }
    }
}
