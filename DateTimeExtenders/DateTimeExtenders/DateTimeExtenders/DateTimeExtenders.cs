/*
The MIT License (MIT)

Copyright (c) 2016 ZZO

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

[Update History]
2016/10/23	ZZO(68B09)	First Release.
*/

using System;
using System.Collections.ObjectModel;

namespace DateTimeExtenders
{
	/// <summary>
	/// 日付拡張クラス
	/// </summary>
	public class DateTimeExtender
	{
		#region 固定値/フィールド/プロパティー
		/// <summary>
		/// 年齢計算タイプ
		/// </summary>
		public enum AgeCalculateType : int
		{
			Normal = 0,     // 同日に年を取る
			Legal = 1,      // 前日に年を取る(時刻切り捨て)
			Kazoe = 2,      // 数え年(生まれた日が1歳で、1/1に年を取る)
		}

		/// <summary>
		/// 十二支文字列
		/// </summary>
		static public ReadOnlyCollection<string> Eto = Array.AsReadOnly<string>(new string[] { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥", });
		#endregion

		#region コンストラクタ
		public DateTimeExtender()
		{
		}
		#endregion

		#region GetEto()
		/// <summary>
		/// 干支取得
		/// </summary>
		/// <param name="pYear">西暦年</param>
		/// <returns>干支文字列</returns>
		/// <seealso cref="System.Globalization.JapaneseLunisolarCalendar"/>
		/// <remarks>
		/// ・旧暦(太陰暦)は扱えません
		/// </remarks>
		static public string GetEto(int pYear)
		{
			return Eto[(pYear + 8) % 12];
		}
		#endregion

		#region GetAge()
		/// <summary>
		/// 年齢取得
		/// </summary>
		/// <param name="pBirthday">誕生日</param>
		/// <param name="pToday">基準日</param>
		/// <param name="pType">年齢計算タイプ</param>
		/// <returns>年齢</returns>
		/// <remarks>
		/// ・pBirthday及びpTodayともに、太陽暦で表された西暦を与えてください
		/// 　※明治6年1月1日より以前の日付を与えるときは注意してください
		/// </remarks>
		static public int GetAge(DateTime pBirthday, DateTime pToday, AgeCalculateType pType)
		{
			int i = pBirthday.CompareTo(pToday);
			if (i > 0) {
				throw new ArgumentOutOfRangeException("pBirthdayがpTodayより大きい");
			}

			// 時間が邪魔をしないようにするため、YMDだけを取り出す
			DateTime birthdayWk = new DateTime(pBirthday.Year, pBirthday.Month, pBirthday.Day);

			DateTime todayWk = new DateTime(pToday.Year, pToday.Month, pToday.Day);
			if (pType == AgeCalculateType.Legal) {
				todayWk = todayWk.AddDays(1);
			}

			int age = todayWk.Year - pBirthday.Year;
			if (pType == AgeCalculateType.Kazoe) {
				return age + 1;
			}

			if (todayWk.Month < pBirthday.Month) {
				age--;
			} else if ((todayWk.Month == pBirthday.Month) && (todayWk.Day < pBirthday.Day)) {
				age--;
			}

			return age;
		}
		#endregion
	}
}
