using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OwORhythmRewritten
{
	// Token: 0x02000003 RID: 3
	internal class XtraClass
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public static string OwO(string input)
		{
			string result;
			try
			{
				bool flag = input == null;
				if (flag)
				{
					result = null;
				}
				else
				{
					bool flag2 = input == "";
					if (flag2)
					{
						result = "";
					}
					else
					{
						string[] array = new string[]
						{
							"UwU"
						};
						string arg = array[new Random().Next(0, array.Length)];
						result = Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(input, "[rl]", "w"), "[RL]", "W"), "ove", "uv"), "n(?!(?:\\b|[y]))", "ny"), "N(?!(?:\\b|[Y]))", "NY"), "[!]", string.Format(" {0}", arg));
					}
				}
			}
			catch
			{
				result = input;
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002140 File Offset: 0x00000340
		public static string EscapeFormatting(string text)
		{
			StringBuilder stringBuilder = new StringBuilder(text.Length);
			bool flag = false;
			foreach (char c in text)
			{
				bool flag2 = flag;
				if (flag2)
				{
					bool flag3 = c == '>';
					if (flag3)
					{
						flag = false;
					}
				}
				else
				{
					bool flag4 = c == '<';
					if (flag4)
					{
						flag = true;
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021C0 File Offset: 0x000003C0
		public static string GetRankStringFromStringNumber(string input)
		{
			string result;
			try
			{
				bool flag = input == null;
				if (flag)
				{
					result = null;
				}
				else
				{
					bool flag2 = input == "";
					if (flag2)
					{
						result = "";
					}
					else
					{
						string text = string.Format("{0} ", input);
						string[] array = (from x in XtraClass.EscapeFormatting(input).Split(new char[]
						{
							' '
						})
										  select string.Format("{0} ", x)).Distinct<string>().ToArray<string>();
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						foreach (string text2 in array)
						{
							dictionary.Add(text2, XtraClass.OwO(text2));
							text = text.Replace(text2, XtraClass.OwO(text2));
						}
						result = text.Remove(text.Length - 1);
					}
				}
			}
			catch
			{
				result = input;
			}
			return result;
		}
	}
}
