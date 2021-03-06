using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Task
using System.Windows.Forms; // MessageBox

namespace MessageBoxPlus
{
    /// <summary>
    /// タイムアウト付きのモードレスなメッセージボックス
    /// </summary>
    public class TimedModelessBox
    {
        /// <summary>
        /// Show(制限時間[msec], テキスト)
        /// </summary>
        public static Task<DialogResult> Show(int timeout, string text)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return TimedMessageBox.Show(timeout, text);
            });
            return task;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション)
        /// </summary>
        public static Task<DialogResult> Show(int timeout, string text, string caption)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return TimedMessageBox.Show(timeout, text, caption);
            });
            return task;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン)
        /// </summary>
        public static Task<DialogResult> Show(
            int timeout,
            string text,
            string caption,
            MessageBoxButtons buttons)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return TimedMessageBox.Show(timeout, text, caption, buttons);
            });
            return task;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン, アイコン)
        /// </summary>
        public static Task<DialogResult> Show(
            int timeout,
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return TimedMessageBox.Show(timeout, text, caption, buttons, icon);
            });
            return task;
        }

        /// <summary>
        /// Show(制限時間[msec], テキスト, キャプション, ボタン, アイコン, 既定のボタン)
        /// </summary>
        public static Task<DialogResult> Show(
            int timeout,
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defButton)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return TimedMessageBox.Show(timeout, text, caption, buttons, icon, defButton);
            });
            return task;
        }

    }
}
