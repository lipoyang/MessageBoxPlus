using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // MessageBox
using System.Threading; // Thread.Sleep

namespace MessageBoxPlus
{
    /// <summary>
    /// タイムアウト付きメッセージボックス
    /// </summary>
    public class TimedMessageBox
    {
        /// <summary>
        /// Show(制限時間[msec], テキスト)
        /// </summary>
        public static DialogResult Show(int timeout, string text)
        {
            var mboxForm = new MBoxForm();
            DialogResult result = mboxForm.ShowMbox(timeout, text);
            return result;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション
        /// </summary>
        public static DialogResult Show(int timeout, string text, string caption)
        {
            var mboxForm = new MBoxForm();
            DialogResult result = mboxForm.ShowMbox(timeout, text, caption);
            return result;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン)
        /// </summary>
        public static DialogResult Show(
            int timeout,
            string text,
            string caption = "",
            MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            var mboxForm = new MBoxForm();
            DialogResult result = mboxForm.ShowMbox(timeout, text, caption, buttons);
            return result;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン, アイコン)
        /// </summary>
        public static DialogResult Show(
            int timeout,
            string text,
            string caption = "",
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.None)
        {
            var mboxForm = new MBoxForm();
            DialogResult result = mboxForm.ShowMbox(timeout, text, caption, buttons, icon);
            return result;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン, アイコン, 既定のボタン)
        /// </summary>
        public static DialogResult Show(
            int timeout,
            string text,
            string caption = "",
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.None,
            MessageBoxDefaultButton defButton = MessageBoxDefaultButton.Button1)
        {
            var mboxForm = new MBoxForm();
            DialogResult result = mboxForm.ShowMbox(timeout, text, caption, buttons, icon, defButton);
            return result;
        }
    }

    // メッセージボックスを表示/消滅させるためのフォーム(これ自体は非表示)
    class MBoxForm : Form
    {
        // メッセージボックスを表示する
        public DialogResult ShowMbox(
            int timeout,
            string text,
            string caption = "",
            MessageBoxButtons buttons = MessageBoxButtons.OK,
            MessageBoxIcon icon = MessageBoxIcon.None,
            MessageBoxDefaultButton defButton = MessageBoxDefaultButton.Button1)
        {
             // タイムアウトの場合はNoneを返す
            DialogResult result = DialogResult.None;

            // タスク1 : メッセージボックスを表示し結果を待つ
            Task task1 = Task.Factory.StartNew(() =>
            {
                this.TopMost = true;
                result = MessageBox.Show(this, text, caption, buttons, icon, defButton);
            });

            // タスク2 : タイムアウト時間まで待つ
            Task task2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(timeout);
            });

            // どちらかのタスクの完了を待つ
            Task.WaitAny(task1, task2);

            // このフォームを閉じる (メッセージボックスも閉じる)
            this.BeginInvoke((Action)(() => {
                this.Close();
            }));

            return result;
        }
    }
}
