using System.Diagnostics;
using NLog;

namespace FileDateTime_Manipulator
{
	/// <summary>
	/// Main class of the program.
	/// </summary>
	internal static class Program
	{
		/// <summary>Logger instance for logging messages and exceptions.</summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		private static void Main()
		{
			try
			{
				// Initializes the application configurations
				ApplicationConfiguration.Initialize();
				Logger.Info(message: "Application started.");

				// Starts the main form of the application
				using FdtmForm mainForm = new();
				Application.Run(mainForm: mainForm);
			}
			catch (InvalidOperationException ex)
			{
				// Handle specific InvalidOperationException
				const string message = "An invalid operation occurred. Please try again.";
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: message);
				LogError(ex: ex);
				ShowErrorMessage(message: message);
			}
			catch (Exception ex)
			{
				// Error handling: Log the error and display an error message
				const string message = "An unexpected error occurred. Please contact support.";
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: message);
				LogError(ex: ex);
				ShowErrorMessage(message: message);
			}
		}

		/// <summary>Logs the error details to the console or a logging system.</summary>
		/// <param name="ex">The exception to log.</param>
		private static void LogError(Exception ex)
		{
			// Implement logging logic here (e.g., log to a file or monitoring system)
			Console.WriteLine(value: $@"Error: {ex.Message} {ex.StackTrace}");
		}

		/// <summary>Displays an error message to the user.</summary>
		/// <param name="message">The error message to display.</param>
		private static void ShowErrorMessage(string message)
		{
			_ = MessageBox.Show(text: message, caption: @"Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}
	}
}
