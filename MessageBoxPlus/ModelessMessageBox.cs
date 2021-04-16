using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // Task
using System.Windows.Forms; // MessageBox

namespace MessageBoxPlus
{
    /// <summary>
    /// モードレスなメッセージボックス
    /// </summary>
    public class ModelessMessageBox
    {
        /// <summary>
        /// Show(テキスト)
        /// </summary>
        public static Task<DialogResult> Show(string text)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return MessageBox.Show(text);
            });
            return task;
        }

        /// <summary>
        /// Show(テキスト, キャプション)
        /// </summary>
        public static Task<DialogResult> Show(string text, string caption)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return MessageBox.Show(text, caption);
            });
            return task;
        }

        /// <summary>
        /// Show(テキスト, キャプション, ボタン)
        /// </summary>
        public static Task<DialogResult> Show(
            string text,
            string caption,
            MessageBoxButtons buttons)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return MessageBox.Show(text, caption, buttons);
            });
            return task;
        }

        /// <summary>
        /// Show(テキスト, キャプション, ボタン, アイコン)
        /// </summary>
        public static Task<DialogResult> Show(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return MessageBox.Show(text, caption, buttons, icon);
            });
            return task;
        }

        /// <summary>
        /// Show(テキスト, キャプション, ボタン, アイコン, 既定のボタン)
        /// </summary>
        public static Task<DialogResult> Show(
            string text,
            string caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defButton)
        {
            Task<DialogResult> task = Task.Run<DialogResult>(() =>
            {
                return MessageBox.Show(text, caption, buttons, icon, defButton);
            });
            return task;
        }
    }
}
