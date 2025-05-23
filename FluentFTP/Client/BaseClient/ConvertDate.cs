﻿using FluentFTP.Client.Modules;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FluentFTP.Client.BaseClient {

	public partial class BaseFtpClient {

		/// <summary>
		/// If `reverse` is false, converts the date provided by the FTP server into the timezone required locally.
		/// If `reverse` is true, converts the local timezone date into the date required by the FTP server.
		/// <para>
		/// Affected by properties:
		/// <list type="bullet">
		/// <item>TimeConversion</item>
		/// <item>ServerTimeZone</item>
		/// <item>ClientTimeZone</item>
		/// </list>
		/// </para>
		/// </summary>
		public DateTime ConvertDate(DateTime date, bool reverse = false) {
			return TimezoneModule.ConvertDate(date, Config, reverse);
		}

	}
}