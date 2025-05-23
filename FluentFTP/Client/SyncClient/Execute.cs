﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Linq;
using System.Net;
using FluentFTP.Helpers;
using System.Threading;
using System.Threading.Tasks;

namespace FluentFTP {
	public partial class FtpClient {

		/// <summary>
		/// Executes a command
		/// </summary>
		/// <param name="command">The command to execute</param>
		/// <returns>The servers reply to the command</returns>
		public FtpReply Execute(string command) {
			return ((IInternalFtpClient)this).ExecuteInternal(command);
		}

		/// <summary>
		/// Executes a command
		/// </summary>
		/// <param name="command">The command to execute</param>
		/// <param name="linesExpected">-1 normal operation, 0 accumulate until timeOut, >0 accumulate until n msgs received</param>
		/// <returns>The servers reply to the command</returns>
		public FtpReply Execute(string command, int linesExpected) {
			return ((IInternalFtpClient)this).ExecuteInternal(command, linesExpected);
		}

	}
}