using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxPlus;

namespace TestApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // テスト1 : モードレスなメッセージボックスの簡単な使い方
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト1のボタンが押されました");

            ModelessMessageBox.Show("テスト1");

            Console.WriteLine("メッセージボックスを表示しました");
        }

        // テスト2 : モードレスなメッセージボックスから結果を取得 (非同期処理)
        private async void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト2のボタンが押されました");

            var task = ModelessMessageBox.Show(
                "結果を返すテストです",
                "テスト2",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            Console.WriteLine("メッセージボックスを表示しました");

            var result = await task;

            Console.WriteLine("結果が返りました : " + result.ToString());

        }

        // テスト3 : タイムアウト付きメッセージボックスの簡単な使い方
        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト3のボタンが押されました");

            TimedMessageBox.Show(5000, "テスト3 (5秒で閉じます)");

            Console.WriteLine("メッセージボックスが閉じました");
        }

        // テスト4 : タイムアウト付きメッセージボックスから結果を取得
        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト4のボタンが押されました");

            var result = TimedMessageBox.Show(
                5000,
                "結果を返すテストです",
                "テスト4 (5秒で閉じます)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            Console.WriteLine("結果が返りました : " + result.ToString());
        }

        // テスト5 : タイムアウト付きのモードレスなメッセージボックスの簡単な使い方
        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト5のボタンが押されました");

            TimedModelessBox.Show(5000, "テスト5 (5秒で閉じます)");

            Console.WriteLine("メッセージボックスが閉じました");
        }

        // テスト6 : タイムアウト付きのモードレスなメッセージボックスから結果を取得
        private async void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("テスト6のボタンが押されました");

            var task = TimedModelessBox.Show(
                5000,
                "結果を返すテストです",
                "テスト6 (5秒で閉じます)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            Console.WriteLine("メッセージボックスを表示しました");

            var result = await task;

            Console.WriteLine("結果が返りました : " + result.ToString());

        }
    }
}
