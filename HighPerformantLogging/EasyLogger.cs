
namespace HighPerformantLogging
{
	/// <summary>
	/// Class Logger.
	/// <see>
	///     <cref>https://dotnettips.wordpress.com/2022/06/24/speed-up-logging-in-net-6/</cref>
	/// </see>
	/// </summary>
	public static partial class EasyLogger
	{
		/// <summary>
		/// Logs critical message.
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		/// <param name="ex">The ex.</param>
		/// </summary>
		[LoggerMessage(EventId = 100, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{message}")]
		public static partial void LogCritical(ILogger logger, string message, Exception ex);

		/// <summary>
		/// Logs debug message.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		[LoggerMessage(EventId = 200, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{message}")]
		public static partial void LogDebug(ILogger logger, string message);

		/// <summary>
		/// Logs error message.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		/// <param name="ex">The ex.</param>
		[LoggerMessage(EventId = 300, Level = LogLevel.Error, EventName = "ERROR", Message = "{message}")]
		public static partial void LogError(ILogger logger, string message, Exception ex);

		/// <summary>
		/// Logs information message.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		[LoggerMessage(EventId = 400, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{message}")]
		public static partial void LogInformation(ILogger logger, string message);

		/// <summary>
		/// Logs trace message.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		[LoggerMessage(EventId = 500, Level = LogLevel.Trace, EventName = "TRACE", Message = "{message}")]
		public static partial void LogTrace(ILogger logger, string message);

		/// <summary>
		/// Logs warning message.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="message">The message.</param>
		[LoggerMessage(EventId = 600, Level = LogLevel.Warning, EventName = "WARNING", Message = "{message}")]
		public static partial void LogWarning(ILogger logger, string message);
	}
}