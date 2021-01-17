using System;
using System.Windows.Forms;

namespace Codr.Core.CodeEditor
{
    class CodeEditorHotKeys
    {
		public static bool Enable = true;

		/// <summary>
		/// Adds a new hotKey
		/// </summary>
		/// <param name="form"></param>
		/// <param name="function"></param>
		/// <param name="key"></param>
		/// <param name="ctrl"></param>
		/// <param name="shift"></param>
		/// <param name="alt"></param>
		public static void AddHotKey(Form form, Action function, Keys key, bool ctrl = false, bool shift = false, bool alt = false)
		{
			form.KeyPreview = true;

			form.KeyDown += delegate (object sender, KeyEventArgs e) {
				if (IsHotkey(e, key, ctrl, shift, alt))
				{
					function();
				}
			};
		}

		/// <summary>
		/// Checks if it is a hotKey
		/// </summary>
		/// <param name="eventData"></param>
		/// <param name="key"></param>
		/// <param name="ctrl"></param>
		/// <param name="shift"></param>
		/// <param name="alt"></param>
		/// <returns></returns>
		public static bool IsHotkey(KeyEventArgs eventData, Keys key, bool ctrl = false, bool shift = false, bool alt = false)
		{
			return eventData.KeyCode == key && eventData.Control == ctrl && eventData.Shift == shift && eventData.Alt == alt;
		}
	}
}
